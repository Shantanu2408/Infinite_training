using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_2
{
    class Saledetails
    {
        //Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
        public int Salesno;
        public int Productno;
        public int Price;
        public string dateofsale;
        public int Qty;
        static int TotalAmount;
        //SalesNo, Productno, Price,Qty and Dateof sale
        Saledetails(int Salesno, int Productno, int Price, int Qty, string dateofsale)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.Qty = Qty;
            this.dateofsale = dateofsale;

        }
         
        void Sales()
        {
            int Total_Amount = Qty * Price;
            Console.WriteLine("Total Amount of product:- " + Total_Amount);

        }
        void Show_Data()
        {
            Console.WriteLine("\t\t\t\t\t\t-:Product Details:-");
            Console.WriteLine("Sales No:- " + Salesno);
            Console.WriteLine("Product No:- " + Productno);
            Console.WriteLine("Price:- " + Price);
            Console.WriteLine("Qty:- " + Qty);
            Console.WriteLine("Date:- " + dateofsale);
        }
        static void Main(String[] args)
        {
            Saledetails st = new Saledetails(445, 003,45,4,"25/01/2024");
            st.Show_Data();
            Console.WriteLine("\n");
            st.Sales();
            Console.ReadLine();

        }
    }
    
}
