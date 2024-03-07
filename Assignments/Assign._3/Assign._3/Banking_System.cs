using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._3
{
    //- you have a class which has methods for transaction for a banking system. (created earlier)
    //•	Define your own methods for deposit money, withdraw money and balance in the account.
    //•	Write your own new application Exception class. 
    //•	This new Exception will be thrown in case of withdrawal of money from the account where customer doesn’t have sufficient balance.
    //•	Identify and categorized all possible checked and unchecked exception.

    public class insufficient_BLC : Exception
        {
           public insufficient_BLC()
          {
            Console.WriteLine("----Insufficient Balance------");
            Console.Beep();
          }
        }
    class Banking_System
    {
        static int Balance;
        static string Bank_Name;
        static string Account_no;
         
        static void Main(String [] args)
        {
           
            display();
            try
            {
                Transaction();
            }
            catch (insufficient_BLC e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        static void display()
        {
            Balance = 12000;
            Bank_Name = "HDFC";
            Account_no = "602700013100640";
            Console.WriteLine("----Your Account Detail----");
            Console.WriteLine();
            Console.WriteLine("Bank_Name:- "+Bank_Name);
            Console.WriteLine("Account No:- " + Account_no);
            Console.WriteLine("Current Balance:- " + Balance);
        }
        static void Transaction()
        {
            Console.WriteLine();
            Console.WriteLine("press 1 if you want to deposit / press 2 if you want to Withdraw the money:- ");
            int key =Convert.ToInt32(Console.ReadLine());
            switch(key)
            {
                case 1:
                    Deposit_Money();
                    break;
            
                case 2:
                    Withdraw_Money();
                    
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        static void Deposit_Money()
        {
            Console.WriteLine("Enter the money you want to Deposit:-");
            int dm = Convert.ToInt32(Console.ReadLine());
            int Total = Balance + dm;
            DateTime dt = DateTime.Now;
            Console.WriteLine("Your a/c XXXXXX is credited INR\n" + dm + " on " + dt + ".\nAval Bal INR " + Total + ".");
        }
        static int dl;
        static void Withdraw_Money()
        {
            Console.WriteLine("Enter the money you want to Withdraw:-");
            dl = Convert.ToInt32(Console.ReadLine());
            if (dl < Balance)
            {
                int Tot = Balance - dl;
                DateTime dt = DateTime.Now;
                Console.WriteLine("A/c XXXXXX is debited INR\n" + dl + " on " + dt + ".\nAval Bal INR " + Tot + ".");
            }
            else
                throw new insufficient_BLC();
        }


    }
    
}
