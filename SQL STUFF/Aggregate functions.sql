use GenpactDataBase

create table tblCountry(CountryID int PRIMARY KEY,CountryName varchar(30),Population int,Year int)
insert into tblCountry values(1,'India',1000,1990)
insert into tblCountry values(2,'Nepal',200,1990)
insert into tblCountry values(3,'India',1500,1991)
insert into tblCountry values(4,'Srilanka',500,1990)
insert into tblCountry values(5,'Nepal',400,1991)
insert into tblCountry values(7,'India',2000,1992)
insert into tblCountry values(8,'Nepal',600,1993)
insert into tblCountry values(6,'India',1050,1990)

select * from tblCountry

--Aggregate functions
select
SUM(Population)as TOT_POPULATION,
MAX(Population)as MAXPOP,
MIN(Population)as MINPOP,
AVG(Population)as AVGPOP,
COUNT(*) as COUNTROW--TOTAL NO, OF RECORDS
from tblCountry
--GROUP BY ON COUNTRY NAME WITH POPULATION
select CountryName,Year,SUM(Population)
from tblCountry
group by CountryName,Year
--
select CountryName,SUM(Population) 
from tblCountry
Group by CountryName
having SUM(Population) > 1000





