
using LoadDwhVenta.Data.Entities.DwVentas;
using Microsoft.EntityFrameworkCore;


namespace LoadDwhVenta.Data.Contexts.DwVentas
{
    public partial class DwhVentasContext : DbContext
    {

        public DwhVentasContext(DbContextOptions<DwhVentasContext> options): base(options)
        {
        }

        public DbSet<DimCategory> DimCategories { get; set; }

        public DbSet<DimCustomer> DimCustomers { get; set; }


        public DbSet<DimEmployee> DimEmployees { get; set; }

        public DbSet<DimProduct> DimProducts { get; set; }

        public DbSet<DimShipper> DimShippers { get; set; }

        public DbSet<FactClientesAtendido> FactClientesAtendidos { get; set; }

        public DbSet<FactOrder> FactOrders { get; set; }



        

    }
}
