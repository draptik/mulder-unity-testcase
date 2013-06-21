using MyApp.ViewModel.Response;

namespace MyApp.Service.Contract
{
    public interface IProductService
    {
        GetDefaultProductListResponse CreateDefaultList();
    }
}