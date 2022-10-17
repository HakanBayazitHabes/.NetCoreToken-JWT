using AuthServer.Core.DTOs;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IServiceGeneric<Product, ProductDto> _productService;

        public ProductsController(IServiceGeneric<Product, ProductDto> productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return View(products.Data.ToList());
        }
    }
}
