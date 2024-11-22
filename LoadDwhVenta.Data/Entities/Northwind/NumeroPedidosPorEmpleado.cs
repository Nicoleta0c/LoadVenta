

namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class NumeroPedidosPorEmpleado
{
    public int EmployeeId { get; set; }

    public string? NombreEmpleado { get; set; }

    public int? NumeroPedidos { get; set; }
}