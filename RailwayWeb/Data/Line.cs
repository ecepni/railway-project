using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Line")]
    public class Line
    {
        [Key]
        public int LineID { get; set; }

        public int? OperatingCompanyID { get; set; }

        public int? StartFacilityID { get; set; }

        public int? EndFacilityID { get; set; }
    }
}