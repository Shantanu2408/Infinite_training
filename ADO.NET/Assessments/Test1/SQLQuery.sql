--A:- Creating Database
Create Database Employee_Management
use Employee_Management

--B:- Create a table in the database called Employee_Details (Empno int Primary Key,EmpName varchar(50) not null,
--Empsal numeric(10,2) apply a check condition that empsal >=25000 Emptype char(1) check whether type is 'P' or 'C')
Create Table Employee_Details(Emp_no int Primary key,Emp_Name varchar(50) not null,Emp_Salary numeric(10) check
(Emp_Salary>=25000),Employee_Type Char(1) check(Employee_Type In ('P','C')))

--1:-Create a stored procedure that adds new rows to the Employee_Details Table. The procedure should accept all the 
--details as input except empno. You need to write the code in the procedure to generate the empno and then insert.
Create or alter Proc Add_Row(@EmpName varchar(50), @EmpSalary numeric(10), @EmpType Char(1))
As
begin
-- Generating a new Employee number....
Declare @New_Emp_no int
    Set @New_Emp_no = (Select Isnull(Max(Emp_no), 0) + 21 from Employee_Details)
--Insert
Insert Into Employee_Details (Emp_no, Emp_Name, Emp_Salary, Employee_Type)
values (@New_Emp_no, @EmpName, @EmpSalary, @EmpType)
end



