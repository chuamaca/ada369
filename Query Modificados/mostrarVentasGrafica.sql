
create proc [dbo].[mostrarVentasGrafica]
as
declare @anio int
set @anio = DATEPART (YEAR, GETDATE())
select (datename(MONTH, fecha_venta) + ' ' + datename(YEAR,fecha_venta )) as fecha
,sum(Monto_total) as Total
from ventas 
where DATEPART(YEAR,fecha_venta)=@anio 
group by datename(MONTH , fecha_venta), DATENAME (YEAR ,fecha_venta )
order by fecha desc


