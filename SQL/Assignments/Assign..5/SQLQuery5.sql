use Company

--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--   a) HRA as 10% of Salary
--   b) DA as 20% of Salary
--   c) PF as 8% of Salary
--   d) IT as 5% of Salary
--   e) Deductions as sum of PF and IT
--   f) Gross Salary as sum of Salary,HRA,DA
--   g) Net Salary as Gross Salary - Deductions


--Create the Procedure for PaySlip 
Create or alter proc Pay_Slip
    @Emp_Id int
as
begin
Declare @Salary Numeric(7)
Declare @Hra Numeric(7)
Declare @Da Numeric(7) 
Declare @PF Numeric(7)
Declare @IT Numeric(7)
Declare @Deductions Numeric(7)
Declare @Gross_Salary Numeric(7)
Declare @Net_Salary Numeric(10)

 
--Select the Salary of Employee from Employee Table
Select @Salary = Salary From Employee
Where Emp_no= @Emp_ID

-- HRA, DA, PF, and IT
Set @HRA = 0.10 * @Salary
Set @DA = 0.20 * @Salary
Set @PF = 0.08 * @Salary
Set @IT = 0.05 * @Salary

-- Deductions
Set @Deductions = @PF + @IT

-- Gross Salary
Set @Gross_Salary = @Salary + @Hra + @DA

 --Calculate Deductions
Set @Deductions = @PF + @IT

-- Net Salary
Set @Net_Salary = @Gross_Salary - @Deductions

--Payslip Detail
Print('                             PaySlip of Emp_no('+Cast(@Emp_id as varchar(10))+')')
Print ('Basic_Salary:- ' + Cast(@Salary as varchar(10)))
Print ('HRA:- ' + Cast(@HRA as varchar(10)))
Print ('Da:- ' + CAST(@DA as varchar(10)))
Print ('PF:- ' + CAST(@PF as varchar(10)))
Print ('IT:- ' + CAST(@IT as varchar(10)))
Print ('Deduction:- ' + Cast(@Deductions as varchar(10)))
Print ('Gross_Salary:- ' + Cast(@Gross_Salary as varchar(10)))
Print ('Net_Salary:- ' + Cast(@Net_Salary as varchar(10)))

end

--Data of Employee Table
Select * from Employee

--Execute the procedure..
exec Pay_Slip @Emp_id = 7566