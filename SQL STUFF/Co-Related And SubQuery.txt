use GenpactDataBase
--EmpSal
create table EmpSal(ID int PRIMARY KEY,Name varchar(30),Salary int)
select * from EmpSal
insert into EmpSal values(1,'Vikrant',100)
insert into EmpSal values(2,'Anurag',150)
insert into EmpSal values(3,'Ankita',200)
insert into EmpSal values(4,'Vanya',300)
--EmpInfo
create table EmpInfo(FKID int,PhoneNumber varchar(15),Address varchar(50))
 insert into EmpInfo values(1,'98989','Delhi')
 insert into EmpInfo values(2,'8888888','Kanpur')
 insert into EmpInfo values(3,'909090','WDelhi')
 insert into EmpInfo values(4,'20202','MP')
 
 select * from EmpInfo
 
 --SUB QUERY
 --select * from EmpInfo
 --select * from EmpSal
 
 select * from EmpInfo --Outer Query
 where
 FKID in (select ID from EmpSal where Salary > 150)--Inner Query
 
 --CO_RELATED
 select * from EmpInfo
 select * from EmpSal
 select * from EmpSal e1--Outer Query
 where 2 =
 (Select COUNT(e2.Salary)--Inner Query
 from EmpSal e2 where e2.Salary >= e1.Salary)
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
