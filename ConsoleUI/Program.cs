﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

             foreach(var product in productManager.GetAll())
            {
                Console.WriteLine("ürün adı : "+product.ProductName);
            }

            
            Console.ReadKey();
        }
    }
}