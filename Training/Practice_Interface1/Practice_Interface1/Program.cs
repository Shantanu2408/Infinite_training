using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface1
{
    public interface it1
    {
        
        void add(int a, int b);
    }
    public interface it2: it1
    {
        void sub(int a, int b);
    }
    class Program :it2
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.add(23, 2);
            p.sub(90, 67);
            Console.ReadLine();
        }
    }
}
