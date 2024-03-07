using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assign._3
{
    class Doctor

    {
        int Regno;
        string Name;
        int FeesCharged;

         public int _Regno
        {
            get { return Regno; }
            set { Regno = value; }
        }
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int _FeesCharged
        {
            get { return FeesCharged; }
            set { FeesCharged = value; }
        }
        public void properties()
        {
            Console.WriteLine("-----Display Details------\n");
            Doctor doct = new Doctor();
            doct._Regno = 23;
            doct._Name = "Shantanu Singh";
            doct._FeesCharged = 1100;
            Console.WriteLine("Registration Number:- "+doct._Regno);
            Console.WriteLine("Name:- "+doct._Name);
            Console.WriteLine("Fees:- "+doct._FeesCharged);
            Console.Read();
        }
        static void Main(string [] args)
        {
            Doctor doc = new Doctor();
            doc.properties();
            Console.ReadLine();
        }
    }
}