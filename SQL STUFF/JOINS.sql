use GenpactDataBase

create table tblState(StateId int PRIMARY KEY,CountryID int,StateName varchar(30))
 
insert into tblState values(1,1,'Maharastra')
insert into tblState values(2,1,'Punjab')
insert into tblState values(3,2,'Kathmandu')
insert into tblState values(4,NULL,'California')
select * from tblCountry
select * from tblState
--drop table tblstate

--INNER JOIN
select * from tblCountry inner join tblState
on tblCountry.CountryID=tblState.CountryID
--LEFT JOIN
select * from tblCountry left join tblState
on tblCountry.CountryID=tblState.CountryID

--RIGHT JOIN
select * from tblCountry Right join tblState
on tblCountry.CountryID=tblState.CountryID

--FULL OUTER JOIN

select * from tblCountry full outer join tblState
on tblCountry.CountryID=tblState.CountryID

--Cross Join
select * from tblCountry cross join tblState










