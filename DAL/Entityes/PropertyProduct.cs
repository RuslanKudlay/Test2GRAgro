using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entityes
{
    public class PropertyProduct
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Form { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
    }
}
