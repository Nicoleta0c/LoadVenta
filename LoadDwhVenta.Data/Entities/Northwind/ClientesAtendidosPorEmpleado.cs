
namespace LoadDwhVenta.Data.Entities.Northwind;

public partial class ClientesAtendidosPorEmpleado
{
    public int EmployeeId { get; set; }

    public string? NombreEmpleado { get; set; }

    public int? ClientesAtendidos { get; set; }
}