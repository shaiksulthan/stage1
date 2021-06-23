use GenpactDataBase

ALTER PROCEDURE SelectCustomer
--Add the parameters for the stored procedure
@CustomerId int,--Input parameter
@CustomerName varchar(30),--Input parameter
@CurrentDateTime datetime output
AS
BEGIN
	set @CurrentDateTime=GETDATE()
	select * from tblCustomer where CustomerName=@CustomerName
	and CustomerId=@CustomerId
	return @@rowcount
END
GO

declare @myrowcount int
declare @DateTimeCurrent datetime
EXEC @myrowcount=dbo.SelectCustomer 2,'neha',@DateTimeCurrent output
PRINT @DateTimeCurrent 
PRINT @myrowcount

SELECT DateTimeCurrent=@DateTimeCurrent 
SELECT myrowcount=@myrowcount



