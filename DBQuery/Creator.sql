use AirportDB

go

drop table if exists Tickets
drop table if exists Flights
drop table if exists Clients
drop table if exists Planes
drop table if exists Users
drop table if exists Staff
drop table if exists Positions
drop table if exists Countries

go

--create table Countries(
--	Id int primary key identity(1,1),
--	[Name] nvarchar(64) unique not null
--)

go

create table Positions(
	Id int primary key identity(1,1),
	[Name] nvarchar(32) unique not null
)

go

create table Staff(
	Id int primary key identity(1,1),
	[Name] nvarchar(128) unique not null,
	[Age] int,
	[PositionId] int references Positions(Id) not null
)

go

create table Users(
	Id int primary key references Staff(Id),
	[Login] nvarchar(16) unique not null,
	[Password] nvarchar(16) not null
)

go

create table Planes(
	Id int primary key identity(1,1),
	[Name] nvarchar(64) not null,
	[NumOfSeats] int not null,
	[StaffId] int references Staff(Id) null
)

go



--create table Clients(
--	Id int primary key identity(1,1),
--	[Name] nvarchar(64) not null,
--	[Age] int null
--)

go

create table Flights(
	Id int primary key identity(1,1),
	[Date] datetime not null,
	PlaneId int references Planes(Id),
	Destination nvarchar(64),
)

go

--create table Tickets(
--	Id int primary key identity(1,1),
--	[Date] datetime not null,
--	[Price] float not null,
--	[ClientId] int references Clients(Id),
--	[FlightId] int references Flights(Id)
--)

go

insert Positions values
('Admin'),
('Pilot')

go

insert Staff values
('Admin', 0, 1),
('Pilot', 0, 2)

go

insert Users values
(1, 'admin', 'admin'),
(2, 'pilot', 'pilot')