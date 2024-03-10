using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    class Number_Square
    {
        static List<int> Num = new List<int>();
        public static void Get_Data()
        {
            Console.Write("Enter the size of the List:- ");
            int len = int.Parse(Console.ReadLine());

            for (int i = 0; i < len; i++)
            {
                int val;
                Console.Write($"\nEnter your {i+1} Number:-");
                val = Convert.ToInt32(Console.ReadLine());
                Num.Add(val);
            }
        }
        public static void Display_Data()
        {
            var sqr = Num.Select(sr => sr * sr);

            Console.WriteLine("Square of the numbers:- ");
            foreach (var ans in sqr)
            {
                if (ans > 20)
                {
                    Console.Write(ans + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Get_Data();
            Display_Data();
            Console.ReadLine();
        }

    }
}

