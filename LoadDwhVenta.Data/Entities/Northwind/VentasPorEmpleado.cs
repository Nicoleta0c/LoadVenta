
namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class VentasPorEmpleado
{
    public int EmployeeId { get; set; }

    public string? NombreEmpleado { get; set; }

    public decimal? VentasTotales { get; set; }
}