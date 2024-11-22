

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoadDwhVenta.Data.Entities.DwVentas
{
    [Table("DimCategories")]
    public partial class DimCategory
    {
        [Key]
        public int CategoryKey { get; set; }

        public string? CategoryName { get; set; }

        public int CategoryId { get; set; }
    }
}