use Company

--1. Write a T-SQL Program to find the factorial of a given number
Declare @fact int = 1;
Declare @num int = 5;
print ('The factorial of the number'+' '+cast(@num as varchar(10))+' is:- ')
While (@num>1)
Begin
    Set @fact = @fact * @num
    Set @num = @num - 1

end
--Select @fact as 'Factorial of the number'
print (cast(@fact as varchar(10)))

--2. Create a stored procedure to generate multiplication tables up to a given number.
Create OR alter proc tables
    @num int
as
begin
    declare @idx int = 1
    declare @Answer int =1
	declare @Tbl int  =1

while @Tbl <= @num
begin
    while @idx <= 10
    begin
        set @Answer = @Tbl * @idx
        print cast(@Tbl as varchar(10)) + ' * ' + cast(@idx as varchar(10)) + ' = ' + cast(@Answer as varchar(10))
        set @idx = @idx + 1
    end
	set @idx =1
	set @Tbl = @Tbl+1
	print ' '
	end
end
-- Execute the Procedure...
exec tables @num =15

--3. Create a trigger to restrict data manipulation on EMP table during General holidays.
-- Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
-- Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

create  table Holiday
(H_Date date,
H_Name varchar(40))

insert into Holiday values
('2024-03-25','Holi'),
('2024-08-15','Independance Day'),
('2024-08-19','Raksha-Bandhan'),
('2024-03-26','Tuesday')

-- Create trigger on Employee Table
create or alter trigger Trigged_InsertUpdateDelete
on Employee
for insert,update,delete
as
	begin 
	declare @H_Name varchar(20)
		select @H_Name=H_Name from Holiday where convert(date,getdate())=H_Date
		if(@H_Name is not null)
			raiserror('Today is holiday for %s changes are restricted ',16,1,@H_Name)
			rollback
	end
insert into Employee values(4567,'Shantanu','President',5678,'1970-09-12',766,Null,20)
select * from Employee