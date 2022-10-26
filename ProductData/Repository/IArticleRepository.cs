using System;
using System.Collections.Generic;
using System.Text;
using ProductEntity;
using ProductEntity.Model;

namespace ProductData.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        Article GetArticle(Guid Id);
    }
}
