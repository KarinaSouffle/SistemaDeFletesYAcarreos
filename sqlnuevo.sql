CREATE DATABASE SISTEMAFLETESACARREOS
USE SISTEMAFLETESACARREOS

CREATE TABLE CHOFER (
Id_Chofer Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
lICENCIA_C Varchar(13) NOT NULL,
N_Chofer Varchar(30) NOT NULL,
ApellidoP_C Varchar(30) NOT NULL,
ApellidoM_C Varchar(30) NOT NULL,
Sexo char(1) NOT NULL,
Edad Varchar(2) NOT NULL,
Telefono Varchar(30) NOT NULL,
Correo Varchar(30) NOT NULL,
F_Nac Date NOT NULL,
Direccion Varchar(30) NOT NULL,
Disponible char(1) NOT NULL
)


CREATE TABLE AUTOS (
Id_Autos Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Num_Placas Varchar(6),
Marca Varchar(20),
Kilometraje Varchar(9),
Cap_A Varchar(9) NOT NULL,
Disponible Char(1) NOT NULL
)

CREATE TABLE MATERIALES (
Codigo Int NOT NULL IDENTITY (1,1) PRIMARY KEY, 
Nombre_M Varchar(30) NOT NULL,
Precio Varchar(9) NOT NULL
)

CREATE TABLE KILOMETRO (
Id_Kilometro Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Precio Varchar(9) NOT NULL
)

CREATE TABLE FACTURA (
Boleta_no Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Num_Factura Int NOT NULL,
Fecha Varchar(10) NOT NULL,
Hora Varchar(15) NOT NULL,
Materiales Varchar(50) NOT NULL,
Total_metros Varchar(12) NOT NULL,
Total_viajes float NOT NULL,
Total_Kilometros float NOT NULL,
Subtotal float NOT NULL,
IVA float NOT NULL,
Total float NOT NULL,
Fact_material int NOT NULL,
Fact_licencia Varchar(13) NOT NULL,
Fact_placas Varchar(6) NOT NULL,
Fact_Kilometro Varchar(9) NOT NULL
)

CREATE TABLE USUARIOS(
Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(20) NOT NULL,
Contra varchar(20) NOT NULL,
Nivel char(1) NOT NULL,
EnUso char(1) NOT NULL
)

