using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ps = new Program();
            ps.Student_D();
            //Console.WriteLine();
            ps.wish();
            ps.print();
            Console.Read();



        }
        static string name;
        static int Id;
        static string dept;
        void Student_D()
        {
            Console.WriteLine("Enter the name of the Student:- ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Student Id no:- ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the department of the student:- ");
            dept = Convert.ToString(Console.ReadLine());
            
        }
        void wish()
        {
            Console.WriteLine("Hello " + name + ", here is all your details. You can check..");
            
        }
        void print()
        {
            Console.WriteLine("Name- "+name);
            Console.WriteLine("Student Id- "+Id);
            Console.WriteLine("Department- "+dept);
            
        }
    }
}
