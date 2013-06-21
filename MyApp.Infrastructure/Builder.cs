using MyApp.PresentationLogic.Contract.Presenter;
using MyApp.PresentationLogic.Presenter;
using MyApp.Service;
using MyApp.Service.Contract;

namespace MyApp.Infrastructure
{
    public static class Builder
    {
         public static void Init()
         {
             InitService();
             InitPresenters();
         }

        private static void InitService()
        {
            ServiceLocator.Register<IProductService, ProductService>();
        }

        private static void InitPresenters()
        {
            ServiceLocator.Register<IProductListPresenter, ProductListPresenter>();
        }
    }
}