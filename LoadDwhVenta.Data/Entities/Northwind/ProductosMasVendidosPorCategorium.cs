

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class ProductosMasVendidosPorCategorium
{
    public string? Categoria { get; set; }

    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? CantidadVendida { get; set; }
}