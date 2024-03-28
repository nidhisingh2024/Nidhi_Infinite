create database Assginment_2
use Assessment_2
use Exercise_2
CREATE TABLE Mytable (
    Name VARCHAR(30),
    dob DATE
);


insert into Mytable
values 
('Akash', '2002-03-24'),
('Ishita', '1988-05-18'),
('Rajesh', '1977-12-03');


--first question
select DATENAME(dw, dob) 
from Mytable 
where dob = '2002-03-24';

--output
--sunday


--second question
select DATEDIFF(dd, '2002-03-24', getdate()) as AgeInDays;
--output
--8040

--third question
create table Employees
(
    Empno numeric(4) unique,
    Ename varchar(20),
    Job varchar(20),
    Mgr_id numeric(4),
    hiredate date, 
    salary numeric(6),
    comm numeric(4),
    deptno numeric(2) foreign key references Department(Deptno)
);


Insert into Employees values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-04-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);

select *
from Employees
where datediff(yy,hiredate,getdate())>5 


  --fourth question

  CREATE TABLE Employee_data
(
    empno numeric(4) PRIMARY KEY,
    ename varchar(20),
    sal numeric(10, 2),
    doj date
);

INSERT INTO Employee_data(empno, ename, sal, doj)
VALUES
    
(7369, 'SMITH', 7902, '1980-12-17'),
(7499, 'ALLEN' ,7698, '1981-02-20'),
(7521, 'WARD', 7698, '1981-02-22'),
(7566, 'JONES',7839, '1981-04-02'),
(7654, 'MARTIN',7698, '1981-09-28'),
(7698, 'BLAKE' ,7839, '1981-05-01');

begin transaction

delete from Employee_data
where empno = 7499;
select *from Employee_data

rollback transaction

UPDATE Employee_data
SET sal = sal * 1.15
WHERE empno = 7521;


select *from Employee_data

