CREATE DATABASE FARMACIA_BUENA__SALUD

USE FARMACIA_BUENA__SALUD
-- Crear la tabla Cliente
CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY,
    nombreCliente VARCHAR(255) NOT NULL,
    correoElectronico VARCHAR(255) NOT NULL,
    númeroTelefónico VARCHAR(20) NOT NULL
);

-- Crear la tabla TarjetaCredito
CREATE TABLE TarjetaCredito (
    idTarjeta INT PRIMARY KEY,
    idCliente INT NOT NULL,
    numeroTarjeta VARCHAR(16) NOT NULL,
    nombrePropietario VARCHAR(255) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente)
);

-- Crear la tabla Rol
CREATE TABLE Rol (
    idRol INT PRIMARY KEY,
    nombreRol VARCHAR(255) NOT NULL
);

-- Crear la tabla Empleado
CREATE TABLE Empleado (
    idEmpleado INT PRIMARY KEY,
    idRol INT NOT NULL,
    nombreEmpleado VARCHAR(255) NOT NULL,
    estadoLaboral VARCHAR(255) NOT NULL,
    salario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
);


-- Crear la tabla Venta
CREATE TABLE Venta (
    idVenta INT PRIMARY KEY,
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
    idCategoria INT PRIMARY KEY,
    nombreCategoria VARCHAR(255) NOT NULL
);


-- Tabla Producto
CREATE TABLE Producto (
    idProducto INT PRIMARY KEY,
    nombreProducto VARCHAR(255) NOT NULL,
    CantidadStock INT NOT NULL,
    idCategoria INT,
    precioProducto DECIMAL(10, 2) NOT NULL,
    existenciaProducto INT NOT NULL,
    FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);


-- Crear la tabla DetalleVenta
CREATE TABLE DetalleVenta (
    idDetalle INT PRIMARY KEY,
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidadProducto INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idVenta) REFERENCES Venta(idVenta),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);





-- Tabla Proveedor
CREATE TABLE Proveedor (
    idProveedor INT PRIMARY KEY,
    nombreProveedor VARCHAR(255) NOT NULL,
    telefonoProveedor VARCHAR(20) NOT NULL
);



-- Tabla DetalleVenta
CREATE TABLE DetalleVenta (
    idDetalle INT PRIMARY KEY,
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidadProducto INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idVenta) REFERENCES Venta(idVenta),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);

-- Tabla Compra
CREATE TABLE Compra (
    idCompra INT PRIMARY KEY,
    idProveedor INT NOT NULL,
    tipoCompra VARCHAR(50) NOT NULL,
    fechaCompra DATE NOT NULL,
    totalCompra DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idProveedor) REFERENCES Proveedor(idProveedor)
);

-- Tabla DetalleCompra
CREATE TABLE DetalleCompra (
    idDetalleCompra INT PRIMARY KEY,
    idCompra INT NOT NULL,
    idProducto INT NOT NULL,
    cantidadProducto INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (idCompra) REFERENCES Compra(idCompra),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);


