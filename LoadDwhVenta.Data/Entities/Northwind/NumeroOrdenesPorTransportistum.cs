

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class NumeroOrdenesPorTransportistum
{
    public int ShipperId { get; set; }

    public string? Transportista { get; set; }

    public int? NumeroOrdenes { get; set; }
}