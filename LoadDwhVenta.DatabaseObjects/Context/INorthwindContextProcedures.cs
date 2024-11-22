

namespace LoadDwhVenta.DatabaseObjects.Context
{
    public partial interface INorthwindContextProcedures
    {
        Task<int> CleanDataAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> LoadCategoriesAsync(string CategoryName, OutputParameter<int>? returnValue = null, CancellationToken cancellationToken = default);
        Task<int> LoadCustomersAsync(string CustomerName, OutputParameter<int>? returnValue = null, CancellationToken cancellationToken = default);
        Task<int> LoadEmployeesAsync(string EmployeeName, OutputParameter<int>? returnValue = null, CancellationToken cancellationToken = default);
        Task<int> LoadProductsAsync(string ProductName, OutputParameter<int>? returnValue = null, CancellationToken cancellationToken = default);
        Task<int> LoadShippersAsync(string ShipperName, OutputParameter<int>? returnValue = null, CancellationToken cancellationToken = default);
    }
}
