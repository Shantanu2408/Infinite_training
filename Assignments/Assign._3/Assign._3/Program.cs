using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._3
{
    class Program
    {
        static String First_Name, Last_Name;

        static void Display()
        {
            Console.WriteLine("Enter First Name:- ");
            First_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Last Name:- ");
            Last_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("----Name----:-\n");
            Console.WriteLine("First Name:- " + First_Name.ToUpper());
            Console.WriteLine("Last Name:- " + Last_Name.ToUpper());
        }
        static void Main(string[] args)
        {
            Display();
            Console.ReadLine();
        }
    }
}
