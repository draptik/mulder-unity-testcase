using MyApp.PresentationLogic.Contract.Presenter;
using MyApp.PresentationLogic.Contract.View;
using MyApp.Service.Contract;
using MyApp.ViewModel.Response;

namespace MyApp.PresentationLogic.Presenter
{
    public class ProductListPresenter : IProductListPresenter
    {
        private readonly IProductService service;
        private readonly IProductListView view;

        public ProductListPresenter(IProductListView view, IProductService service)
        {
            this.service = service;
            this.view = view;
            this.view.CreateDefaultProductList += view_CreateDefaultProductList;
        }

        private void view_CreateDefaultProductList()
        {
            GetDefaultProductListResponse response = service.CreateDefaultList();
            if (response.Success) {
                view.Products = response.Products;
            }
        }
    }
}