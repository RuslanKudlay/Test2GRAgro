using AutoMapper;
using BussinessAccessLibrary.Model;
using DAL;
using DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAccessLibrary.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IApplicationDbContext _dbContext;
        private readonly Mapper _autoMapper;
        public ProductService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            var mappedTables = new MapperConfiguration(_ =>
            {
                _.CreateMap<Product, ProductModel>();
                _.CreateMap<ProductModel, Product>();
                _.CreateMap<PropertyProduct, PropertyProductModel>();
            });
            _autoMapper = new Mapper(mappedTables);
        }
        public List<ProductModel> GetAll()
        {
            var clock = new Stopwatch();
            clock.Start();
            var model = _dbContext.Products.Include(_ => _.PropertyProducts).ToList();
            List<ProductModel> productModels = new List<ProductModel>();
            foreach(var item in model)
            {
                
                List<PropertyProductModel> prodPM = new List<PropertyProductModel>();
                foreach (var temp2 in item.PropertyProducts)
                {
                    var link = new PropertyProductModel
                    {   Id = temp2.Id,
                        Color = temp2.Color,
                        Form = temp2.Form,
                        Weight = temp2.Weight,
                        Price = temp2.Price
                    };
                    prodPM.Add(link);
                }
                var temp = new ProductModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    PropertyProducts = prodPM
                };
                productModels.Add(temp);
            }
            clock.Stop();
            var ellapsedTime = clock.Elapsed.TotalMilliseconds; //117msec without index
                                                                //9msec with index


            return productModels;
        }
    }
}
