Create Database Test2
use Test2

create table Data_s(Name varchar(10), Date_of_Birth Datetime)
insert into Data_s values('Shantanu',2023-01-23)
drop table Data_s

-- 1. Write a query to display your birthday( day of week)
select Name,DateName(Dw,Date_of_Birth) as Birth_Day from Data_s

--Output(1):- Name         Birth_Day
--          Shantanu       Friday



-- 2. Write a query to display your age in days
Select Name, DateDiff(day, Date_Of_Birth, GetDate()) as Age_in_Days from Data_s

--Output(2):- Name         Age_in_Days
--          Shantanu       43378



-- 3. Write a query to display all employees information those who joined before 5 years in the current month
 
--(Hint : If required update some HireDates in your EMP table of the assignment)
-- Use Table Employee
select * from Employee
update Employee set Hire_date = '2019-03-28' where Emp_no =7369
update Employee set Hire_date = '2019-04-26' where Emp_no =7566
update Employee set Hire_date = '2019-03-28' where Emp_no =7844
update Employee set Hire_date = '2019-02-23' where Emp_no =7839

Select * from Employee
where Hire_Date <= DateAdd(year, -5, getDate())
and month(Hire_Date) = month(GetDate())

--Output(3):-Emp_no Emp_Name   Job     Mgr_id    Hire_Date  Sal Comm    Dept_no
--           7369	SMITH	   CLERK	7902	2019-03-28	800	NULL	20
--           7844	TURNER	   SALESMAN	7698	2019-03-28	1500	0	30



-- 4. Create table Employee with empno, ename, sal, doj columns and perform the following operations
--  in a single transaction
--	a. First insert 3 rows 
--	b. Update the second row sal with 15% increment  
--  c. Delete first row.
--  After completing above all actions how to recall the deleted row without losing increment of second row.

--Creating Table Employee
Create table Emp (Emp_id int Primary Key,Emp_name varchar(20),Salary Numeric(8),Doj DATE)
--a- Insert 3 rows Data in to Emp Table
Insert Into Emp (Emp_Id, Emp_name, Salary, Doj)
values(1, 'Shantanu', 20000, '2023-03-18'),(2, 'Prashant', 30000, '2022-06-11'),
(3, 'Saksham', 23000, '2021-07-19')
select * from Emp
--Output4(a):- Emp_Id Emp_Name  Salary  Doj
--             1	  Shantanu	20000	2023-03-18
--             2	  Prashant	30000	2022-06-11
--             3	  Saksham	23000	2021-07-19

--b- Update the second row sal with 15% increment  
update Emp set Salary = Salary * 1.15
WHERE Emp_Id = 2;
select * from Emp
--Output4(b):- Emp_Id Emp_Name  Salary  Doj
--             1	  Shantanu	20000	2023-03-18
--             2	  Prashant	34500	2022-06-11
--             3	  Saksham	23000	2021-07-19

--c- Delete first row.
Delete from Emp where Emp_id=1
select * from Emp
--Output4(c):- Emp_Id Emp_Name  Salary  Doj
--             2	  Prashant	34500	2022-06-11
--             3	  Saksham	23000	2021-07-19

--After completing above all actions how to recall the deleted row without losing increment of second row.
create Table Del_Rows(Emp_Id int Primary key,Emp_Name VARCHAR(20),Salary Numeric(8),Doj DATE)
Insert into Del_Rows(Emp_Id, Emp_Name, Salary, Doj)
select Emp_Id, Emp_Name, Salary, Doj from Emp
where Emp_id = 1;

Delete from Emp WHERE Emp_id = 1;

select * from Emp
--             Emp_Id Emp_Name  Salary  Doj
--             2	  Prashant	34500	2022-06-11
--             3	  Saksham	23000	2021-07-19

-- 5. Create a user defined function calculate Bonus for all employees of a given job using following conditions
--	a. For Deptno 10 employees 15% of sal as bonus.
--	b. For Deptno 20 employees  20% of sal as bonus
--	c  For Others employees 5%of sal as bonus
create function Calc_bonus(@dept_no int)
returns float
begin
	declare @bonus float
	if @dept_no = 10 then
			select @bonus = (Salary * 0.15) from Employee where Dept_no = @dept_no
	else if @dept_no = 20 then 
			select @bonus = (Salary * 0.20) from Employee where Dept_no = @dept_no
	else
	 select @bonus = (Salary * 0.05) from Employee where Dept_no = @dept_no
	end if
	return @bonus
end

select * from Calc_bonus(10)