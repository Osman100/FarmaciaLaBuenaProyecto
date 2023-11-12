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


CREATE VIEW VistaCompra AS 
SELECT vc.idCompra AS 'ID', pr.idProveedor AS 'Proveedor', vc.tipoCompra AS 'Tipo', vc.fechaCompra AS 'Fecha', vc.totalCompra AS 'Total'
FROM Compra vc 
INNER JOIN Proveedor pr ON pr.idProveedor = vc.idProveedor;

GO

CREATE VIEW VistaDetalleVenta AS 
SELECT vdv.idDetalle AS 'ID', pr.idProducto AS 'Producto', vdv.cantidadProducto AS 'Cantidad', vdv.subtotal AS 'Total'
FROM DetalleVenta vdv
INNER JOIN Producto pr ON pr.idProducto = vdv.idProducto

GO

CREATE VIEW VistaVenta AS 
SELECT vv.idVenta AS 'ID', cl.idCliente AS 'Cliente', emp.idEmpleado AS 'Empleado', vv.tipoVenta AS 'Tipo', vv.fechaVenta AS 'Fecha', vv.total AS 'Total'
FROM ((Venta vv
INNER JOIN Cliente cl ON cl.idCliente = vv.idCliente)
INNER JOIN Empleado emp ON emp.idEmpleado = vv.idEmpleado);

GO




