using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenchmarkBulkInsert.Db
{
    class TmpMetar
    {
        public TmpMetar()
        {
            
        }

        public TmpMetar(Metar metar)
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

        public string LastChange { get; set; }
    }
}
