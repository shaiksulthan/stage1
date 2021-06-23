use GenpactDataBase
--Create Table
create table Employee (EmpID int PRIMARY KEY,EmpName varchar(30),DeptID int)

insert into Employee values(101,'Kritika',1)

select * from Department
--Update query
update Employee set EmpName='Kritika Bhambri' where EmpID=101

ALTER TABLE Employee ADD CONSTRAINT FK_DEPTID FOREIGN KEY(DeptID) 
REFERENCES Department

insert into Employee values(102,'Sandeep',2)

insert into Employee values(104,'Pooja',4)

select * from Employee e,Department d where e.DeptID = d.DeptID

delete from Department where DeptID=3


ALTER TABLE Employee ADD CONSTRAINT FK2_DEPTID FOREIGN KEY(DeptID) 
REFERENCES Department ON DELETE CASCADE
--CREATE VIEW
CREATE VIEW VEmpDetails 
AS
select EmpID,EmpName,e.DeptID,DeptName,DeptLoc from Employee e,Department d where e.DeptID = d.DeptID

select * from VEmpDetails 


insert into Employee values(103,'Vikrant',1)

--Create triggers

create trigger Tri_Insert on Employee for Insert
AS
select * from Employee

insert into Employee values(104,'Ishita',2)

--
create table temp (EmpID int PRIMARY KEY,EmpName varchar(30),DeptID int)


insert into temp select * from Employee

select * from temp



























