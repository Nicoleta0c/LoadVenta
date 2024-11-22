
namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class TotalVentasPorTransportistum
{
    public int ShipperId { get; set; }

    public string? Transportista { get; set; }

    public decimal? TotalVentas { get; set; }
}