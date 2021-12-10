using DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<PropertyProduct> PropertyProducts { get; set; }
        public int SaveChanges();
    }
}
