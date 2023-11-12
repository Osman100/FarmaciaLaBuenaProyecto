CREATE PROCEDURE decreaseStock @idProducto int, @cantidad int
AS 
UPDATE Producto SET CantidadStock = CantidadStock - @cantidad WHERE idProducto = @idProducto;

GO 

CREATE PROCEDURE increaseStock @idProducto int, @cantidad int
AS 
UPDATE Producto SET CantidadStock = CantidadStock + @cantidad WHERE idProducto = @idProducto;
