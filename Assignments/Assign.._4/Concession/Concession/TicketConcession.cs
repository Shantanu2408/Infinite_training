using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        //static string Name;
        static int Ticket_price = 2000;
        public void CalculateConcession(string Name,int age)
        {
            Console.WriteLine();
            Console.WriteLine("-------------Ticket Details------------");
            if (age <= 5)
            {
                Console.WriteLine("Name:- " + Name + "\nAge:- " + age + "\nTicket Price:- {Little Champs-Free Ticket}\nTicket Status- Booked");
            }
            else if (age > 60)
            {
                Console.WriteLine("Name:- " + Name + "\nAge:- " + age + "\nTicket Price after concession:- "+(Ticket_price-600+ "\nTicket Status- Booked"));
            }
            else
            {
                Console.WriteLine("Name:- " + Name + "\nAge:- " + age + "\nTicket Status- Booked");
            }
        }
       // Main function in Program.cs
    }
}
