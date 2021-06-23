use GenpactDataBase

select * from Employee

alter table Employee add Salary int

create FUNCTION FunCalAvgSal(@DeptID int)
RETURNS int
AS
BEGIN 
DECLARE @SalAvg int
select @SalAvg=AVG(Salary) from Employee where DeptID=@DeptID
RETURN @SalAvg
END

select * from Employee 
where Salary>=dbo.FunCalAvgSal(1) and DeptID=1

declare @avgSal int
--DIRECT CALLING PARAMETER
EXEC @avgSal=FunCalAvgSal 1
PRINT @avgSal





