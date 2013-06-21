using System;
using System.Collections.Generic;
using System.Web.UI;
using MyApp.PresentationLogic.Contract.View;
using MyApp.ViewModel;

namespace MyApp.Web
{
    public partial class ProductList : UserControl, IProductListView
    {
        public IEnumerable<ProductVM> Products
        {
            set
            {
                Rpt_ProductList.DataSource = value;
                Rpt_ProductList.DataBind();
            }
        }

        public event Action CreateDefaultProductList;

        protected void Page_Load(object sender, EventArgs e)
        {
            CreateDefaultProductList();
        }
    }
}