Create database Test1
use Test1

--Table Books
Create Table Books(Books_Id int primary key, Title varchar(40),Author varchar(25), Isbn Numeric(15) unique,
Published_Date Datetime)

--Insert values in Books Table
Insert Into Books (Books_Id, Title,Author, Isbn, Published_Date)
Values
    (1, 'My First SQL Book', 'Mary Parker', 981483029127, '2012-02-22 12:08:17'),
    (2, 'My Second SQL Book', 'John Mayer',857300923713, '1972-07-03 09:22:45'),
    (3, 'My Third SQL Book',  'Cary Flint', 523120967812, '2015-10-18 14:05:44')

--Data of Books
select * from Books

--Table Reviews
Create Table Reviews (Id Int Primary key,Books_id int Foreign key references Books(Books_id),
    Reviewer_name varchar(40), Content varchar(40),Rating int, Published_date DATETIME)

-- Insert values in Reviews Table
Insert Into Reviews(Id, Books_id, Reviewer_name, Content, Rating, Published_date)
Values(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
      (2, 2, 'John Smith', 'Another review', 5, '2017-10-13 15:05:12'),
      (3, 2, 'Alice Walker', 'My second review', 1, '2017-10-22 23:47:10')

--Data of Reviews
select * from Reviews


--1:- Write a query to fetch the details of the books written by author whose name ends with er.
Select * from Books
where Author Like '%er'

--2:- Display the Title ,Author and ReviewerName for all the books from the above table 
select B.Title,B.Author, R.Reviewer_Name from Books B
Left Join Reviews R On B.Books_Id = R.Books_id

--3:- Display the  reviewer name who reviewed more than one book.
select Reviewer_Name from Reviews
Group by Reviewer_name
having Count(Books_id)>1


--Customer Table
Create Table Customer (Id Int Primary Key,C_Name varchar(40),Age Int,C_Address VARCHAR(40),
Salary Numeric(7))

-- Insert values in Customer table
Insert into Customer (Id,C_Name ,Age,C_Address,Salary)
values(1, 'Ramesh', 32, 'Ahmedabad', 2000),(2, 'Khilan', 25, 'Delhi', 1500),
      (3, 'kaushik', 23, 'Kota', 2000),(4, 'Chaitali', 25, 'Mumbai', 6500),
      (5, 'Hardik', 27, 'Bhopal', 8500),(6, 'Komal', 22, 'MP', 4500),
      (7, 'Muffy', 24, 'Indore', 10000)

-- Data of Customer
Select * from Customer

--4:- Display the Name for the customer from above customer table  who live in same address
--which has character o anywhere in address 
Select C_Name, C_Address from Customer
where C_Address Like '%o%'

-- Orders Table
Create Table Orders(O_id int primary key, O_Date DATETIME,ID int foreign key references Customer(Id),
    Amount Numeric(5))

-- Insert values in Orders table
Insert into orders (O_id, O_Date,ID, Amount) values (102, '2009-10-08 00:00:00', 3, 3000),
    (100, '2009-10-08 00:00:00', 3, 1500),(101, '2009-11-20 00:00:00', 2, 1560),
	(103,'2008-05-20 00:00:00', 4, 2060)

-- Data of Orders Table
select * from Orders

--5:- Write a query to display the Date,Total no of customer  placed order on same Date
Select O_Date, Count(Distinct O_Id) AS Total_Customers From orders
group by O_Date

--6:- Display the Names of the Employee in lower case, whose salary is null 
Select Lower(C_Name) AS Lowercase_Name
from Customer
Where Salary is NULL;

-- Create the 'stu_Detail' table
Create table stu_Detail ( RegisterNo int primary key, Name varchar(50),Age int,Qualification varchar(30),
    MobileNo Numeric(10), Mail_id Varchar(40), Location varchar(30), Gender Varchar(2))
	

-- Table stu_Detail
Insert into stu_Detail (RegisterNo , Name, Age, Qualification, MobileNo, Mail_id, Location, Gender)
Values(1, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
      (2, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
      (3, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
      (4, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
      (5, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
      (6, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M')

-- Data of stu_Detail
select * from stu_Detail

--7:- Write a sql server query to display the Gender,Total no of male and female from the 
-- above relation  
select Gender, Count(*) from stu_Detail
Group by Gender