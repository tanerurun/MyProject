using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context :DB TABLOLARI İLE PROJE CALSSLARINI BAĞLAMAK
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Customer> Musteriler { get; set; }
    }
}
