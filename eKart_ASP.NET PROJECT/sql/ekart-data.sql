-- Include table data insertion, updation, deletion and select scripts
--Product Details:
insert into product (pr_title,pr_price,pr_in_stock,pr_date_of_expiry,pr_category,pr_free_delivery) values ('Redmi 6 Pro', 8999.00, '1', '2028-12-23', 'Smart Phones', '1');
insert into product (pr_title,pr_price,pr_in_stock,pr_date_of_expiry,pr_category,pr_free_delivery) values ('Pringles Potato Chips 110g', 97.99, '1', '2019-08-21', 'Snacks', '0');
insert into product (pr_title,pr_price,pr_in_stock,pr_date_of_expiry,pr_category,pr_free_delivery) values ('Samsung 43 LED Smart TV', 45999.00, '0', '2031-07-02', 'Electronics', '1');
insert into product (pr_title,pr_price,pr_in_stock,pr_date_of_expiry,pr_category,pr_free_delivery) values ('Nikon D5600 DSLR', 48199.00, '1', '2031-07-06', 'Electronics', '1');
GO
--User Details:
insert into [user] (us_name) values ('John');
insert into [user] (us_name) values ('Alexa');
GO
--1.	View Product List Admin (EKUC001)
select * from product;
GO
--2.	View Product List Customer (EKUC002)
select * from product where pr_in_stock = 1 and pr_date_of_expiry > (select getdate());
GO
--3.	Edit Product (EKUC003)
select * from product where pr_id = 1;
GO

update product set pr_title='Redmi 7 Pro', pr_price=8999.00, pr_in_stock=1, pr_date_of_expiry='2028-12-24', pr_category='Smart Phoness', 
pr_free_delivery = 1 where pr_id=1;
GO
--4.	Add to Cart (EKUC004)
insert into cart (ct_us_id,ct_pr_id) values (1, 1);
insert into cart (ct_us_id,ct_pr_id) values (1, 2);
insert into cart (ct_us_id,ct_pr_id) values (1, 3);
GO
--5.	View Cart (EKUC005)
select * from cart where ct_us_id = 1;
select sum(pr_price) as Total from product, cart where cart.ct_pr_id = product.pr_id;
GO
--6.	Remove Item from Cart (EKUC006)
delete from cart where ct_us_id=1 and ct_pr_id=3 ;
GO