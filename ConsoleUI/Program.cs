using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //CategoryTest();
            Console.ReadKey();
        }

        private static void CategoryTest()
        {
            CategoriManager categoryManager = new CategoriManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);

            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
             if(result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("ürün adı : " + product.CategoryName);
                }
            }
             else
            {
                Console.WriteLine(result.Message);
            }
         
        }
    }
}
