using Mall_UIComponents.Models;
using Mall_UIComponents.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mall_UIComponents.Controllers
{
    public class ProductsController : Controller
    {
        ProductServices Services = new ProductServices();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllProducts()
        {
            var result = Services.GetAllProducts();
            return View(result);
        }

        [HttpPost("PostProducts")]
        public IActionResult PostProducts(int CategoryId, Products products)
        {
            Services.PostProducts(CategoryId, products);
            return View();
        }
    }
}
