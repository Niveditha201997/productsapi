using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Drawing;

namespace ProductEntity.Model
{   
    public class Article   
    {
        [Key]
        public Guid Id { get; set; }

        public string ArticleName { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Colour")]
        public Guid ColourId { get; set; }
        public Colour Colour { get; set; }

    }
}
