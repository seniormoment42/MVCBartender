using Microsoft.AspNetCore.Mvc;
using MVCBartender.Models;

namespace MVCBartender.Controllers
{
    public class ProductController : Controller
    {
        private IProductReporitory reporitory;

        public ProductController(IProductReporitory repo)
        {
            reporitory = repo;
        } // end ProductController Constructor

        public ViewResult List() => View(reporitory.Products);
    } // end ProductController class
} // end MVCBartender.Controllers namespace
