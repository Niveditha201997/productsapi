using ProductData.Data;
using ProductData.Repository;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBussiness.Services
{
    public class ProductServices
    {
        IProductRepository _productRepository;      

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            Random rnd = new Random();
            var Count2 = 100000000;
            switch (product.ChannelId)
            {
                case 1:

                    int num;
                    num = rnd.Next(0, 1000);
                    product.ProductCode = product.ProductYear.ToString() + num.ToString();
                    break;
                case 2:
                    int stringlen = rnd.Next(5, 10);
                    int randValue;
                    string str = "";
                    char letter;
                    for (int i = 0; i < 6; i++)
                    {
                        randValue = rnd.Next(0, 26);
                        letter = Convert.ToChar(randValue + 65);
                        str = randValue.ToString() + letter;
                    }
                    product.ProductCode = str;
                    break;
                case 3:
                    product.ProductCode = Count2.ToString();
                    Count2++;
                    break;
            }
        }
        public Product GetProduct(Guid Id)
        {
            return _productRepository.GetProduct(Id);
        }
    }
}
