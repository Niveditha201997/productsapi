using ProductData.Repository;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBussiness.Services
{
    public class SizeServices
    {
        ISizeRepository _sizeRepository;
        public SizeServices(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }
        public void AddSize(Size size)
        {
            _sizeRepository.AddSize(size);
        }
        public Size GetSize(Guid Id)
        {
            return _sizeRepository.GetSize(Id);
        }
    }
}
