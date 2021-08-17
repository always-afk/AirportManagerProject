use AirportDB

go

drop table if exists Tickets
drop table if exists Flights
drop table if exists Clients
drop table if exists Planes
drop table if exists Staff
drop table if exists Positions
drop table if exists Airports
drop table if exists Countries
drop table if exists Lines

go

create table Lines(
	Id int primary key identity(1,1),
	Number int unique not null,
	IsFree bit default 1
)

go

create table Countries(
	Id int primary key identity(1,1),
	[Name] nvarchar(64) unique not null
)

go

create table Airports(
	Id int primary key identity(1,1),
	IATA nvarchar(3) unique not null,
	[Name] nvarchar(128) unique null,
	[CountryId] int references Countries(Id) not null
)

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
	[PositionId] int references Positions(Id) not null,
	[Login] nvarchar(16) unique not null,
	[Password] nvarchar(16) not null
)

go

create table Planes(
	Id int primary key identity(1,1),
	[Name] nvarchar(64) not null,
	[Code] nvarchar(8) unique not null,
	[NumOfSeats] int not null,
	[StaffId] int references Staff(Id) not null
)

go



create table Clients(
	Id int primary key identity(1,1),
	[Name] nvarchar(64) not null,
	[Age] int null
)

go

create table Flights(
	Id int primary key identity(1,1),
	[Date] date not null,
	PlaneId int references Planes(Id),
	DestinationId int references Airports(Id),
	LineId int references Lines(Id)
)

go

create table Tickets(
	Id int primary key identity(1,1),
	[Date] date not null,
	[Price] float not null,
	[ClientId] int references Clients(Id),
	[FlightId] int references Flights(Id)
)

