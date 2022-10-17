using AuthServer.Core.DTOs;
using AuthServer.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIAuthServer.API.Controllers
{
    public class ProductNoAPI : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductNoAPI(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Save()
        {
            var products = await _productService.GetAllAsync();
            var productDto = _mapper.Map<List<ProductDto>>(products.Data.ToList());
            return View(productDto);
        }
    }
}
