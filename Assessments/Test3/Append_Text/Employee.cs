using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Text
{
    class Employee
    {
        public int Employee_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

    }
    //    EmployeeID FirstName    LastName Title                DOB DOJ             City
    //1001	        Malcolm Daruwalla   Manager 		16/11/1984 	8/6/2011 		Mumbai
    //1002 		Asdin Dhalla      AsstManager 	        20/08/1984 	7/7/2012 		Mumbai
    //1003 		Madhavi Oza         Consultant 	        14/11/1987 	12/4/2015 	        Pune
    //1004 		Saba Shaikh      SE 			3/6/1990	2/2/2016	 	Pune
    //1005 		Nazia Shaikh      SE 			8/3/1991 	2/2/2016	 	Mumbai
    //1006 		Amit Pathak      Consultant 	        7/11/1989 	8/8/2014 		Chennai
    //1007 		Vijay Natrajan    Consultant 	        2/12/1989	1/6/2015 		Mumbai
    //1008 		Rahul Dubey       Associate	 	11/11/1993 	6/11/2014	 	Chennai
    //1009 		Suresh Mistry      Associate 	        12/8/1992 	3/12/2014        	Chennai
    //1010 		Sumit Shah        Manager 		12/4/1991 	2/1/2016 		Pune

    //Now once the collection is created write down and execute the LINQ queries for collection 
    //as follows :
    public class Emp_detail
    {
        static void Main()
        {
            List<Employee> Emp_List = new List<Employee>
        {
            new Employee { Employee_id = 1001, First_Name ="Molcolm", Last_Name="Daruwalla", Title="Manager", DOB="16/11/1984", DOJ="8/6/2011", City="Mumbai"},
            new Employee { Employee_id = 1002, First_Name ="Asdin", Last_Name="Dhalla", Title="AsstManager", DOB="20/08/1984", DOJ="7/7/2012", City="Mumbai"},
            new Employee { Employee_id = 1003, First_Name ="Madhavi", Last_Name="Oza", Title="Consultant", DOB="14/11/1987", DOJ="12/4/2015", City="Pune"},
            new Employee { Employee_id = 1004, First_Name ="Saba", Last_Name="Shaikh", Title="SE", DOB="03/06/1990", DOJ="2/2/2016", City="Pune"},
            new Employee { Employee_id = 1005, First_Name ="Nazia", Last_Name="Shaikh", Title="SE", DOB="8/3/1991", DOJ="2/2/2016", City="Mumbai"},
            new Employee { Employee_id = 1006, First_Name ="Amit", Last_Name="Pathak", Title="Consultant", DOB="7/11/1989", DOJ="8/8/2014", City="Chennai"},
            new Employee { Employee_id = 1007, First_Name ="Vijay", Last_Name="Natrajan", Title="Consultant", DOB="2/12/1989", DOJ="1/6/2015", City="Mumbai"},
            new Employee { Employee_id = 1008, First_Name ="Rahul", Last_Name="Dubey", Title="Associate", DOB="11/11/1993", DOJ="6/11/2014", City="Chennai"},
            new Employee { Employee_id = 1009, First_Name ="Suresh", Last_Name="Mistry", Title="Associate", DOB="12/8/1992", DOJ="3/12/2014", City="Chennai"},
            new Employee { Employee_id = 1010, First_Name ="Sumit", Last_Name="Shah", Title="Manager", DOB="12/4/1991", DOJ="2/1/2016 ", City="Pune"},

        };
            Console.WriteLine("\t\t\t\t\t------------Data of all Employee--------");

            foreach(var Emp in Emp_List)
            {
                Console.WriteLine($"Emp_Id= {Emp.Employee_id}, First_Name= {Emp.First_Name}, Last_Name= {Emp.Last_Name}, Title= {Emp.Title}, DOB= {Emp.DOB}, DOJ={Emp.DOJ} City= {Emp.City}");
                Console.WriteLine();
            }

            Console.WriteLine("Details of all the employee whose location is not Mumbai");
            var Not_presentinMumbai = Emp_List.Where(Emp => Emp.City != "Mumbai").ToList();
            foreach(var Emp in Not_presentinMumbai)
            {
                Console.WriteLine($"Emp_Id= {Emp.Employee_id}, First_Name= {Emp.First_Name}, Last_Name= {Emp.Last_Name}, Title= {Emp.Title}, DOB= {Emp.DOB}, DOJ={Emp.DOJ} City= {Emp.City}");
            }
            
            Console.WriteLine("Details of all the employee whose title is AsstManager");
            var Asst_manager = Emp_List.Where(Emp => Emp.Title == "Asstmanager").ToList();
            foreach(var Emp in Asst_manager)
            {
                Console.WriteLine($"Emp_Id= {Emp.Employee_id}, First_Name= {Emp.First_Name}, Last_Name= {Emp.Last_Name}, Title= {Emp.Title}, DOB= {Emp.DOB}, DOJ={Emp.DOJ} City= {Emp.City}");
            }
           
            Console.WriteLine("Details of all the employee whose Last Name start with S");
            var First_Char_s = Emp_List.Where(Emp => Emp.Last_Name.StartsWith("S")).ToList();

            foreach(var Emp in First_Char_s)
            {
                Console.WriteLine($"Emp_Id= {Emp.Employee_id}, First_Name= {Emp.First_Name}, Last_Name= {Emp.Last_Name}, Title= {Emp.Title}, DOB= {Emp.DOB}, DOJ={Emp.DOJ} City= {Emp.City}");
            }
            Console.ReadLine();
    }
    }
}