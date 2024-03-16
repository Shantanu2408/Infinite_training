Create Database IT_Firm;
use IT_Firm

-- clients Table
create Table Clients( Client_Id Numeric(4) primary key, C_name varchar(40), Address varchar(40), Email varchar(30) unique,
phone numeric(10), Business varchar(20) )

-- Department table
create table Department(Deptno Numeric(2) primary key, Dname varchar(20), Loc varchar(20))

-- Table Employees take references from Department through Deptno..
create Table Employees(Empno Numeric(4) Primary key, Ename varchar(20), Job varchar(30),Salary Numeric(7),Deptno numeric(2) foreign key
references Department(Deptno))

--Project Table
create table Project(Project_id Numeric(3) primary key,Descr varchar(30),startDate Date,Planned_End_Date Date,
Actual_End_Date Date, Budget Numeric(10), Client_id Numeric(4) foreign key references Clients(Client_id))

--Employee Project Task Table
create table EmpProjectTask(Project_ID numeric(3),Empno numeric(4),StartDate date,EndDate date,
Task varchar(25),Status varchar(15),primary key(Project_ID,Empno),
foreign key (Empno)references Employee(Empno),
foreign key (Project_ID)references Project(Project_ID))

--Insert values in client table 
insert into Clients values
(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')

select * from Clients

--insert values in Department table
insert into Department values(10,'Design','Pune'),(20,'Development','pune'),(30,'Testing','Mumbai'),
(40,'Document','Mumbai')

select * from Department

--Insert values in Employees Table
insert into Employees values(7001,'Sandeep','Analyst',25000,10),(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),(7004,'Manoj','Developer',40000,20),(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30),(7009,'Nutan','Developer',45000,20),(7010,'Smita','Analyst',20000,10)

select * from Employees

--Insert into Project Table
insert into Project values(401,'Inventory','2011-04-01','2011-10-01','2011-10-31',150000,1001),
(402,'Accounting','2011-08-01','2012-01-01',null,150000,1002),(403,'Payroll','2011-12-11','2011-12-31',null,150000,1003),
(404,'Contact mgmt','2011-11-01','2011-12-31',null,150000,1004)

select * from Project


--insert value in EmpProject task 
insert into EmpProjectTask values
(401,7001,'2011-04-01','2011-04-20','System Analysis','Completed'),(401,7002,'2011-04-21','2011-05-30','System Design','Completed'),
(401,7003,'2011-06-01','2011-07-15','Coding','Completed'),(401,7004,'2011-07-18','2011-09-01','Coding','Completed'),
(401,7006,'2011-09-03','2011-09-15','Testing','Completed'),(401,7009,'2011-09-18','2011-10-05','Code Change','Completed'),
(401,7008,'2011-10-06','2011-10-16','Testing','Completed'),(401,7007,'2011-10-06','2011-10-22','Documentation','Completed'),
(402,7011,'2011-10-22','2011-10-31','Sign Off','Completed'),(402,7010,'2011-08-01','2011-08-20','System Analysis','Completed'),
(402,7002,'2011-08-22','2011-09-30','System Design','Completed'),(402,7004,'2011-10-01',null,'Coding','in Process')

select * from EmpProjectTask

