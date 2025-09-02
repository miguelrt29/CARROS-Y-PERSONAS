-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS MiBase;
USE MiBase;

-- Tabla Personas
CREATE TABLE IF NOT EXISTS Personas (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Documento VARCHAR(50) NOT NULL,
    Telefono VARCHAR(20) NOT NULL
);

-- Tabla Carros
CREATE TABLE IF NOT EXISTS Carros (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Placa VARCHAR(20) NOT NULL,
    Marca VARCHAR(50) NOT NULL,
    Modelo VARCHAR(50) NOT NULL
);
 select * from personas;
 select * from carros;