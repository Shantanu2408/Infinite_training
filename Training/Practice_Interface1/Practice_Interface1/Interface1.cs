using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface1
{
    interface Interface1
    {
        void b1(int a, int b);
    }
    interface interface2
    {
         void b1();
    }
    public class Run: Interface1,interface2
    {
        public void b1(int a, int b)
        {
            Console.WriteLine(a + b);
        }
         void interface2.b1()
        {
            Console.WriteLine("Hello");
        }
        public static void Main(string [] args)
        {
            Run r1 = new Run();
            r1.b1(4, 5);
            interface2 i1 =r1;
            i1.b1();
            Console.ReadLine();
        }
    }
}
