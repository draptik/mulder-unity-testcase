using System.Collections.Generic;

namespace MyApp.ViewModel.Response
{
    public class GetDefaultProductListResponse : DefaultResponse
    {
        public IEnumerable<ProductVM> Products { get; set; }
    }
}