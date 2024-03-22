use Exercise_2
select * from Employees
select * from Department


--Using assginment 2 table data for assginment 3 questions

--Question 1
--Retrieve a list of MANAGERS.
select Ename, salary from Employees 
where job = 'Manager'

--Question 2
-- names and salaries of all employees earning more than 1000 per month
select Ename, salary from Employees
where salary > 1000


--Question 3
-- names and salaries of all employees except JAMES:
select Ename, salary from Employees 
where Ename != 'James'

--Question 4
--Find out the details of employees whose names begin with ‘S’

select * from Employees
where Ename like 'S%'

--Question 5
--Find out the names of all employees that have ‘A’ anywhere in their name
select Ename from Employees 
where Ename like '%a%'

--Question 6
--Find out the names of all employees that have ‘L’ as their third character in their name
select * from Employees 
where Ename like '__L%'

--Question 7
--Compute the daily salary of JONES

select Ename, salary as MonthlySal, salary/30 as DailySal 
from Employees 
where Ename = 'Jones'

--Question 8
--Calculate the total monthly salary of all employees
select sum(salary) as totalSal 
from Employees

--Question 9
--Print the average annual salary
select avg(salary*12) as 'Average Annual Salary' 
from Employees

--Question 10
--Select the name, job, salary, and department number of all employees except SALESMAN from department number 30
select Ename,job,salary,deptno 
	from Employees
		where job not like 'Salesman' 
			and deptno  not like 30


--Question 11
--List unique departments of the EMP table
select distinct deptno from Employees

--Question 12
--List the name and salary of employees who earn more than 1500 and are in department 10 or 30
select Ename as Employee, salary as 'Monthly Salary', deptno as Department
from Employees
where salary > 1500 and deptno in (10, 30);


--Question 13
--Display the name, job, and salary of all employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000
select Ename, job, salary
from Employees
where job in ('Manager', 'Analyst') and salary not in (1000, 3000, 5000);

--Question 14
--Display the name, salary, and commission for all employees whose commission amount is greater than their salary increased by 10%
select Ename, salary as 'Old Salary', comm as 'Commission', (salary * 1.10) as '10% Hike'
from Employees
where salary < comm;

--Question 15
--Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782
select Ename
from Employees
where Ename like '%l%l%' and (deptno = 30 or Mgr_id = 7782);

--Question 16
--Display the names of employees with experience of over 30 years and under 40 years
select Ename
from Employees
where DATEDIFF(yy, hiredate, getdate()) between 30 and 40;

--Question 17
--Retrieve the names of departments in ascending order and their employees in descending order
select dname, ename
from Employees
join Department on Department.deptno = Employees.deptno
order by dname asc, ename desc;

--Question18
--Retrieve the names of departments in ascending order and their employees in descending order
select dname, ename
from Employees
join Department on Department.deptno = Employees.deptno
order by dname asc, ename desc;

