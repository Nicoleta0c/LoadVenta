
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadDwhVenta.Data.Entities.DwVentas
{
    [Table("DimCustomers")]
    public partial class DimCustomer
    {
        [Key]
        public int CustomerKey { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerId { get; set; }

    }
}