create procedure ActualizaProducto
(
@IDPRODUCTO int,
@NOMBREPRODUCTO nvarchar(40),
@CANTIDAD nvarchar(20),
@PRECIO money
)
as update Productos set
NombreProducto = @NOMBREPRODUCTO,
CantidadPorUnidad = @CANTIDAD,
PrecioUnidad = @PRECIO
where IdProducto = @IDPRODUCTO
return