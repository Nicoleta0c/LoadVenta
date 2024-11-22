

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class ViewProducto
{
    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public short? Inventario { get; set; }

    public decimal? PreciVenta { get; set; }

    public decimal? Costo { get; set; }
}