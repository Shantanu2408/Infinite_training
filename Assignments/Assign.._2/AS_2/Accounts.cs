using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_2
{
    class Accounts
    {
        static long Account_No;
        static string Customer_Name;
        static string Account_Type;
        static char Transaction_Type;
        static double Amount;
        static double Balance =30000;

        static void details()
        {
            Console.WriteLine("Fill all details:- ");
            Console.WriteLine("Customer Name:-");
            Customer_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Account No:- ");
            Account_No = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Account Type:- ");
            Account_Type = Convert.ToString(Console.ReadLine());

        }
            Accounts()
        {
            Console.WriteLine("\t\t\t\t\tAccount No:- "+Account_No);
            Console.WriteLine("\t\t\t\t\tCustomer_Name:- " + Customer_Name);
            Console.WriteLine("\t\t\t\t\tAccount Type:- " + Account_Type);
        }
            static void Credit(int amount)
            {
                int Total = amount + (int)Balance;
                DateTime dt = DateTime.Now;
                Console.WriteLine("Your a/c XXXXXX is credited INR\n" + amount + " on " + dt + ".\nAval Bal INR " + Total+".");
            }
            static void Debit(int amt)
            {
            int Tab = (int)Balance - amt;
            DateTime dt = DateTime.Now;
            Console.WriteLine("A/c XXXXXX is debited INR\n" + amt + " on " + dt + ".\nAval Bal INR " + Tab + ".");

            }
            
            static void show()
            {
            Console.WriteLine("\t\t\t\t\tAccount No:- " + Account_No);
            Console.WriteLine("\t\t\t\t\tCustomer_Name:- " + Customer_Name);
            Console.WriteLine("\t\t\t\t\tAccount Type:- " + Account_Type);
           
            
        }
        


        static void Main(string[] args)
        {
            details();
            Accounts a = new Accounts();
            Console.WriteLine("\n");
            Console.WriteLine("Enter Transaction Type:- (dw)->withdrawl, (dt)->deposit");
            string key = Convert.ToString(Console.ReadLine());
            switch(key)
            {
                case string ct when(key=="dw" || key=="DW" || key=="Dw"):
                    Console.WriteLine("Enter the amount, You want to withdraw:-> ");
                    int wd = Convert.ToInt32(Console.ReadLine());
                    Debit(wd);
                    break;
                case string ct when(key=="DT" || key=="dt" || key =="Dt"):
                    Console.WriteLine("Enter the amount, You want to deposit:-> ");
                    int cd = Convert.ToInt32(Console.ReadLine());
                    Credit(cd);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.WriteLine("Want to see Account details press 'Y' otherwise press 'N' ");
            char ps = Convert.ToChar(Console.ReadLine());
            if(ps=='Y' || ps=='y')
            {
                show();
            }
            else if (ps=='N' || ps=='n')
            {
                Console.WriteLine("You can Exit now..");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
              Console.ReadLine();
        }
    }
}
