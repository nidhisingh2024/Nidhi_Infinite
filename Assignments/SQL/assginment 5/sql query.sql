use ITclient

create or alter proc Payslip
    @emp_id int,
    @basicsalary int
as
begin
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @TD int
    declare @GS int
    declare @NS int

    -- Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

  -- a) HRA as 10% of Salary
 --  b) DA as 20% of Salary
  -- c) PF as 8% of Salary
  -- d) IT as 5% of Salary
  -- e) Deductions as sum of PF and IT
   --f) Gross Salary as sum of Salary,HRA,DA
  -- g) Net Salary as Gross Salary - Deductions
   -- set @HRA = 0.10 * @BasicSalary
    --set @DA = 0.20 * @BasicSalary
   --set @PF = 0.08 * @BasicSalary
   -- set @IT = 0.05 * @BasicSalary

    --total deduction
    set @TD = @PF + @IT

	--total gross salary
    set @GS = @basicsalary + @HRA + @DA

    -- total net salary
    set @NS = @GS- @TD

    -- Output

    select
        @basicsalary as [basicsalary],
        @HRA as [HRA],
        @DA as [DA],
        @PF as [PF],
        @IT as [IT],
        @TD as [Total Deductions],
        @GS as [Gross Salary],
        @NS as [Net Salary]
end
Exec payslip 101,25000
