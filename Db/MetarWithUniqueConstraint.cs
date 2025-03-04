using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenchmarkBulkInsert.Db
{
    class MetarWithUniqueConstraint
    {
        public MetarWithUniqueConstraint()
        {

        }

        public MetarWithUniqueConstraint(IMetar metar)
        {
            this.Station = metar.Station;
            this.RawData = metar.RawData;
            this.LastChange = metar.LastChange;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Station { get; set; }

        public string RawData { get; set; }

        // keeping it as string for this test
        public string LastChange { get; set; }
    }
}
