using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Employee_Management
{
    class Program
    {
        public static SqlConnection connect = null;
        public static SqlCommand cmd;
        public static SqlDataReader Sdr;

        //Call the function
        static void Main(string[] args)
        {
            Insert_Data();
            Display_Data();
            Console.ReadLine();
        }

        //Get Connection
        public static SqlConnection Get_Connection()
        {
            connect = new SqlConnection("data source=ICS-LT-GZQSBN3\\SQLEXPRESS;initial catalog=Employee_Management;" +
                "integrated security=true");
            connect.Open();
            return connect;
        }

        

        //Insert Data

        public static void Insert_Data()
        {

            using (connect = Get_Connection())
            using (cmd = new SqlCommand("Add_Row", connect)) 
            {
                string EmpName;
                int Emp_Sal;
                char Emp_Type;
                Console.WriteLine("Insert the data in Employee_Details Table:- ");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Console.WriteLine("");
                Console.Write("Enter Employee Name: ");
                EmpName = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Employee Salary: ");
                Emp_Sal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Type: ");
                Emp_Type = Convert.ToChar(Console.ReadLine());

                    cmd = new SqlCommand("insert into Employee_Details values(@EmpName,@EmpSalary,@EmpType)", connect);
                    cmd.Parameters.AddWithValue("@EmpName", EmpName);
                    cmd.Parameters.AddWithValue("@EmpSalary", Emp_Sal);
                    cmd.Parameters.AddWithValue("@EmpType", Emp_Type);

                //connect.Open();
                cmd.ExecuteNonQuery();
                      
                        Console.WriteLine("\t\t\t\t\t\tData Inserted Successfully..");
                //connect.Close();
                    
            }
        }
            // Display Data
            public static void Display_Data()
            {
                connect = Get_Connection();

                cmd = new SqlCommand("select * from Employee_Details");
                cmd.Connection = connect;

                Sdr = cmd.ExecuteReader();
                int i = 1;
                while (Sdr.Read())
                {
                    Console.WriteLine(i+"=>");
                    Console.WriteLine("Employee Number: " + Sdr[0]);
                    Console.WriteLine("Employee Name: " + Sdr[1]);
                    Console.WriteLine("Employee Salary: " + Sdr[2]);
                    Console.WriteLine("Employee Type: " + Sdr[3]);
                    Console.WriteLine("-------------------------------\n");
                    i++;

                }
            }

        }


    }

