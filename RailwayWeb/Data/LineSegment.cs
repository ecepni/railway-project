using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Line_Segment")]
    public class LineSegment
    {
        [Key]
        public int SegmentID { get; set; }

        public string? Location { get; set; }

        public string? Type { get; set; }

        public int? Electrified { get; set; }

        public double? Max_Weight { get; set; }

        public int? SpeedLimit { get; set; }

        public int? Length { get; set; }

        public int? LineID { get; set; }
    }
}