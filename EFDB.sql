
create database joinExDb
use joinExDb

drop database joinExDb

create table Depts
(DId int primary key,
DName nvarchar(50) not null unique)
insert into Depts values (1,'App-Development')
,(2,'Web-Development'),(3,'HR'),(4,'Account'),(5,'Agile-Scrum')

select * from Depts order by DId 

create table Emps(Id int primary key,Fname nvarchar(50) not null,
Lname nvarchar(50) not null,Designation nvarchar(50),
Salary float,
DId int foreign key references Depts)

insert into Emps values(1,'Ajay','Kumar','Developer',87000.90,2),(2,'vijay','kiran','Developer',87000.90,1),
(3,'Nishi','Vats','Developer',87000.90,1)

insert into Emps(Id,Fname,Lname,Salary) values (4,'Raj','Kiran',88000.50)
insert into Emps values (12,'Deep','Goyal','Developer',86000.30,2)
insert into Emps(Id,Fname,Lname,Designation,Salary) values (13,'Naina','Viz','Manager',67000.90)

select * from Emps

select * from Depts