
CREATE VIEW V_EMPLOYEEDEPTINFO
AS
select e.EMPID,e.EMPNAME,EMPDESG,e.DEPTID,d.DEPTNAME,d.DEPTLOC from EMPLOYEE e, DEPARTMENT d
where e.DEPTID=d.DEPTID

select * from V_EMPLOYEEDEPTINFO

--CREATE VIEW WITH SELECT ON DEPARTMENT TABLE
create view VtblDepartment
as
select * from DEPARTMENT

select * from VtblDepartment

--INSERT AND UPDATE ONLY WHEN VIEW WILL HAVE SINGLE TABLE

sp_help DEPARTMENT

insert into VtblDepartment values ('DEVLOPMENT','KOLKATA')

sp_helptext  VtblDepartment


create view VEtblDepartment
WITH ENCRYPTION
as
select * from DEPARTMENT

sp_helptext  VEtblDepartment

ALTER view VEtblDepartment
as
select * from DEPARTMENT

--ROW HIDING 
Create view VRHtblHRDepartment
as
select * from DEPARTMENT where DeptId=102

select * from VRHtblHRDepartment

create view VSBDEPARTMENT
WITH SCHEMABINDING
as
select DEPTID,DEPTNAME,DEPTLOC from dbo.DEPARTMENT

drop table DEPARTMENT

select * from Customer

create view VSBCUSTOMER
WITH SCHEMABINDING
as
select CustomerID,CustomerName,CustomerAmount,CustomerType from dbo.Customer

drop table dbo.Customer










