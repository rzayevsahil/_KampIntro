using System;

namespace Classes_odev_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Engin";//set bloğu çalışır - set etmek yani değer vermek
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);//get bloğu çealışır


            Console.ReadLine();
        }
    }


   

    
}
