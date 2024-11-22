
using System.ComponentModel.DataAnnotations;

namespace LoadDwhVenta.Data.Entities.DwVentas;

public partial class FactClientesAtendido
{
    [Key]
    public int? ClienteAtendidoKey { get; set; }

    public int? EmployeeKey { get; set; }

    public int? TotalClientes { get; set; }


}