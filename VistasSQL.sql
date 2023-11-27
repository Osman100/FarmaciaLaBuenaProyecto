USE FARMACIA_BUENA__SALUD

CREATE VIEW VistaDetalleCompra AS
SELECT dv.idCompra AS 'ID', p.NombreProducto AS 'Producto', p.precioProducto AS 'Precio', dv.cantidadProducto AS 'Cantidad', dv.subtotal AS 'Total'
FROM DetalleCompra dv
INNER JOIN Producto p ON dv.IDProducto = p.IDProducto;
GO

ALTER VIEW VistaDetalleCompra AS
SELECT dv.idCompra AS 'ID', p.NombreProducto AS 'Producto', p.precioProducto AS 'Precio unitario', dv.cantidadProducto AS 'Cantidad', dv.subtotal AS 'Total'
FROM DetalleCompra dv
INNER JOIN Producto p ON dv.IDProducto = p.IDProducto;

GO
ALTER VIEW VistaDetalleCompra2 AS
SELECT dv.idDetalleCompra AS 'ID', dv.idCompra AS 'ID de Compra', p.NombreProducto AS 'Producto', ct.nombreCategoria AS 'Categoria', p.precioProducto AS 'Precio unitario', dv.cantidadProducto AS 'Cantidad', dv.subtotal AS 'Total'
FROM DetalleCompra dv
INNER JOIN Producto p ON dv.IDProducto = p.IDProducto
INNER JOIN Categoria ct ON ct.idCategoria = p.idCategoria;

GO
SELECT * FROM VistaDetalleCompra2

ALTER VIEW VistaCompra AS 
SELECT vc.idCompra AS 'ID', pr.nombreProveedor AS 'Proveedor', vc.tipoCompra AS 'Tipo', vc.fechaCompra AS 'Fecha', vc.totalCompra AS 'Total'
FROM Compra vc 
INNER JOIN Proveedor pr ON pr.idProveedor = vc.idProveedor;

GO

ALTER VIEW VistaDetalleVenta4 AS 
SELECT vdv.idVenta AS 'ID de venta',vdv.idDetalle AS 'ID', pr.nombreProducto AS 'Producto',pr.precioProducto AS 'Precio unitario', vdv.cantidadProducto AS 'Cantidad', vdv.subtotal AS 'Total'
FROM DetalleVenta vdv
INNER JOIN Producto pr ON pr.idProducto = vdv.idProducto
GO 

CREATE VIEW VistaDetalleVenta5 AS 
SELECT vdv.idVenta AS 'IDDeVenta',vdv.idDetalle AS 'ID', pr.nombreProducto AS 'Producto',pr.precioProducto AS 'PrecioUnitario', vdv.cantidadProducto AS 'Cantidad', vdv.subtotal AS 'Total'
FROM DetalleVenta vdv
INNER JOIN Producto pr ON pr.idProducto = vdv.idProducto

GO
ALTER VIEW VistaVenta3 AS 
SELECT vv.idVenta AS 'ID', cl.nombreCliente AS 'Cliente', ISNULL(tr.numeroTarjeta,'No aplica') AS 'Tarjeta',emp.nombreEmpleado AS 'Empleado', vv.tipoVenta AS 'Tipo', vv.fechaVenta AS 'Fecha', vv.total AS 'Total'
FROM (((Venta vv
INNER JOIN Cliente cl ON cl.idCliente = vv.idCliente)
INNER JOIN Empleado emp ON emp.idEmpleado = vv.idEmpleado)
LEFT JOIN TarjetaCredito tr ON vv.idTarjetaCredito = tr.idTarjeta);

GO

CREATE VIEW VistaProductos AS
SELECT vp.idProducto AS 'ID', vp.nombreProducto AS 'Producto', ct.idCategoria AS 'Categoria', vp.CantidadStock AS 'Cantidad', vp.precioProducto AS 'Precio'
FROM Producto vp 
INNER JOIN Categoria ct ON ct.idCategoria = vp.idCategoria;


GO
CREATE VIEW VistaTarjetas AS 
SELECT tj.idTarjeta AS 'ID', cl.nombreCliente AS 'Nombre titular',tj.numeroTarjeta AS 'Numero'
FROM TarjetaCredito tj
INNER JOIN Cliente cl ON tj.idCliente = cl.idCliente



