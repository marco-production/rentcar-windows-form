Use Rentcar

drop table tipovehiculos
go
drop table combustibles
go
drop table modelos
go
drop table marcas
go
drop table vehiculos
go


create table tipovehiculos
(
id int primary key not null identity(1,1),
nombre varchar(90),
descripcion text, 
estado bit NOT NULL DEFAULT 'true',
)
go
insert into tipovehiculos (nombre,descripcion,estado) values ('Carro','Tipo vehiculo carro','true')
go
insert into marcas (nombre,descripcion,estado) values ('Honda','Marca honda','true')
go
insert into combustibles (nombre,descripcion,estado) values ('Gasolina','Tipo combustible gasolina','true')
go
insert into modelos (nombre,descripcion,marca_id,estado) values ('Accord','Tipo combustible gasolina',2,'true')
go

create table combustibles
(
id int primary key not null identity(1,1),
nombre varchar(90),
descripcion text, 
estado bit NOT NULL DEFAULT 'true',
)
go
create table marcas
(
id int primary key not null identity(1,1),
nombre varchar(90),
descripcion text, 
estado bit NOT NULL DEFAULT 'true',
)
go
create table modelos
(
id int primary key not null identity(1,1),
nombre varchar(90),
descripcion text, 
marca_id int,
estado bit NOT NULL DEFAULT 'true',
constraint fk_marca_modelo foreign key(marca_id) references marcas on delete cascade
)
go
create table clientes
(
id int primary key not null identity(1,1),
full_name varchar(90),
cedula varchar(60), 
numero_cr varchar(60),
limite_credito varchar(90),
tipo varchar(90),
estado bit NOT NULL DEFAULT 'true',
)
go
insert into clientes (full_name,cedula,numero_cr,limite_credito,tipo,estado) values ('Marco Antonio','32313213','1111','32425','F�sica','true')
go
select modelos.id, modelos.nombre, modelos.descripcion, marcas.nombre AS marca, modelos.estado FROM modelos inner join marcas on modelos.marca_id = marcas.id
go
create table vehiculos
(
id int primary key not null identity(1,1),
descripcion text,
chasis varchar(60), 
motor varchar(60),
placa varchar(60),
anio int,
tipo_vehiculo_id int,
marca_id int,
modelo_id int,
combustible_id int,
estado bit NOT NULL DEFAULT 'true',

constraint fk_tipo_vehiculo foreign key(tipo_vehiculo_id) references tipovehiculos on delete cascade,
constraint fk_marca_vehiculo foreign key(marca_id) references marcas on delete cascade,
constraint fk_modelo_vehiculo foreign key(modelo_id) references modelos on delete cascade,
constraint fk_tipo_combustible_vehiculo foreign key(combustible_id) references combustibles on delete cascade
)
go
ALTER TABLE vehiculos DROP COLUMN vehiculo
go
alter table vehiculos add vehiculo varchar(120) NULL
go
create table roles
(
id int primary key not null identity(1,1),
nombre varchar(90),
)
go
insert into roles values ('Administrador');
insert into roles values ('Empleado');
go
create table empleados
(
id int primary key not null identity(1,1),
full_name varchar(90),
email varchar(60), 
cedula varchar(60),
tanda varchar(60),
comision varchar(60),
fecha_ingreso date,
pass varchar(60),
role_id int,
estado bit NOT NULL DEFAULT 'true',

constraint fk_empleado_role foreign key(role_id) references roles on delete cascade
)
go
create table rentas
(
id int primary key not null identity(1,1),
fecha_renta date,
fecha_devolucion date,
monto int,
dias int,
comentario text,
empleado_id int,
vehiculo_id int,
cliente_id int,
estado bit NOT NULL DEFAULT 'true',

constraint fk_renta_empleado foreign key(empleado_id) references empleados on delete cascade,
constraint fk_renta_vehiculo foreign key(vehiculo_id) references vehiculos on delete cascade,
constraint fk_renta_cliente foreign key(cliente_id) references clientes on delete cascade
)

create table inspeccions
(
id int primary key not null identity(1,1),
ralladura bit DEFAULT 'false',
combustible varchar(60),
goma_repuesto bit DEFAULT 'false',
gato bit DEFAULT 'false',
rotura_cristal bit DEFAULT 'false',
goma_superior_izquierda bit DEFAULT 'false',
goma_superior_derecha bit DEFAULT 'false',
goma_inferior_izquierda bit DEFAULT 'false',
goma_inferior_derecha bit DEFAULT 'false',
fecha_inspeccion date,
empleado_id int,
renta_id int,
estado bit NULL DEFAULT 'true',

constraint fk_inspeccion_empleado foreign key(empleado_id) references empleados on delete cascade,
constraint fk_inspeccion_renta foreign key(renta_id) references rentas on delete cascade,
)

SELECT id, full_name, email, cedula, tanda, comision, fecha_ingreso, pass, role_id, estado, { fn CONCAT(full_name + ' ( ', email + ' )') } AS full_name
FROM empleados
WHERE (estado = 1)

SELECT id, full_name, cedula, estado, { fn CONCAT(full_name + ' ( ', cedula + ' )') } AS full_name
FROM clientes
WHERE (estado = 1)

SELECT vehiculos.id AS id, vehiculos.descripcion AS descripcion, vehiculos.placa AS placa, vehiculos.chasis AS chasis, vehiculos.anio AS anio, vehiculos.tipo_vehiculo_id AS tipo_vehiculo_id, vehiculos.marca_id AS marca_id, vehiculos.modelo_id AS modelo_id, vehiculos.combustible_id AS combustible_id, vehiculos.estado AS estado, { fn CONCAT(marcas.nombre + ' ', modelos.nombre + ' ' + convert(varchar,vehiculos.anio)) } AS vehiculo 
FROM vehiculos inner join marcas on vehiculos.marca_id = marcas.id inner join modelos on vehiculos.modelo_id = modelos.id
WHERE (vehiculos.estado = 1)

/*FillByNombreMarca*/
SELECT modelos.id, modelos.nombre, modelos.descripcion, marcas.nombre AS marca, modelos.estado FROM modelos inner join marcas on modelos.marca_id = marcas.id


/*FillByFilterAll*/
SELECT id, fecha_renta, fecha_devolucion, monto, dias, comentario, empleado_id, vehiculo_id, cliente_id, estado
FROM rentas
WHERE (empleado_id = 4) AND  (fecha_renta >= '2019-06-12') AND (fecha_devolucion <= '2021-06-12')

SELECT rentas.id, rentas.fecha_renta, rentas.fecha_devolucion, { fn CONCAT('RD$ ' ,CAST(rentas.monto * rentas.dias AS VARCHAR)) } AS monto, rentas.comentario, empleados.full_name AS empleado_id, vehiculos.vehiculo AS vehiculo_id, clientes.full_name AS cliente_id, rentas.estado
FROM rentas 
inner join empleados on rentas.empleado_id = empleados.id
inner join vehiculos on rentas.vehiculo_id = vehiculos.id 
inner join clientes on rentas.cliente_id = clientes.id

SELECT empleados.id, full_name, email, cedula, tanda, comision, fecha_ingreso, pass, roles.nombre AS role_id, estado 
FROM dbo.empleados
inner join roles on empleados.role_id = roles.id