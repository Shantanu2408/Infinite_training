using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Word_Return
    {
        static List<string> words = new List<string>();
        public static void Get_Data()
        {
            Console.Write("Enter the size of the List:- ");
            int len = int.Parse(Console.ReadLine());

            for (int i = 0; i < len; i++)
            {
                string val;
                Console.Write($"\nEnter your {i + 1} Number:-");
                val =Console.ReadLine();
                words.Add(val);
            }
        }
        static void Display_Data()
        {
            var Return_Value = words.Where(wp => wp.StartsWith("a") && wp.EndsWith("m"));
            foreach(var a in Return_Value)
            {
                Console.WriteLine(a+" ");
            }
        }
        static void Main(string [] args)
        {
            Get_Data();
            Display_Data();
            Console.ReadLine();
        }
    }
}
