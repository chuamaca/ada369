
ALTER proc [dbo].[mostrar_productos_agregados_a_venta]
@idventa as int
as
SELECT      detalle_venta . Codigo ,( detalle_venta .Descripcion ) as Producto,
 dbo.detalle_venta.Cantidad_mostrada as Cant, 
dbo.detalle_venta.preciounitario as P_Unit ,
convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe,
						  detalle_venta .Id_producto  ,DBO.detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 , detalle_venta .Stock ,dbo.detalle_venta.cantidad ,ventas.idclientev 
						 , detalle_venta .Stock ,detalle_venta .Stock ,Usa_inventarios ,
						 Se_vende_a ,detalle_venta.idventa, detalle_venta.Impuesto 
FROM            dbo.detalle_venta INNER JOIN
                         ventas ON dbo.detalle_venta.idventa = ventas.idventa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 order by 
detalle_venta.iddetalle_venta desc














