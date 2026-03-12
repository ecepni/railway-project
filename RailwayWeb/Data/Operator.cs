using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwayWeb.Data
{
    [Table("Operator")]
    public class Operator
    {
        [Key]
        public int OperatorID { get; set; }

        public string? Name { get; set; }

        public int? WorkingCompanyID { get; set; }
    }
}