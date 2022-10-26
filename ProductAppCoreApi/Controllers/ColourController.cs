using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity.Model;
using System;

namespace ProductAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColourController : ControllerBase
    {
        private ColourServices _colourService;
        public ColourController(ColourServices colourService)
        {
            _colourService = colourService;
        }

        [HttpGet("GetColour")]
        public Colour GetColour(Guid Id)
        {
            return _colourService.GetColour(Id);
        }

        [HttpPost("AddColour")]
        public IActionResult AddColour([FromBody] Colour colour)
        {
            _colourService.AddColour(colour);
            return Ok("Colour created successfully!!");
        }
    }
}
