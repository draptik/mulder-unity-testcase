using System;
using System.Web.UI;
using MyApp.Infrastructure;
using MyApp.PresentationLogic.Contract.Presenter;
using MyApp.PresentationLogic.Contract.View;

namespace MyApp.Web
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // create presenter
            var productListPresenter = ServiceLocator.RetrievePresenter<IProductListPresenter, IProductListView>(UcProductListView);
        }
    }
}