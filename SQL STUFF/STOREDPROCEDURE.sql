--STORED PROCEDURE
use GenpactDataBase
select * from Employee
--NON PARMETERIZED PROCEDURE
create procedure PEmployeeDetails
AS
BEGIN
select * from Employee
END
--EXECUTION OF STORED PROCEDURE
EXEC PEmployeeDetails
--PARMETERIZED PROCEDURE

create procedure PPEmployeeDetails
@EmpID int
AS
BEGIN
select * from Employee where EmpID=@EmpID
END

EXEC PPEmployeeDetails 103
--TWO PARMETERIZED PROCEDURE
CREATE procedure P2PEmployeeDetails
@EmpID int,
@EmpName varchar(30)
AS
BEGIN
select * from Employee where EmpID=@EmpID and EmpName=@EmpName
END

EXEC P2PEmployeeDetails 103,'Vikrant'
