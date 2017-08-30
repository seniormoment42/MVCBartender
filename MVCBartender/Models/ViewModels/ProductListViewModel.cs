using System.Collections.Generic;
using MVCBartender.Models;

namespace MVCBartender.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
