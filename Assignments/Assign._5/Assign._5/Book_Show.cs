using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._5
{
    class Book_Show
    {
        static string books;
        static void B_Names()
        {
            
            Console.WriteLine("How many Books are there..?:- ");
            int count = Convert.ToInt32(Console.ReadLine());
            string [] books = new string[count];
            Console.WriteLine("Enter Books name:- ");
            for (int i=0; i<count; i++)
            {
                books[i] = Convert.ToString(Console.ReadLine());
            }

        }
        static void dispaly()
        {
            Console.Write("How many Books are there..?");
            int count =Convert.ToInt32(Console.ReadLine());
            string []books = new string [count];
            string [] Author_n = new string[count];
            Console.WriteLine("Enter Books name and Author's Name:- ");
            for(int i=0; i<count; i++)
            {
                Console.Write((i + 1)+":- Book Name-> ");
                books[i] = Convert.ToString(Console.ReadLine());
               // Console.WriteLine();
                Console.Write("Author Name-> ");
                Author_n[i] = Convert.ToString(Console.ReadLine());

            }
            Console.WriteLine("\n\t\t\t\t\t-------------------Books Detail-----------------\n\n");

            for (int i = 0; i < count; i++)
            {
                
                Books w = new Books(books[i], Author_n[i]);
                Console.WriteLine($"\t\t\t\t\t\t{i + 1}:- Book Name:- " + w[0]);
                Console.WriteLine("\t\t\t\t\t\t    Author_Name:- " + w[1]);
            }

               
        }
        static void Main()
        {
            dispaly();
            Console.ReadLine();
           
        }
    }
}
