

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class VentasTotalesPorPeriodo
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public decimal? VentasTotales { get; set; }
}