using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_AS_1
{
    //1. Create a console application and add class named Employee with following field.
    //Create class Employees 
    class Employees
    {
       public int Emp_ID { get; set; }
       public string First_Name { get; set; }
       public string Last_Name { get; set; }
       public string Title { get; set; }
       public DateTime D_O_B { get; set; }
       public DateTime D_O_J { get; set; }
       public string City { get; set; }
    }

    class Program
    {


        static void Main(string[] args)
        {
            //2.Create a Generic List Collection empList and populate it with the following records.
            // Create a method Insert_Data to insert all Value in Employees
            List<Employees> Emp = new List<Employees>
            {
            new Employees { Emp_ID = 1001, First_Name = "Malcolm", Last_Name = "Daruwalla", Title = "Manager",     D_O_B = new DateTime(1984, 11, 16), D_O_J = new DateTime(2011, 6, 8),  City = "Mumbai" },
            new Employees { Emp_ID = 1002, First_Name = "Asdin",   Last_Name = "Dhalla",    Title = "AsstManager", D_O_B = new DateTime(1984, 8, 20),  D_O_J = new DateTime(2012, 7, 7),  City = "Mumbai" },
            new Employees { Emp_ID = 1003, First_Name = "Madhavi", Last_Name = "Oza",       Title = "Consultant",  D_O_B = new DateTime(1987, 11, 14), D_O_J = new DateTime(2015, 4, 12), City = "Pune" },
            new Employees { Emp_ID = 1004, First_Name = "Saba",    Last_Name = "Shaikh",    Title = "SE",          D_O_B = new DateTime(1990, 6, 3),   D_O_J = new DateTime(2016, 2, 2),  City = "Pune" },
            new Employees { Emp_ID = 1005, First_Name = "Nazia",   Last_Name = "Shaikh",    Title = "SE",          D_O_B = new DateTime(1991, 3, 8),   D_O_J = new DateTime(2016, 2, 2),  City = "Mumbai" },
            new Employees { Emp_ID = 1006, First_Name = "Amit",    Last_Name = "Pathak",    Title = "Consultant",  D_O_B = new DateTime(1989, 11, 7),  D_O_J = new DateTime(2014, 8, 8),  City = "Chennai" },
            new Employees { Emp_ID = 1007, First_Name = "Vijay",   Last_Name = "Natrajan",  Title = "Consultant",  D_O_B = new DateTime(1989, 12, 2),  D_O_J = new DateTime(2015, 6, 1),  City = "Mumbai" },
            new Employees { Emp_ID = 1008, First_Name = "Rahul",   Last_Name = "Dubey",     Title = "Associate",   D_O_B = new DateTime(1993, 11, 11), D_O_J = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employees { Emp_ID = 1009, First_Name = "Suresh",  Last_Name = "Mistry",    Title = "Associate",   D_O_B = new DateTime(1992, 8, 12),  D_O_J = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employees { Emp_ID = 1010, First_Name = "Sumit",   Last_Name = "Shah",      Title = "Manager",     D_O_B = new DateTime(1991, 4, 12),  D_O_J = new DateTime(2016, 1, 2),  City = "Pune" }
        };
            Console.WriteLine("\t\t\t\t\t\t*Employee Table*\n\n\n");
            foreach(var x in Emp)
            {
                Console.Write("First_Name:"+x.First_Name+" Last_Name:"+x.Last_Name+ " Title:"+x.Title+" D.O.B: "+x.D_O_B+ " D.O.J: " + x.D_O_J+" City: "+x.City+"\n");
            }
            Console.WriteLine("\n\n\n");

            //1.Display a list of all the employee who have joined before 1/ 1/2015
            var Emp_Join_Before15 = Emp.Where(a => a.D_O_J< new DateTime(2015, 1, 1));
            Console.WriteLine("1:- Employees who have joined before 1/1/2015:");
            Console.WriteLine();
            foreach (var Em in Emp_Join_Before15)
            {
                Console.WriteLine($"Emp_Id: {Em.First_Name}, Last_Name: {Em.Last_Name}, City: {Em.City}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            var Emp_Birth = Emp.Where(a => a.D_O_B> new DateTime(1990, 1, 1));
            Console.WriteLine("2:- Employees whose date of birth is after 1 / 1 / 1990:");
            Console.WriteLine();
            foreach (var Em in Emp_Birth)
            {
                Console.WriteLine($"First_Name: {Em.First_Name}, Last_Name: {Em.Last_Name}, City: {Em.City}, DOB: {Em.D_O_B}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //3.Display a list of all the employee whose designation is Consultant and Associate
            var Emp_Des = Emp.Where(a => a.Title == "Consultant" || a.Title == "Associate");
            Console.WriteLine("3:- Employees whose designation is Consultant and Associate:");
            Console.WriteLine();
            foreach (var Em in Emp_Des)
            {
                Console.WriteLine($"First_Name: {Em.First_Name}, Last_Name: {Em.Last_Name}, Title: {Em.Title}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //4.Display total number of employees
            var Tot_Emp = Emp.Count();
            Console.Write("4:- Total Number of Employees:-");
            Console.WriteLine(Tot_Emp);
            Console.WriteLine("---------------------------------------------------------------------------------------");
            //5.Display total numberof employees belonging to “Chennai”
            var Find_City = Emp.Where(c => c.City == "Chennai");
            int Total = Find_City.Count();
            Console.Write("5:- Total Number of Employees belonging to “Chennai”:-");
            Console.WriteLine(Total);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //6.Display highest employee id from the list
            var Emp_Max = Emp.Max(e=>e.Emp_ID);
            Console.Write("6:- Employee Who have highest employee id from the list:-");
            Console.WriteLine((int)Emp_Max);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //7.Display total number of employee who have joined after 1 / 1 / 2015
            var Emp_Join = Emp.Where(j => j.D_O_J > new DateTime(2015, 1, 1));
            Console.WriteLine("7:- Employees who have joined after 1/1/2015:");
            Console.WriteLine();
            foreach (var Emj in Emp_Join)
            {
                Console.WriteLine($"First_Name: {Emj.First_Name}, Last_Name: {Emj.Last_Name}, City: {Emj.City}, DOJ: {Emj.D_O_J}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //8.Display total number of employee whose designation is not “Associate”
            var Find_Dest1 = Emp.Where(c => c.Title != "Associate");
            int Count1 = Find_Dest1.Count();
            Console.Write("8:- Total Number of Employees whose designation is not “Associate”:-");
            Console.WriteLine(Count1);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //9.Display total number of employee based on City
            var Total_B_City = Emp.GroupBy(b => b.City).Select(G_city=>new { City = G_city.Key, Emp_C = G_city.Count()});
            Console.Write("9:- Total Number of Employees based on City:-\n");
            foreach (var val in Total_B_City)
            {
                Console.WriteLine(val.City+"-"+val.Emp_C);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //10.Display total number of employee based on city and title
            var Total_Emp_B = Emp.GroupBy(b =>new { b.City, b.Title }).Select(GC_t => new { City = GC_t.Key.City, Title = GC_t.Key.Title ,Emp_C = GC_t.Count() });
            Console.Write("10:- Total Number of Employees based on city and title:-\n");
            foreach (var val1 in Total_Emp_B)
            {
                Console.WriteLine(val1.City + "-" + val1.Title +" ("+val1.Emp_C+")");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            //11.Display total number of employee who is youngest in the list
            var Youngest_Emp = Emp.Min(e => (DateTime.Today - e.D_O_B).TotalDays);
            var Y_Employee = Emp.Where(e => (DateTime.Today - e.D_O_B).TotalDays == Youngest_Emp);
            Console.WriteLine("11:- Employee who is youngest in the list");
            foreach (var YE in Y_Employee)
            {
                Console.Write($"First_Name: {YE.First_Name}, Last_Name: {YE.Last_Name}, City: {YE.City}, DOB: {YE.D_O_B}");
            }
            Console.WriteLine();
            Console.WriteLine("Total number of employee who is youngest in the list: "+Y_Employee.Count());
            Console.ReadLine();

    }
    }
}
