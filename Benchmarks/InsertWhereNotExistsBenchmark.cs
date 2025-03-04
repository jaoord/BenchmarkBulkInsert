using BenchmarkBulkInsert.Db;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Benchmarks
{
    class InsertWhereNotExistsBenchmark
    {
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                foreach (var metar in DataProvider.GetTestMetar())
                {
                    var sql = @"
                        INSERT INTO Metars (Station, RawData, LastChange)
                        SELECT @Station, @RawData, @LastChange
                        WHERE NOT EXISTS (
                            SELECT 1 FROM Metars WHERE Station = @Station AND LastChange = @LastChange
                        )";

                    db.Database.ExecuteSqlRaw(sql,
                        new SqliteParameter("@Station", metar.Station),
                        new SqliteParameter("@RawData", metar.RawData),
                        new SqliteParameter("@LastChange", metar.LastChange));
                }
            }
        }
    }
}
