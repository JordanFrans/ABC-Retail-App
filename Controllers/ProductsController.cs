using ABCRetailApp.Models;
using Microsoft.AspNetCore.Mvc;
using Supabase;

namespace ABCRetailApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Client _supabase;

        public ProductsController(Client supabase)
        {
            _supabase = supabase;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _supabase
                .From<Product>()
                .Get();

            var products = response.Models;

            return View(products);
        }
    }
}