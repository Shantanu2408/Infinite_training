Create Database Company
use Company

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

-- 1:-  List all employees whose name begins with 'A'.
 select * from Employee where Emp_Name Like 'A%'

-- 2:-  Select all those employees who don't have a manager
 select * from Employee where Mgr_id is null

-- 3:-  List employee name, number and salary for those employees who earn in the range 1200 to 1400
 select Emp_Name, Emp_no, Salary from Employee where Salary Between 1200 and 1400

 /* 4:- Give all the employees in the RESEARCH department a 10% pay rise. 
     Verify that this has been done by listing all their details before and after the rise.*/

-- Find the Dept_no using Dept_name
Select Dept_Name, Dept_No FROM Department
Where Dept_Name= 'Research';

-- Now we can use Department No. to Pay rise...

--Before PayRise
Select Emp_no, Emp_Name, Job, salary From Employee
where Dept_no = 20;

--After PayRise
select Emp_no, Emp_Name, Job, Salary = (Salary * 1.10) from Employee
Where Dept_no = 20;

-- 5:- Find the number of CLERKS employed. Give it a descriptive heading.
Select COUNT(*) as "Number of the Employees, Who are Clerk" from Employee
where job = 'CLERK';

-- 6:- Find the average salary for each job type and the number of people employed in each job
select job,Avg(Salary) as Average_Salary from Employee
Group by job

-- 7:- List the employees with the lowest and highest salary
--Maximum Salary
select Emp_No,Emp_Name,job,Mgr_id,Hire_Date, Salary as "Max Salary of Employees",Comm,Dept_no from Employee
where Salary  =(select Max(Salary) from Employee)
--Minimum Salary
select Emp_No,Emp_Name,job,Mgr_id,Hire_Date, Salary as "Min Salary of Employees",Comm,Dept_no from Employee
where Salary  =(select Min(Salary) from Employee)

-- 8:- List full details of departments that don't have any employees.
select Dept.Dept_No, Dept.Dept_Name, Dept.Loc
FROM Department dept
Left JOIN Employee Em ON Dept.Dept_No = Em.Dept_no
WHERE Em.Emp_no IS NULL;

--9:- Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.
--    Sort the answer by ascending order of name. 
select Emp_Name, Salary, Job from Employee
where Salary>1200 and Dept_no=20 and job = 'Analyst'
Order by Emp_Name

--10:- For each department, list its name and number together with the total salary paid to employees in that department. 
 select Dept.Dept_Name, Dept.Dept_no, sum(E.Salary) from Department Dept
 Left join Employee E on Dept.Dept_no = E.Dept_no
 Group by dept.Dept_no, Dept.Dept_Name
 Order by Dept.Dept_No

--11:- Find out salary of both MILLER and SMITH
select Emp_Name,Salary from Employee
where Emp_Name='MILLER' or Emp_Name='SMITH'

--12:- Find out the names of the employees whose name begin with ‘A’ or ‘M’.
select Emp_Name from Employee 
where Emp_Name Like 'A%M'

--13:- Compute yearly salary of SMITH. 
select Emp_Name, Salary*12 from Employee
where Emp_Name ='Smith'

--14:- List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select Emp_Name, Salary from Employee
where Salary Not Between 1500 and 2850

--15:- Find all managers who have more than 2 employees reporting to them
select Mgr_id, count(Emp_no) as "Total Employee" from Employee
group by Mgr_id
having count(Emp_no) > 2;