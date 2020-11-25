CREATE DATABASE SISTEMAFLETESACARREOS
USE SISTEMAFLETESACARREOS

CREATE TABLE CHOFER (
lICENCIA_C int,
N_Chofer Varchar(30),
ApellidoP_C Varchar(30),
ApellidoM_C Varchar(30),
Sexo char(1),
Edad INT,
Telefono INT,
Correo Varchar(30),
F_Nac Date,
Primary Key (LICENCIA_C)
)


CREATE TABLE AUTOS (
Num_Placas int,
Marca Varchar(20),
Kilometraje Int,
Cap_A Int,
PRIMARY KEY (Num_Placas)
)

CREATE TABLE MATERIALES (
Codigo Int, 
Nombre_M Varchar(30),
Precio Int,
PRIMARY KEY(Codigo)
)

CREATE TABLE KILOMETRO (
Id_Kilometro int,
Precio Int,
Precio_nuevo Int,
PRIMARY KEY (Id_Kilometro)
)

CREATE TABLE FACTURA (
Boleta_no Int,
Maquina Int,
Fecha date,
Hora Time,
Materiales Varchar(50),
Total_metros Int,
Total_viajes Int,
PP_Metro Int,
Subtotal Int,
IVA Int,
Total int,
Fact_material int,
Fact_licencia int,
Fact_placas int,
Fact_Kilometro Int,
PRIMARY KEY (Boleta_no),
FOREIGN KEY(Fact_material) references MATERIALES (Codigo),
FOREIGN KEY(Fact_material) references CHOFER (Licencia_C),
FOREIGN KEY (Fact_placas) references AUTOS (Num_Placas),
FOREIGN KEY (Fact_kilometro) references KILOMETRO (Id_Kilometro)
)
