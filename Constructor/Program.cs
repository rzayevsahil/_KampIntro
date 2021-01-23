using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer(2,"Sahil","Rzayev","Baku");
            Customer customer2 = new Customer { Id = 1, FirstName = "Engin", LastName = " Demirog", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Console.WriteLine(customer1.FirstName);


            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer()
        {
                
        }
       
        //default constructor
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
