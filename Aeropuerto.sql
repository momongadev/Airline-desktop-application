--Crear base de datos
create database Reservaciones

select * from Cliente

--Crear tablas
create table Cliente
(
	clienteId int identity(1,1) not null,
	identificacion varchar(12) not null,
	nombre varchar(50) not null,
	apellido1 varchar(50) not null,
	apellido2 varchar(50) not null,
	genero char(1),
	nacionalidad varchar(50) not null,
	fechaNacimiento date not null,
	usuario varchar(50) not null,
	contrasenia varchar(100) not null,
	tipoUsuario int not null
)

create table Aeropuerto 
(
	aeropuertoId int identity(1,1) not null,
	nombreAeropuerto varchar(100) not null,
	paisId int not null,
)

create table Avion
(
	avionId int identity(1,1) not null,
	capacidad int not null,
	aerolineaId int not null,
	nombre varchar(100) not null
)

create table Aerolinea
(
	aerolineaId int identity(1,1) not null,
	nombre varchar(100) not null
)

create table Itinerario
(
	itinerarioId int identity not null,
	aeropuertoDestinoId int not null,
	aeropuertoOrigenId int not null,
	aerolineaId int not null,
	fechaSalida dateTime not null,
	fechaLlegada dateTime not null,
	Asientos int not null,
	avionId int not null
)

create table Reserva
(
	reservaId int identity(1,1) not null,
	clienteId int not null,
	itinerarioDestinoId int not null,
	itinerarioOrigenId int not null,
	Asientos int not null
)

--Llaves primarias
alter table Reserva add constraint PK_reservaId primary key (reservaId)
alter table Itinerario add constraint Pk_itinerarioId primary key (itinerarioId)
alter table AeroLinea add constraint PK_aerolonineaId primary key (aerolineaId)
alter table Avion add constraint PK_avionId primary key (avionId)
alter table Aeropuerto add constraint PK_aeropuertoId primary key (aeropuertoId)
alter table Cliente add constraint PK_clienteId primary key (clienteId)
alter table Pais add constraint PK_paisId primary key (PaisId)

--Llaves foraneas
alter table Reserva add constraint FK_cliente foreign key (clienteId) references Cliente (clienteId),
						constraint FK_itinerarioDestino foreign key (itinerarioDestinoId) references Itinerario (itinerarioId),
						constraint FK_itinerarioOrigen foreign key (itinerarioOrigenId) references Itinerario (itinerarioId)
alter table Itinerario add constraint FK_aeropuertoDestino foreign key (aeropuertoDestinoId) references Aeropuerto (aeropuertoId),
						   constraint FK_aeropuertoOrigen foreign key (aeropuertoOrigenId) references Aeropuerto (aeropuertoId),
						   constraint FK_aerolinea foreign key (aerolineaId) references Aerolinea (aerolineaId)
alter table Avion add constraint FK_aerolineaId foreign key (aerolineaId) references Aerolinea (aerolineaId)
alter table Aeropuerto add constraint FK_paisId foreign key (paisId) references Pais (PaisId)

--stored procedure
--Aeropuerto
create procedure spInsertarAeropuerto
	@Nombre varchar(100),
	@Pais varchar(100)
as
begin
	insert into Aeropuerto (nombreAeropuerto, pais) values (@Nombre, @Pais)
end
go

create procedure spBuscarAeropuerto
	@aeropuertoId int
as
begin
	select * from Aeropuerto where aeropuertoId = @aeropuertoId
end
go

create procedure spInsertarCliente
	@identificacion varchar(12),
	@nombre varchar(50),
	@apellido1 varchar(50),
	@apellido2 varchar(50),
	@genero char(1),
	@nacionalidad varchar(50),
	@fechaNacimiento date,
	@usuario varchar(50) ,
	@contrasenia varchar(100) ,
	@tipoUsuario int 
as
begin
	insert into Cliente (identificacion, nombre, apellido1, apellido2, genero, nacionalidad, fechaNacimiento, usuario, contrasenia, tipoUsuario) values (@identificacion, @nombre, @apellido1, 
			@apellido2, @genero, @nacionalidad, @fechaNacimiento, @usuario, @contrasenia, @tipoUsuario)
end


create procedure spConsultarCliente
	@usuario varchar(50),
	@contrasenia varchar(50)
as
begin
		select * from Cliente where usuario = @usuario and contrasenia = @contrasenia
end

create procedure spBorrarAeropuerto
	@aeropuertoId int
as
begin
	delete Aeropuerto where aeropuertoId = @aeropuertoId
end
go

create procedure spActualizarAeropuerto
	@Nombre varchar(100),
	@Pais int,
	@aeropuertoId int
as
begin
	update Aeropuerto
	set nombreAeropuerto = @Nombre, paisId = @Pais where aeropuertoId = @aeropuertoId
end
go
--

--Aviones
create procedure spInsertarAvion
	@Capacidad varchar(100),
	@aerolineaId int,
	@Nombre varchar(100)
as
begin
	insert into Avion (capacidad, aerolineaId, nombre) values (@Capacidad, @aerolineaId, @Nombre)
end
go

create procedure spBuscarAvion
	@avionId int
as
begin
	select * from Avion where avionId  = @avionId
end
go

create procedure spBorrarAvion
	@avionId int
as
begin
	delete Avion where avionId = @avionId
end
go

create procedure spActualizarAvion
	@Capacidad varchar(100),
	@avionId int,
	@aerolineaId int,
	@Nombre varchar(100)
as
begin
	update Avion
	set capacidad = @Capacidad, nombre = @Nombre, aerolineaId = @aerolineaId  where avionId = @avionId
end
go
--

--Itinerarios
create procedure spInsertarItinerario
	@aeropuertoDestinoId int,
	@aeropuertoOrigenId int,
	@aerolineaId int,
	@fechaSalida dateTime,
	@fechaLlegada dateTime,
	@asientos int,
	@avionId int
as
begin
	insert into Itinerario(aeropuertoDestinoId, aeropuertoOrigenId, aerolineaId, fechaSalida, fechaLlegada, Asientos, avionId) 
	values (@aeropuertoDestinoId, @aeropuertoOrigenId, @aerolineaId, @fechaSalida, @fechaLlegada, @asientos, @avionId)
end
go

create procedure spBuscarItinerario
	@itinerarioId int
as
begin
	select * from Itinerario where itinerarioId  = @itinerarioId
end
go

create procedure spBorrarItinerario
	@itinerarioId int
as
begin
	delete Itinerario where itinerarioId = @itinerarioId
end
go

create procedure spActualizarItinerario
	@itinerarioId int,
	@aeropuertoDestinoId int,
	@aerpuertoOrigenId int,
	@aerolineaId int,
	@fechaSalida dateTime,
	@fechaLlegada dateTime,
	@asientos int,
	@avionId int
as
begin
	update Itinerario
	set aeropuertoDestinoId = @aeropuertoDestinoId, aeropuertoOrigenId = @aerpuertoOrigenId, aerolineaId = @aerolineaId, fechaSalida = @fechaLlegada,
	Asientos = @asientos, avionId = @avionId
	where itinerarioId = @itinerarioId
end
go

