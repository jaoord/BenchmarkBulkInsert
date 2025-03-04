namespace BenchmarkBulkInsert
{
    interface IMetar
    {
        string Station { get; set; }
        string RawData { get; set; }
        string LastChange { get; set; }
    }
}
