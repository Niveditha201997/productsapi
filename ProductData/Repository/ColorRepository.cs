using ProductData.Data;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductData.Repository
{
    public class ColorRepository : IColourRepository
    {
        ProductDbContext _colourDbcontext;
        public ColorRepository(ProductDbContext colourDbcontext)
        {
            _colourDbcontext = colourDbcontext;
        }
        public void AddColour(Colour colour)
        {
            Guid Cid = Guid.NewGuid();
            colour.Id = Cid;    
            _colourDbcontext.colour.Add(colour);
            _colourDbcontext.SaveChanges();
        }       

        public Colour GetColour(Guid Id)
        {
            return _colourDbcontext.colour.Find(Id);
        }
    }
}
