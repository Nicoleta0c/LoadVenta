
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadDwhVenta.Data.Entities.DwVentas
{
    [Table("DimEmployees")]
    public partial class DimEmployee
    {
        [Key]
        public int EmployeeKey { get; set; }

        public string? EmployeeName { get; set; }

        public int EmployeeId { get; set; }

    }
}