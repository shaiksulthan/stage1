use CTSDATABASE
select * from  Customer

select * from EMPLOYEE

alter table employee add SALARY int  
select * from EMPLOYEE
--CREATE FUNCTION

create function FunCalAvgSalDeptWise(@DeptId int)
returns int
AS
BEGIN
declare @AvgSal int
select @AvgSal = AVG(SALARY) from EMPLOYEE where DEPTID = @DeptId
return @AvgSal
END

--CALL FUNCTION
print dbo.FunCalAvgSalDeptWise(102)

-- CALLING OF FUNCTION IN SQL STATEMENT
select * from EMPLOYEE 
where SALARY > dbo.FunCalAvgSalDeptWise(101) and DEPTID=101












