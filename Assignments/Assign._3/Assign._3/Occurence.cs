using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._3
{
    class Occurence
    {
        static String str;
        static void occ()
        {
            int count = 0;
            Console.WriteLine("Enter Any Word:- ");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter any Char you want to count in this Word:- ");
            char c = Convert.ToChar(Console.ReadLine());
            for (int i =0; i<str.Length; i++)
            {
                if(str[i]==c)
                {
                    count++;
                }
            }
            Console.WriteLine("The Occurence of '" + c + "' is " + ":-" + count);
        }
        static void Main(String [] args)
        {
            occ();
            Console.ReadLine();
        }
    }
}
