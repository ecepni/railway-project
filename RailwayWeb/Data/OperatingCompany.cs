using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Operating_Company")]
    public class OperatingCompany
    {
        [Key]
        public int OperatingCompanyID { get; set; }

        public string? Name { get; set; }
    }
}