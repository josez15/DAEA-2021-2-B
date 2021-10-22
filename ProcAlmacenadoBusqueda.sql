create proc BuscarPersonaData
	@Busqueda nvarchar(100)
as
select * from Person where PersonID like '%'+@Busqueda+'%'  or FirstName like '%'+@Busqueda+'%' or LastName like '%'+@Busqueda+'%';