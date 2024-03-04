using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GreaterThan
    {
        public int Value { get; set; }

        public static bool operator >(GreaterThan t1, GreaterThan t2)
        {
            return t1.Value > t2.Value;
        }
        public static bool operator <(GreaterThan t1, GreaterThan t2)
        {
            return t1.Value < t2.Value;
        }


        // Increment operator....
        public static GreaterThan operator ++(GreaterThan t1)
        {
            GreaterThan temp = new GreaterThan();
            temp.Value = t1.Value + 1;
            return temp;
        }

    }
    class OperatorOverloading
    {
        public static void Main()
        {
            //GreaterThan g1 = new GreaterThan { Value = 10 };
            //GreaterThan g2 = new GreaterThan { Value = 20 };
            //if (g1 > g2)
            //    Console.WriteLine("g1 is greater then g2");
            //else if (g1 < g2)
            //    Console.WriteLine("g1 is less then g2");
            //else
            //    Console.WriteLine("g1 and g2 is equal");


            GreaterThan g1 = new GreaterThan { Value = 10 };            //?
            g1.Value = g1.Value + 1;
            Console.WriteLine(g1.Value);
            Console.Read();
        }

    }
}