select * from EMPLOYEE

--CREATE PROCEDURE WITH OUTPUT TYPE PARAMETER

create procedure spouttypeselectEmployee
--add parameter to this procedure
@EmpID int,--INPUT PARAMETER
@EmpName varchar(30),--INPUT PARAMETER
@CurrentDateTime datetime output  --OUT PUT PARAMETER
AS
BEGIN
	set @CurrentDateTime = GETDATE()
	select * from tblEmployee where EmpID = @EmpID and  EmpName = @EmpName
	return @@rowcount
	 
END

SELECT * FROM tblEmployee

--CALL PROCEDURE
declare @DateTimeCurrent datetime
declare @RowCount int
EXEC @RowCount = spouttypeselectEmployee 1003,'GOURAV',@DateTimeCurrent OUTPUT
print @DateTimeCurrent
print @RowCount

PRINT @@rowcount