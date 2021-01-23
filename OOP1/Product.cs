using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //entity-varlık
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//ürün fiyatı        
        public int UnitsInStock { get; set; }//ürünün stok adedi

        //kod okunurluğu güzel olsun diye primary key birinci foregn key ikinci olarak yazılır

        //CRUD-create read update delete


    }
}
