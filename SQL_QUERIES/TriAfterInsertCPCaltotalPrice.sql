use CTSDATABASE

create trigger TriAfterInsertCPCaltotalPrice
ON CustomerProductDetails
AFTER INSERT
AS
BEGIN
  declare @CustomerId int
  select @CustomerId = CustomerId from inserted
  update CustomerProductDetails set TotalPurchasePrice = ProductPrice * PurchaseQTY
  where CustomerId = @CustomerId
END

insert into CustomerProductDetails 
(Customerid,CustomerName,ProductName,ProductPrice,PurchaseQTY) 
values (1002,'MAHANTESH','LAPTOP',25000,2)

select * from CustomerProductDetails






