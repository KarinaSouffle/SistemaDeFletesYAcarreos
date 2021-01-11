CREATE DATABASE SISTEMAFLETESACARREOS
USE SISTEMAFLETESACARREOS

CREATE TABLE CHOFER (
Id_Chofer Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
lICENCIA_C Int,
N_Chofer Varchar(30),
ApellidoP_C Varchar(30),
ApellidoM_C Varchar(30),
Sexo char(1),
Edad INT,
Telefono Varchar(30),
Correo Varchar(30),
F_Nac Date,
Direccion Varchar(30)
)


CREATE TABLE AUTOS (
Id_Autos Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Num_Placas Varchar(30),
Marca Varchar(20),
Kilometraje Int,
Cap_A Int
)

CREATE TABLE MATERIALES (
Codigo Int NOT NULL IDENTITY (1,1) PRIMARY KEY, 
Nombre_M Varchar(30),
Precio Int
)

CREATE TABLE KILOMETRO (
Id_Kilometro Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Precio Int
)

CREATE TABLE FACTURA (
Boleta_no Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
Maquina Int,
Fecha Varchar(10),
Hora Varchar(15),
Materiales Varchar(50),
Total_metros Int,
Total_viajes Int,
Subtotal Int,
IVA Int,
Total int,
Fact_material int,
Fact_licencia int,
Fact_placas int,
Fact_Kilometro Int,
FOREIGN KEY(Fact_material) references MATERIALES (Codigo),
FOREIGN KEY(Fact_licencia) references CHOFER (Id_Chofer),
FOREIGN KEY (Fact_placas) references AUTOS (Id_Autos),
FOREIGN KEY (Fact_kilometro) references KILOMETRO (Id_Kilometro)
)

CREATE TABLE USUARIOS(
Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(20) NOT NULL,
Contra varchar(20) NOT NULL,
Nivel char(1) NOT NULL,
EnUso char(1)
)

