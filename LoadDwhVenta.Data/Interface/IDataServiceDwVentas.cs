using LoadDwhVenta.Data.Core;


namespace LoadDWVentas.Data.Interfaces
{
    public interface IDataServiceDwVentas
    {
        Task<OperactionResult> LoadDHW();
    }
}