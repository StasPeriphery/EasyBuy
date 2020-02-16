using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EasyBuyShop.Models;
using EasyBuyShop.Interface;
using System.Diagnostics;
namespace EasyBuyShop.Controllers
{
    public class HomeController : Controller
    {
        private IProduct _product;

        public HomeController(IProduct product)
        {
            _product = product;
        }
        public IActionResult Index()
        {

            IEnumerable<Product> product = _product.AllProducts;
            foreach (var item in product)
            {
                Debug.Write(item.description);
                Debug.Write(item.heading);
                Debug.Write(item.id);
                Debug.Write(item.nameProduct);
                Debug.Write(item.price);
                Debug.Write(item.url);

            }
            return View(product);
        }


        public IActionResult SignIn()
        {
            return View("SignIn");
        }



    }
}