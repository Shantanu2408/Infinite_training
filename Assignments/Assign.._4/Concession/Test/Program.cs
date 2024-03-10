using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Concession;

namespace Test
{
    class Program
    {
        static int TotalFare = 2000;
        static string Name;
        static int Age;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }

        static void Main(string[] args)
        {
            Program pro = new Program();
            Console.WriteLine("Enter the Name of the Passenger:- ");
            pro._Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Age:- ");
            pro._Age = Convert.ToInt32(Console.ReadLine());
            TicketConcession tc = new TicketConcession();

            tc.CalculateConcession(pro._Name,pro._Age);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
