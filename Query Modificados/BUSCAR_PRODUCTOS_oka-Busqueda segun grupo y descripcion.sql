USE [DBDPOS]
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_PRODUCTOS_oka]    Script Date: 27/07/2021 00:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[BUSCAR_PRODUCTOS_oka]

@letrab VARCHAR(50)
AS 
BEGIN
SELECT      TOP 10  Id_Producto1,(Descripcion+' /Precio: '+EMPRESA.Moneda   +' '+ convert(varchar(50),Precio_de_venta)  +' /Codigo: '+ Codigo  ) AS Descripcion
, Usa_inventarios, Stock, Precio_de_compra, Precio_de_venta, Codigo, Se_vende_a
,Descripcion as Descripcion2, Codigo, Producto1.Impuesto
FROM            dbo.Producto1  cross join EMPRESA 
INNER JOIN Grupo_de_Productos on
Grupo_de_Productos.Idline=Producto1.Id_grupo   
              
where  (Grupo_de_Productos.Linea + Descripcion+' /Precio: '+EMPRESA.Moneda   +' '+ convert(varchar(50),Precio_de_venta)  +' /Codigo: '+ Codigo  ) LIKE  '%' + @letrab+'%' 
end  












