using BussinessAccessLibrary.Model;
using DAL.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLibrary.ProductService
{
    public interface IProductService
    {
        List<ProductModel> GetAll();

    }
}
