Create Database Details
use Details

-- create table Employee
Create table Employee(Emp_no Numeric(5), Emp_Name varchar(20), job varchar(20),Mgr_id Numeric(5), 
Hire_date Date, Salary Numeric(5),Comm Numeric(5), Dept_no Numeric(3) foreign key references Department(Dept_no))

--Insert values in Employee
Insert into Employee  values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '09-JUNE-81', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '17-NOV-81', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, 0,30),
(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566,'03-DEC-81', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782,'23-JAN-82', 1300, NULL, 10)

-- Data of Table Employee
 select * from Employee

 -- Create tabel Department
 create table Department(Dept_No Numeric(3) primary Key, Dept_Name varchar(15), Loc varchar(20)) 

 -- insert values in Department table
 insert into Department values(10, 'ACCOUNTING', 'NEW YORK'),(20, 'RESEARCH', 'DALLAS'),
                              (30, 'SALES', 'CHICAGO'),(40, 'OPERATIONS', 'BOSTON')

-- Data of Table Department
select * from Department

--1. Retrieve a list of MANAGERS. 
select * from Employee where job ='Manager'

--2. Find out the names and salaries of all employees earning more than 1000 per month.
select Emp_Name,Salary from Employee 
where Salary>1000;

--3. Display the names and salaries of all employees except JAMES.
select Emp_Name, Salary from Employee
where Emp_Name!='James'

--4. Find out the details of employees whose names begin with ‘S’.
select * from Employee where Emp_Name Like 'S%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select Emp_Name from Employee where Emp_Name Like '%A%'

--6. Find out the names of all employees that have ‘L’ as their third character in their name.
select Emp_Name from Employee where Emp_Name Like '__L%'

--7. Compute daily salary of JONES. 
select Emp_Name, (Salary/30) as Daily_Salary from Employee
where Emp_Name= 'Jones'

--8. Calculate the total monthly salary of all employees. 
select sum(Salary) as Total_Monthly_Salary_of_all_Employees from Employee

--9. Print the average annual salary .
select avg(Salary*12) as Average_Annual_Salary from Employee

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select E.Emp_Name,E.job, E.Salary,E.Dept_no from Employee E
where E.job != 'Salesman' or E.Dept_no ! =30

--11. List unique departments of the EMP table.
select Distinct Dept_no, Dept_Name from Department

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select Emp_Name as Name_of_Employee, Salary as Monthly_Salary ,Dept_no from Employee 
where Dept_no in(10,30) and Salary>1500

--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select Emp_Name as "Name_of_Employee", Job, Salary as "Monthly_Salary" from Employee
where Job= 'Manager' or job ='Analyst'
and Salary Not in(1000,3000,5000)

--14. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
select Emp_Name, Salary, Comm as Commision, Salary*1.10 as "Updated_Salary" from Employee
where Comm > Salary 

--15. Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782.
select Emp_Name,Dept_no,Mgr_id from Employee
where Emp_Name Like '%L%L%'
And Dept_no=30 or Mgr_id=7782

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 

select Emp_Name from Employee
where DATEDIFF(yy,Hire_Date, GetDate()) between 30 and 40


--17. Retrieve the names of departments in ascending order and their employees in descending order.
Select Dept.Dept_Name, E.Emp_Name from Department Dept
Left join Employee E On E.Dept_no = Dept.Dept_No
Order by Dept_Name, Emp_Name desc

--18. Find out experience of MILLER.
select DATEDIFF(yy,Hire_Date,GetDate()) as Experience from Employee
where Emp_Name = 'Miller'