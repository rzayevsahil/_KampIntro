using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_odev_
{
    class Customer
    {
        //field - public string FirstName;
        //Property
        public int Id { get; set; }

        /*private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }

        }*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
