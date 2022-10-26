using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface IColourRepository
    {
        void AddColour(Colour colour);
        Colour GetColour(Guid Id);
    }
}
