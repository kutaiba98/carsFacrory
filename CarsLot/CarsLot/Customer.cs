using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLot
{
    internal class Customer
    {
        //declare Variables
        private string name;
        private string number;
        private string email;
        private string address;


        //getter and setter method
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Number
        {
            get{ return number; }
            set{ number = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value;}
        }
        //default constructor
        public Customer()
        {
        }
   

        //method to get customer details
        public void CollectCustomerDetails()
        {
            Console.WriteLine("\nEnter Customer Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("\nEnter Customer Number: ");
            Number = Console.ReadLine();
            Console.WriteLine("\nEnter Customer Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("\nEnter Customer Address: ");
            Address = Console.ReadLine();
        }


        public override string ToString()
        {
            return $@" Name         : {Name}
 Number       : {Number}
 Email        : {Email}
 Address      : { Address}";
        }
    }
}
