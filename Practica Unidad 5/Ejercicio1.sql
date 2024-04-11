


-- EJERCICIOS SQL

-- EJERCICIO 1 
-- Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).

 SELECT D.Titulo, D.FechaLanzamiento,E.Descripcion Estilo from DISCOS D,ESTILOS E
 Where D.IdEstilo = E.Id

-- EJERCICIO 2
-- Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

insert into ESTILOS values ('Cumbia')
insert into ESTILOS values ('Indie')

-- EJERCICIO 3 
-- Insertar al menos dos discos nuevos cargando correctamente su información.

 insert into DISCOS values ('MAREA',GETDATE(), 89, 'LALALA...',1,2)
 insert into DISCOS values ('LA LEY',1989-10-28, 25,'LERO LERO...',2,1)

-- EJERCICIO 4 
-- Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.

 update DISCOS set  FechaLanzamiento ='2010-10-10' where Id = 4
 update DISCOS set CantidadCanciones = 999, FechaLanzamiento = '1999- 10-11' where Id = 3


-- EJERCICIO 5 
-- Borrar un disco a elección.

 delete from DISCOS where Id = 3


-- EJERCICIO 6 
-- Traer todos los estilos que estén asociados a algún disco.

 select E.Descripcion  from DISCOS D, ESTILOS E where  D.IdEstilo = E.Id

-- EJERCICIO 7 
-- Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

 select D.Titulo,E.Descripcion Estilo, T.Descripcion Formato
 from DISCOS D, ESTILOS E, TIPOSEDICION T
 where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id
   