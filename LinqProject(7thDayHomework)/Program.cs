using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject_7thDayHomework_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="316 GB Ram", UnitPrice=8000, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitInStock=0},

            };
            //Test(products);

            //GetProducts(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //DifferentSpelling(products);

            //ClassikLinqTest(products);

            //Join - birleştirmek, equal - eşit
            var result = from p in products join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         orderby p.UnitPrice
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                //{0} yerine productDto.ProductName,  {1} yerine productDto.CategoryName
                Console.WriteLine("{0} ---> {1}",productDto.ProductName,productDto.CategoryName);
            }

            Console.ReadLine();
        }

        private static void ClassikLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void DifferentSpelling(List<Product> products)
        {
            //Bu da farklı bir yazım şekli...products tan  her p takma isimli - kısaca bunun gibi ==> var result = products.FindAll(p => p.ProductName);
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(result);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single Line Query - Tek Satırlı Sorgu

            //içindeki top olan ürünleri getirir...FindAll gibi aynı işlemi yapar
            //UnitPrice a göre yüksekten aşağıya doğru sıralar 
            //ThenBy ile de a dan z ye sıralar
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            //şarta uyan bütün elemanları getirir
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
            //çıktı:  System.Collections.Generic.List`1[LinqProject_7thDayHomework_.Product]
            //direk olarak liste dönüyor
        }
        //************************************************************************************

        private static void FindTest(List<Product> products)
        {
            //aradığımız kritere uygun nesnenin kendisini veriyor
            //ürün detayına gitmek için kullanılır
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result);  // çıktı:  LinqProject_7thDayHomework_.Product
            Console.WriteLine(result.ProductName);// çıktı:  Hp Laptop
        }
        //************************************************************************************

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result); //true
        }
        //************************************************************************************
        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq------------------------");
            //List<Product> result bunu da dersek hata vermez
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //************************************************************************************

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        //******************************* Linq ****************************
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
            //sonuçta yep yeni bir liste oluşturup şarta uyanları oraya ekliyor
        }

}
    class ProductDto //dto - data transformation object
    {
        public int ProductId { get; set; }
        public string  CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }



    class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; } //birim başına miktar
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
