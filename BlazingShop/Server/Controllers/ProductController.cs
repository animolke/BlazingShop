using BlazingShop.Server.Services.ProductService;
using BlazingShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            return Ok(await _productService.GetProducts());
        }

        [HttpGet("Category/{CategoryUri}")]
        public async Task<ActionResult<Product>> GetProductsByCategory(string CategoryUri)
        {
            return Ok(await _productService.GetProductsByCategory(CategoryUri));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Product>> GetProductById(int id) 
        {
            return Ok(await _productService.GetProductById(id));
        }
    }
}
