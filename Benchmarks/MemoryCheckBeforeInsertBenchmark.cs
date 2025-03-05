using BenchmarkBulkInsert.Db;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Benchmarks
{
    class MemoryCheckBeforeInsertBenchmark
    {
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                // Cache the latest records for each station based on the highest LastChange
                var existingRecords = db.Metars
                    .AsNoTracking()
                    .GroupBy(m => m.Station)
                    .Select(g => g.OrderByDescending(m => m.LastChange).First())
                    .ToDictionary(m => new { m.Station, m.LastChange });

                var newRecords = new List<Metar>();

                int i = 0;
                foreach (var metar in DataProvider.GetTestMetar())
                {
                    if (!existingRecords.ContainsKey(new { metar.Station, metar.LastChange }))
                    {
                        newRecords.Add(metar);
                        i++;
                    }

                    // batch save 
                    if (i % 1000 == 0)
                    {
                        db.Metars.AddRange(newRecords);
                        db.SaveChanges();
                        newRecords.Clear();
                    }
                }

                // any remaining records
                if (newRecords.Any())
                {
                    db.Metars.AddRange(newRecords);
                    db.SaveChanges();
                }

            }
        }
    }
}
