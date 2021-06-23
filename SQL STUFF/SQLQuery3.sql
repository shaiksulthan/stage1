-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER TrigInsteadOf
ON dbo.tblCustomer
	instead of INSERT
AS 
BEGIN
	declare @CustomerName varchar(50)
	--Selecr the values
	select @CustomerName=CustomerName from inserted
	--check of the customer name value
	if(len(@CustomerName)<>0)
	begin
	--Everything fine insert it
	insert into tblCustomer select * from inserted
	end
END

