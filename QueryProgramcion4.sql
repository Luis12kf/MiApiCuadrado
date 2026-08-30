CREATE TABLE tblEstudiante (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Matricula VARCHAR(20) UNIQUE NOT NULL,
    Cedula VARCHAR(13) UNIQUE NOT NULL,
    Nombre VARCHAR(40) NOT NULL,
    Apellido VARCHAR(40) NOT NULL,
    Fecha_Nacimiento DATE NULL,
    Fecha_Ingreso DATE NOT NULL,
    Ocupacion VARCHAR(50) NULL, -- Se removió UNIQUE para evitar errores al repetir ocupaciones
    Nacionalidad VARCHAR(250) NULL,
    Telefono VARCHAR(16) NULL,
    Email VARCHAR(256) NULL,
    Direccion VARCHAR(300) NULL, -- Corregido typo: Dirrecion -> Direccion
    Carrera VARCHAR(100) NOT NULL
);
INSERT INTO tblEstudiante (
    Matricula, 
    Cedula, 
    Nombre, 
    Apellido, 
    Fecha_Nacimiento, 
    Fecha_Ingreso, 
    Ocupacion, 
    Nacionalidad, 
    Telefono, 
    Email, 
    Direccion, 
    Carrera
)
VALUES 
(
    '2024-0001', 
    '402-0000000-1', 
    'Luis Manuel', 
    'Pérez', 
    '2002-05-14', 
    '2024-01-15', 
    'Estudiante', 
    'Dominicana', 
    '809-555-0101', 
    'luis.perez@example.com', 
    'Calle Principal #12, La Vega', 
    'Licenciatura en Informática'
),
(
    '2024-0002', 
    '402-0000000-2', 
    'Maria', 
    'Gómez', 
    '2001-11-20', 
    '2024-01-15', 
    'Empleado', 
    'Dominicana', 
    '809-555-0102', 
    'maria.gomez@example.com', 
    'Av. Pedro A. Rivera #45, La Vega', 
    'Ingeniería de Software'
),
(
    '2024-0003', 
    '402-0000000-3', 
    'Carlos', 
    'Rodríguez', 
    '2003-03-08', 
    '2024-08-20', 
    'Estudiante', 
    'Dominicana', 
    '829-555-0103', 
    'carlos.rodriguez@example.com', 
    'Calle Sol #8, Santiago', 
    'Licenciatura en Informática'
);