using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_2
{
    class Customer
    {
        //Customerid, Name, Age, Phone,City
        public static int Customerid;
        public static string Name;
        public static int Age;
        public static string Phone;
        public static string City;
        Customer()
        {
            //Console.WriteLine("\t\t\t\t\t\t-:Customer Details:-");
        }
        Customer(int customerid,string name, int age,string phone,string city)
        {
            Customerid = customerid;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;

        }
        static void Display_Customer()
        {
            Console.WriteLine("Customer Id:- " + Customerid);
            Console.WriteLine("Name:- " + Name);
            Console.WriteLine("Age:- " + Age);
            Console.WriteLine("Phone:- " + Phone);
            Console.WriteLine("City:- " + City);

        }
        ~Customer()
        {
            Console.WriteLine("Object Destroyed");
        }
        public static void instance()
        {
            Customer cm = new Customer();
        }

        static void Main(String [] args)
        {
            Console.WriteLine("Fill all details:-");
            Console.WriteLine("Enter Customer id:- ");
            int cd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:- ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Age:- ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone:- ");
            string phone = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter City:- ");
            string city = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Customer ct = new Customer();
            Customer cl = new Customer(cd,name,age,phone,city);
            Console.WriteLine("\t\t\t\t\t\t-:Customer Details:-");
            Display_Customer();
            Console.WriteLine("\n");
            instance();
            GC.Collect();
            Console.ReadLine();


        }
    }
}
