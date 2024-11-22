
namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class NumeroOrdenesPorCliente
{
    public string? CustomerId { get; set; }

    public string? Cliente { get; set; }

    public int? NumeroOrdenes { get; set; }
}