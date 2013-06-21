using System;
using System.Collections.Generic;
using MyApp.ViewModel;

namespace MyApp.PresentationLogic.Contract.View
{
    public interface IProductListView
    {
        IEnumerable<ProductVM> Products { set; }
        event Action CreateDefaultProductList;
    }
}