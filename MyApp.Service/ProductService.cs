using System.Collections.Generic;
using MyApp.Service.Contract;
using MyApp.ViewModel;
using MyApp.ViewModel.Response;

namespace MyApp.Service
{
    public class ProductService : IProductService
    {
        public GetDefaultProductListResponse CreateDefaultList()
        {
            var result = new GetDefaultProductListResponse();

            var products = new List<ProductVM>
                {
                    new ProductVM {Id = 1, Name = "Foo"},
                    new ProductVM {Id = 2, Name = "Bar"}
                };

            result.Products = products;
            return result;
        }
    }
}