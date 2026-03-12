using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Facility")]
    public class Facility
    {
        [Key]
        public int FacilityID { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public int? Capacity { get; set; }

        public int? Electrified { get; set; }

        public int? FacilityTypeID { get; set; }

        public int? OperatingCompanyID { get; set; }
    }
}