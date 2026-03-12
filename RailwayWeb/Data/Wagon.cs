using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Wagon")]
    public class Wagon
    {
        [Key]
        public int WagonID { get; set; }

        public int? Payload { get; set; }

        public int? Volume { get; set; }

        public string? Dimensions { get; set; }

        public int? Tare { get; set; }

        public int? Weight { get; set; }

        public int? WagonTypeID { get; set; }

        public int? OperatorID { get; set; }
    }
}