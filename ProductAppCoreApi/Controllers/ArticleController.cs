using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity.Model;
using System;

namespace ProductAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private ArticleServices _articleService;
        public ArticleController(ArticleServices articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("GetArticle")]
        public Article GetArticle(Guid Id)
        {
            return _articleService.GetArticle(Id);
        }

        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article article)
        {
            _articleService.AddArticle(article);
            return Ok("Article created successfully!!");
        }
    }
}
