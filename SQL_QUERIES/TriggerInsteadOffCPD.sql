select * from CustomerProductDetails

--TRIGGER INSTEAD OFF

CREATE TRIGGER TriggerInsteadOffCPD
ON CustomerProductDetails
INSTEAD OF INSERT--BEFORE INSERT , UPDATE OR DELETE
AS
BEGIN
declare @CustomerName varchar(20)
--SELECT THE NAME /VALUE OF NAME
select @CustomerName = CustomerName from inserted
--Check the name of Customer
if(LEN(@CustomerName)>=8)
BEGIN 
--when everything is ok, ten insert in 
insert into CustomerProductDetails select * from inserted--deleted
END
END

select * from CustomerProductDetails

insert into CustomerProductDetails (Customerid,CustomerName) values (1001,'ABHI')
insert into CustomerProductDetails (Customerid,CustomerName) values (1001,'ABHISHEK')







select * from EMPLOYEE

select * into NEMPLOYEE from EMPLOYEE-- COPY INTO NEW TABLE ALOGN WITH RECORD























