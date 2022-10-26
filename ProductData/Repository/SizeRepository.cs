using ProductData.Data;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class SizeRepository : ISizeRepository
    {
        ProductDbContext _sizeDbcontext;
        public SizeRepository(ProductDbContext sizeDbcontext)
        {
            _sizeDbcontext = sizeDbcontext;
        }
        public void AddSize(Size size)
        {
            _sizeDbcontext.size.Add(size);
            _sizeDbcontext.SaveChanges();
        }          

        public Size GetSize(Guid Id)
        {
            return _sizeDbcontext.size.Find();
        }
    }
}
