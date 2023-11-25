CREATE DATABASE FARMACIA_BUENA__SALUD

USE FARMACIA_BUENA__SALUD
-- Crear la tabla Cliente
CREATE TABLE Cliente (
    idCliente INT IDENTITY PRIMARY KEY,
    nombreCliente VARCHAR(255) NOT NULL,
    correoElectronico VARCHAR(255) NOT NULL,
    númeroTelefónico VARCHAR(20) NOT NULL
);

-- Crear la tabla TarjetaCredito
CREATE TABLE TarjetaCredito (
    idTarjeta INT IDENTITY PRIMARY KEY,
    idCliente INT NOT NULL,
    numeroTarjeta VARCHAR(16) NOT NULL,
    nombrePropietario VARCHAR(255) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente)
);

-- Crear la tabla Rol
CREATE TABLE Rol (
    idRol INT IDENTITY PRIMARY KEY,
    nombreRol VARCHAR(255) NOT NULL
);

-- Crear la tabla Empleado
CREATE TABLE Empleado (
    idEmpleado INT IDENTITY PRIMARY KEY,
    idRol INT NOT NULL,
    nombreEmpleado VARCHAR(255) NOT NULL,
    estadoLaboral VARCHAR(255) NOT NULL,
    salario DECIMAL(10, 2) NOT NULL,
	empleadoPassword VARBINARY(128) NOT NULL,
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);


-- Crear la tabla Venta
CREATE TABLE Venta (
    idVenta INT IDENTITY PRIMARY KEY,
    idCliente INT NOT NULL,
    idEmpleado INT NOT NULL,
    tipoVenta VARCHAR(255) NOT NULL,
    fechaVenta DATE NOT NULL,
    total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado)
);

-- Tabla Categoria
CREATE TABLE Categoria (
    idCategoria INT IDENTITY PRIMARY KEY,
    nombreCategoria VARCHAR(255) NOT NULL
);


-- Tabla Producto
CREATE TABLE Producto (
    idProducto INT IDENTITY PRIMARY KEY,
    nombreProducto VARCHAR(255) NOT NULL,
    CantidadStock INT NOT NULL,
    idCategoria INT,
    precioProducto DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);


-- Crear la tabla DetalleVenta
CREATE TABLE DetalleVenta (
    idDetalle INT IDENTITY PRIMARY KEY,
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidadProducto INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idVenta) REFERENCES Venta(idVenta),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);





-- Tabla Proveedor
CREATE TABLE Proveedor (
    idProveedor INT IDENTITY PRIMARY KEY,
    nombreProveedor VARCHAR(255) NOT NULL,
    telefonoProveedor VARCHAR(20) NOT NULL
);





-- Tabla Compra
CREATE TABLE Compra (
    idCompra INT IDENTITY PRIMARY KEY,
    idProveedor INT NOT NULL,
    tipoCompra VARCHAR(50) NOT NULL,
    fechaCompra DATE NOT NULL,
    totalCompra DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor)
);

-- Tabla DetalleCompra
CREATE TABLE DetalleCompra (
    idDetalleCompra INT IDENTITY PRIMARY KEY,
    idCompra INT NOT NULL,
    idProducto INT NOT NULL,
    cantidadProducto INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idCompra) REFERENCES Compra(idCompra),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);


-- Crear la vista de productos más vendidos
CREATE VIEW VistaProductosMasVendidos AS
SELECT
    p.idProducto,
    p.nombreProducto AS Nombre,
    COUNT(dv.idProducto) AS CantidadVendida
FROM
    DetalleVenta dv
JOIN
    Producto p ON dv.idProducto = p.idProducto
GROUP BY
    p.idProducto, p.nombreProducto;

-- Obtener el producto más vendido
SELECT TOP 1 *
FROM VistaProductosMasVendidos
ORDER BY CantidadVendida DESC;

