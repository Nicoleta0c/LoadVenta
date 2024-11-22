

using System.ComponentModel.DataAnnotations;

namespace LoadDwhVenta.Data.Entities.DwVentas;

public partial class DimShipper
{
    [Key]
    public int? ShipperKey { get; set; }

    public string? ShipperName { get; set; }

    public int? ShipperId { get; set; }


}