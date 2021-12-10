using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLibrary.Model
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<PropertyProductModel> PropertyProducts { get; set; } = new List<PropertyProductModel>();
    }
}
