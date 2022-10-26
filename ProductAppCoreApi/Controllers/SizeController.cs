using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity.Model;
using System;

namespace ProductAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private SizeServices _sizeService;
        public SizeController(SizeServices sizeServices)
        {
            _sizeService = sizeServices;
        }

        [HttpGet("GetSize")]
        public Size GetSize(Guid Id)
        {
            return _sizeService.GetSize(Id);
        }

        [HttpPost("AddSize")]
        public IActionResult AddSize([FromBody] Size size)
        {
            _sizeService.AddSize(size);
            return Ok("Size created successfully!!");
        }
    }
}
