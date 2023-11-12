CREATE PROCEDURE decreaseStock @idProducto int
AS 
UPDATE Producto SET CantidadStock = CantidadStock - 1 WHERE idProducto = @idProducto;

GO 

CREATE PROCEDURE increaseStock @idProducto int
AS 
UPDATE Producto SET CantidadStock = CantidadStock + 1 WHERE idProducto = @idProducto;
