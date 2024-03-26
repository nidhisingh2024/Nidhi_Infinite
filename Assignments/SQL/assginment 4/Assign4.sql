--Tql query for factorial

--factorial of 5
declare @fact  int=1
declare @input int=4
	while(@input>1)
		begin
			set @fact=@fact*@input
			set @input=@input-1
		end 
	select @fact as 'Factorial'

	--Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc PrintMultiplicationTable
@Number int,
@multiplierCount int
as
begin
    DECLARE @multiplier int = 1

    WHILE (@Multiplier <= @multiplierCount)
    BEGIN
        PRINT CAST(@Number as varchar(2)) + ' * ' + CAST(@Multiplier as varchar(2)) + ' = ' +
              CAST(@Number * @Multiplier as varchar(5))
        SET @Multiplier = @Multiplier + 1
    END
END


EXEC PrintMultiplicationTable @Number = 5, @multiplierCount = 10


--Create a trigger to restrict data manipulation on EMP table during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate"

CREATE TABLE Employee (
    eID INT PRIMARY KEY,
    eName VARCHAR(30),
    Job VARCHAR(20),
    Salary FLOAT,
)

INSERT INTO Employee 
VALUES
    (101, 'John Smith', 'Manager', 75000.00),
    (102, 'Mary Johnson', 'HR Specialist', 65000.00),
    (103, 'Robert Brown', 'Financial Analyst', 80000.00),
    (104, 'Lisa Williams', 'Marketing', 70000.00),
    (105, 'Michael Davis', ' Supervisor', 90000.00)

CREATE TABLE Holidays (
    HolidayDate DATE,
    HolidayName VARCHAR(50)
)

INSERT INTO Holidays (HolidayDate, HolidayName)
VALUES
    ('2024-04-01', 'April Fools Day'),
    ('2024-07-04', 'Independence Day'),
    ('2024-12-25', 'Christmas Day'),
    ('2025-01-01', 'New Year Day'),
    ('2025-05-01', 'Labor Day')

--for checking the trigger
insert into Holidays values
('2024-03-26','Tuesday'),
('2024-03-27','Wednesday')

create or alter trigger DMLRestriction
on Employee
for insert,update,delete
as
	begin 
	declare @HName varchar(30)
		select @HName=HolidayName from Holidays where convert(date,getdate())=HolidayDate
		if(@HName is not null)
			print'Holiday for '+@Hname+  ' Changes are restricted'
			rollback
	end


INSERT INTO Employee VALUES
(106, 'Nidhi', 'Manager', 75000.00)

