using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity.Model;
using System;
using System.Collections.Generic;

namespace ProductAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductServices _productService;
        public ProductController(ProductServices productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProduct")]
        public Product GetProduct(Guid Id)
        {
            return _productService.GetProduct(Id);
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok("Product created successfully!!");
        }
    }
}
