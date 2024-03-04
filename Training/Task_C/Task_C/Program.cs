using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
   
    class Program
    {
        private static string S_Name;
        private static int S_Id;
        private static int S_Add;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name..? ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Biggest Integer is : " + int.MaxValue);
            //Parse to string..
            /*int a = int.Parse("Shantanu");
            string l = a.ToString();
            Console.WriteLine(l.GetType());*/
            Console.WriteLine("________");
            //Object used to store various data types in zn array..
            object[] arr = new object[3] { "Hello", 2, 4.13 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
    
}

