using BenchmarkBulkInsert.Db;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Benchmarks
{
    class InsertOrIgnoreBenchmark
    {
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                foreach (var metar in DataProvider.GetTestMetarWithUniqueConstraint())
                {
                    var sql = @"
                            INSERT OR IGNORE INTO MetarsWithUniqueConstraint (Station, RawData, LastChange)
                            VALUES (@Station, @RawData, @LastChange)";

                    db.Database.ExecuteSqlRaw(sql,
                        new SqliteParameter("@Station", metar.Station),
                        new SqliteParameter("@RawData", metar.RawData),
                        new SqliteParameter("@LastChange", metar.LastChange));
                }
            }
        }
    }
}
