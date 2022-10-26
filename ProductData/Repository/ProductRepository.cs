using ProductData.Data;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class ProductRepository:IProductRepository
    {
        ProductDbContext _productDbcontext;
        public ProductRepository(ProductDbContext productDbcontext)
        {
            _productDbcontext = productDbcontext;
        }

        public void AddProduct(Product product)
        {
            Guid pid = Guid.NewGuid();   
            product.ProductId = pid;
            _productDbcontext.product.Add(product);
            _productDbcontext.SaveChanges();
        }

        public Product GetProduct(Guid Id)
        {
            return _productDbcontext.product.Find(Id);
        }
    }
}
