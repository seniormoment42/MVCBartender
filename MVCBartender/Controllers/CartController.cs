using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCBartender.Infrastructure;
using MVCBartender.Models;
using MVCBartender.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCBartender.Controllers
{
    public class CartController : Controller
    {
        private IProductReporitory reporitory;

        public CartController(IProductReporitory repo)
        {
            reporitory = repo;
        } // end CartController constructor

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart (int productId, string returnUrl)
        {
            Product product = reporitory.Products
                .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        } // end AddToCart method

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = reporitory.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        } // end RemoveFromCart method

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        } // end GetCart method

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        } // end SaveCart method

    } // end CartController : Controller class
} // end MVCBartender.Controllers namespace
