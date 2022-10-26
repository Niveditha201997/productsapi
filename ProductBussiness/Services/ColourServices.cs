using ProductData.Repository;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProductBussiness.Services
{
    public class ColourServices
    {
        IColourRepository _colourRepository;
        public ColourServices(IColourRepository colourRepository)
        {
            _colourRepository = colourRepository;
        }
        public void AddColour(Colour colour)
        {
            _colourRepository.AddColour(colour);
        }
        public Colour GetColour(Guid Id)
        {
            return _colourRepository.GetColour(Id);
        }
    }
}
