
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadDwhVenta.Data.Entities.DwVentas
{
    [Table("DimProducts")]
    public partial class DimProduct
    {
        [Key]
        public int ProductKey { get; set; }

        public string? ProductName { get; set; }

        public int ProductId { get; set; }

  
    }
}