using BenchmarkBulkInsert.Db;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Benchmarks
{
    class IgnoreUniqueConstraintBenchmark
    {
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                foreach (var metar in DataProvider.GetTestMetarWithUniqueConstraint())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.Entry(metar).State = EntityState.Detached;
                            db.MetarsWithUniqueConstraint.Add(metar);
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        catch (DbUpdateException ex) when (IsUniqueConstraintViolation(ex))
                        {
                            // Ignore unique constraint violation
                            db.Remove(metar);
                            transaction.Rollback();
                        }
                    }
                }
            }
        }

        private bool IsUniqueConstraintViolation(DbUpdateException ex)
        {
            if (ex.InnerException is SqliteException sqliteEx)
            {
                return sqliteEx.SqliteErrorCode == 19 && sqliteEx.SqliteExtendedErrorCode == 2067;
            }
            return false;
        }
    }
}
