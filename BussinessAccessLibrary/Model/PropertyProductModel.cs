using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessAccessLibrary.Model
{
    public class PropertyProductModel
    {
        public string Id { get; set; }
        public string Form { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        [JsonIgnore]
        public ProductModel ProductModel { get; set; }
    }
}
