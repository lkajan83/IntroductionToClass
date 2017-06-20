using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToClass
{
    /*
     * Introduction to Classes
     * What is classs
     * Purpose of a class constructor
     * Overloading class constractor
     * understanding this keyword
     * Destructors
     * 
     * Class Mean :  A Classconsisst of data and ehavior.Class Data is represented by its fields and behavor is represented by its methods
     */
    //Class
    class Customer
    {
        string _firstName;
        string _lastName;

        public Customer() : this("No First Provided", "No LastName Provided")
        {
        }

        //Constractor
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        //Method
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
        }

        //~Customer()
        //{
        //    //Clean Up Code
        //}
    }

    class Program
    {
        public static void Main()
        { 
            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("P","T");
            C2.PrintFullName();     
        }
    }
}
