using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5,//kırtasiye
                UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //PascalCase - her ikisi büyük harfle başlamalı  //camelCase - ikinci büyük harfle başlar
            //case sensitive 
            //ProductManager productManager - stack                    new ProductManager(); - heap
            ProductManager productManager = new ProductManager();


            
            



            Console.ReadLine();    
        }
    }
}
