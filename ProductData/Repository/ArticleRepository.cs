using ProductData.Data;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class ArticleRepository:IArticleRepository
    {
        ProductDbContext _articleDbcontext;
        public ArticleRepository(ProductDbContext articleDbcontext)
        {
            _articleDbcontext = articleDbcontext;
        }

        public void AddArticle(Article article)
        {
            Guid aid = Guid.NewGuid();
            article.Id = aid;
            _articleDbcontext.article.Add(article);
            _articleDbcontext.SaveChanges();
        }              

        public Article GetArticle(Guid Id)
        {
            return _articleDbcontext.article.Find(Id);
        }
    }
}
