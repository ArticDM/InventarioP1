/*

create table INVENTARIO(
	ID_INV int NOT NULL IDENTITY PRIMARY KEY,
	CODIGO int,
	DESCRIP varchar(35) NOT NULL,
	MARCA varchar(35),
	MODELO varchar(50),
	SERIE varchar(50),	
	ID_RESP int,
	FECHA_ING datetime,
	ESTATUS varchar(15) NOT NULL DEFAULT 'ACTIVO',
	NOTAS varchar(max))

create table RESPONSABLE(
	ID_RESP int NOT NULL PRIMARY KEY,
	NOMBRE varchar(40) NOT NULL,
	AREA varchar(20) NOT NULL,
	ESTATUS varchar(15) NOT NULL DEFAULT 'ACTIVO')
*/

create table INV_RESP(
	ID_RESP int NOT NULL,
	FECHA_ENT datetime,
	FECHA_DEV datetime,
	RESPONSIVA varchar(50),
	NOTAS varchar(max))


create table MANTENIMIENTOS(
	ID_INV int NOT NULL,
	FECHA_MAN datetime,
	ENCARGADO varchar(40),
	NOTAS varchar(max))