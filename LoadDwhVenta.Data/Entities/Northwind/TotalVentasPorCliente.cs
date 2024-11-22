

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class TotalVentasPorCliente
{
    public string? CustomerId { get; set; }

    public string? Cliente { get; set; }

    public decimal? TotalVentas { get; set; }
}