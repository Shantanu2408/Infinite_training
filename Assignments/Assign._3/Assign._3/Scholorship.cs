using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._3
{
    class Scholorship
    {
        //If the given mark is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
        //If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees  
        //If the given mark is >90, then calculate scholarship amount as 50% of the fees.
        static float Fees;
        static int Marks;
        static float sc;
        
        public static void Merit()
        {
            Console.WriteLine("Enter the Fees Amount:- ");
            Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks Percentage:- ");
            Marks = Convert.ToInt32(Console.ReadLine());

        }
        static void Scholor()
        {
            if(Marks>=70 && Marks<=80)
            {
                sc = 0.2f * Fees;
                Console.WriteLine("Scholorship Amount:- "+sc);
            }
            else if(Marks>80 && Marks<=90)
            {
                sc = (Fees) * 0.3f;
                Console.WriteLine("Scholorship Amount:- " + sc);
            }
            else if(Marks>90)
            {
                sc = (Fees) * 0.5f;
                Console.WriteLine("Scholorship Amount:- " + sc);
            }
            else
            {
                
                Console.WriteLine("Not Eligible for Scholorship");
            }
        }
        static void Main(String[] args)
        {
            Merit();
            Scholor();
            Console.ReadLine();
        }
    }
}
