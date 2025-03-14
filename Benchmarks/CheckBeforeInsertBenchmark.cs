﻿using BenchmarkBulkInsert.Db;

namespace BenchmarkBulkInsert.Benchmarks
{
    class CheckBeforeInsertBenchmark
    {
        public void RunBenchmark()
        {
            using (var db = new BenchmarkDbContext())
            {
                foreach (var metar in DataProvider.GetTestMetar())
                {
                    if (db.Metars.Any(m => m.Station == metar.Station && m.LastChange == metar.LastChange))
                    {
                        continue;
                    }
                    db.Metars.Add(metar);
                }
                db.SaveChanges();
            }
        }
    }
}
