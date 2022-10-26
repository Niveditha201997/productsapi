using ProductData.Repository;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBussiness.Services
{
    public class ArticleServices
    {
        IArticleRepository _articleRepository;
        public ArticleServices(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public void AddArticle(Article article)
        {
            _articleRepository.AddArticle(article);
        }
        public Article GetArticle(Guid Id)
        {
            return _articleRepository.GetArticle(Id);
        }
    }
}
