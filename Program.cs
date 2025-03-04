using BenchmarkBulkInsert.Benchmarks;
using BenchmarkBulkInsert.Db;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BenchmarkBulkInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BenchmarkDbContext())
            {
                Console.WriteLine("Creating database...");
                context.Database.EnsureCreated();

                context.Database.ExecuteSqlRaw("DELETE FROM Metars");
                context.Database.ExecuteSqlRaw("DELETE FROM MetarsWithUniqueConstraint");

                // Add test data to the database
                context.Metars.AddRange(DataProvider.GetTestData().Take(1000));
                context.MetarsWithUniqueConstraint.AddRange(DataProvider.GetTestMetarWithUniqueConstraint().Take(1000));
                context.SaveChanges();
            }

            int benchmarkType = GetBenchmarkTypeFromUser();
            int numberOfRuns = GetNumberOfRunsFromUser();

            RunBenchmark(benchmarkType, numberOfRuns);
        }

        static int GetBenchmarkTypeFromUser()
        {
            Console.WriteLine("Select a benchmark:");
            Console.WriteLine("1. Check before insert");
            Console.WriteLine("2. Insert and ignore duplicates for unique constraint using try/catch");
            Console.WriteLine("3. INSERT ... WHERE NOT EXISTS");
            Console.WriteLine("4. INSERT IGNORE (for unique constraint) using raw sql");
            Console.Write("Enter the number of your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }

            Console.WriteLine("Invalid benchmark selected. Please restart the program and select a valid option.");
            return 0;
        }

        static int GetNumberOfRunsFromUser()
        {
            Console.Write("Enter the number of runs (default=5): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numberOfRuns))
            {
                if (numberOfRuns <= 0)
                {
                    Console.WriteLine("Invalid number of runs. Defaulting to 5.");
                    return 5;
                }
                return numberOfRuns;
            }

            return 5;
        }

        static void RunBenchmark(int benchmarkType, int numberOfRuns)
        {
            // start a timer
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numberOfRuns; i++)
            {
                Console.WriteLine($"Running benchmark {benchmarkType} ({i + 1}/{numberOfRuns})");
                switch (benchmarkType)
                {
                    case 1:
                        new CheckBeforeInsertBenchmark().RunBenchmark();
                        break;
                    case 2:
                        new IgnoreUniqueConstraintBenchmark().RunBenchmark();
                        break;
                    case 3:
                        new InsertWhereNotExistsBenchmark().RunBenchmark();
                        break;
                    case 4:
                        new InsertOrIgnoreBenchmark().RunBenchmark();
                        break;
                    default:
                        Console.WriteLine($"Unknown benchmark type: {benchmarkType}");
                        return;
                }
            }
            // stop timer and calculate elapsed time
            stopwatch.Stop();
            var elapsed = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Benchmark completed in {elapsed} ms (avg: {elapsed / numberOfRuns})");

            // count rows in test data vs database to make sure 100% is inserted
            ValidateBenchmarkResults(benchmarkType);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static void ValidateBenchmarkResults(int benchmarkType)
        {
            using (var context = new BenchmarkDbContext())
            {
                if (benchmarkType == 1 || benchmarkType == 3)
                {
                    var testDataCount = DataProvider.GetTestData().Count();
                    var metarCount = context.Metars.Count();
                    if (metarCount != testDataCount)
                    {
                        Console.WriteLine($"Error: {metarCount} rows inserted, but {testDataCount} expected");
                    }
                    else
                    {
                        Console.WriteLine($"Success: {metarCount} rows inserted");
                    }
                }

                if (benchmarkType == 2 || benchmarkType == 4)
                {
                    var testDataWithUniqueConstraintCount = DataProvider.GetTestMetarWithUniqueConstraint().Count();
                    var metarWithUniqueConstraintCount = context.MetarsWithUniqueConstraint.Count();

                    if (metarWithUniqueConstraintCount != testDataWithUniqueConstraintCount)
                    {
                        Console.WriteLine($"Error: {metarWithUniqueConstraintCount} rows inserted, but {testDataWithUniqueConstraintCount} expected");
                    }
                    else
                    {
                        Console.WriteLine($"Success: {metarWithUniqueConstraintCount} rows inserted");
                    }
                }
            }
        }
    }
}