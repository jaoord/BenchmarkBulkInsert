using BenchmarkBulkInsert.Db;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Benchmarks
{
    class TemporaryTableBenchmark
    {
        // using a temporary table to insert data, only inserting data that doesn't already exist in the target table
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                // remove all rows from TmpMetars
                db.Database.ExecuteSqlRaw("DELETE FROM TmpMetars");

                // bulk insert everything from GetTestData() into TmpMetars
                db.TmpMetars.AddRange(DataProvider.GetTestTmpMetar());
                db.SaveChanges();

                // insert everything from tmpmetars into metars that doesn't already exist
                db.Database.ExecuteSqlRaw(@"
                    INSERT INTO Metars (Station, RawData, LastChange)
                    SELECT t.Station, t.RawData, t.LastChange
                    FROM TmpMetars t
                    WHERE NOT EXISTS (
                        SELECT 1 FROM Metars WHERE Station = t.Station AND LastChange = t.LastChange
                    )");
            }
        }
    }
}
