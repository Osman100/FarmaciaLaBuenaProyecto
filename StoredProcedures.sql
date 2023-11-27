CREATE PROCEDURE decreaseStock @idProducto int, @cantidad int
AS 
UPDATE Producto SET CantidadStock = CantidadStock - @cantidad WHERE idProducto = @idProducto;

GO 

CREATE PROCEDURE increaseStock @idProducto int, @cantidad int
AS 
UPDATE Producto SET CantidadStock = CantidadStock + @cantidad WHERE idProducto = @idProducto;


CREATE PROCEDURE GetMostSoldProduct
AS
BEGIN
    SELECT TOP 1
        p.idProducto,
        p.nombreProducto AS Nombre,
        COUNT(dv.idProducto) AS CantidadVendida
    FROM
        DetalleVenta dv
    JOIN
        Producto p ON dv.idProducto = p.idProducto
    GROUP BY
        p.idProducto, p.nombreProducto
    ORDER BY
        CantidadVendida DESC;
END;


