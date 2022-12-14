USE [DBDPOS]
GO
/****** Object:  StoredProcedure [dbo].[EditarPreciosProductos]    Script Date: 28/07/2021 20:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarPreciosProductos]
@idproducto int,
@precioventa numeric(18,2),
@costo numeric(18,2),
@preciomayoreo numeric(18,2),
@cantidadAgregada numeric(18,2),
@Impuesto varchar(50)
as
update Producto1 set 
Precio_de_venta=@precioventa ,
Precio_de_compra = @costo ,
Precio_mayoreo=@preciomayoreo ,
Stock = Stock + @cantidadAgregada,
Impuesto=@Impuesto
where Id_Producto1=@idproducto and Usa_inventarios = 'SI'

