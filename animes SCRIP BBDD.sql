
CREATE DATABASE bdanime

–--coloca la BD TURISMO en memoria para poder hacer modificaciones
---PASO 2
USE bdanime

CREATE TABLE g_genero
(g_id int not null IDENTITY(1,1) primary key,
 g_descripcion varchar(255) not null,
 )

 insert into g_genero (g_descripcion)
 values 
 ('isekai'),
 ('Shounen'),
 ('Shojo'),
 ('Sentai'),
 ('Spokon'),
 ('Romakome'),
 ('Gore'),
 ('Seinen'),
 ('josei'),
 ('komodo'),
 ('Gakuen'),
 ('Mechas'),
 ('Maho shojo'),
 ('komodo'),
 ('Ecchi'),
 ('Yaoi'),
 ('Yuri');

 drop table g_genero
 
 select*
 from g_genero




 CREATE TABLE a_adaptacion
(a_id int not null IDENTITY(1,1) primary key,
 a_descripcion varchar(255) not null,
 )

 insert into a_adaptacion(a_descripcion)
 values 
 ('Manga'),
 ('Novela ligera'),
 ('Novela visual'),
 ('Video juego'),
 ('Original anime');

 select*
 from a_adaptacion


 CREATE TABLE c_clasificacion
(c_id int not null IDENTITY(1,1) primary key,
 c_descripcion varchar(255) not null,
 )

 insert into c_clasificacion(c_descripcion)
 values 
 ('+3'),
 ('+7'),
 ('+12'),
 ('+16'),
 ('+18');

 select*
 from c_clasificacion


  CREATE TABLE u_usuario
(u_id int not null IDENTITY(1,1) primary key,
 u_usuario varchar(255) not null,
 u_password varchar(255) not null
 )

 insert into u_usuario(u_usuario,u_password)
 values 
 ('zirniko','1234')

 select*
 from u_usuario

 drop table u_usuario



  CREATE TABLE an_anime
(an_id int not null IDENTITY(1,1) primary key,
 an_nombre varchar(255) not null,
 an_fechaEmision date not null,
 an_episodios int not null,
 an_generoId int not null,
 an_adaptacionId int not null,
 an_clasificacionId int not null,
 FOREIGN KEY (an_generoId) REFERENCES g_genero(g_id),
 FOREIGN KEY (an_adaptacionId) REFERENCES a_adaptacion(a_id),
 FOREIGN KEY (an_clasificacionId) REFERENCES c_clasificacion(c_id)
 )
drop table an_anime

 insert into an_anime(an_nombre,an_fechaEmision,an_episodios,an_generoId,an_adaptacionId,an_clasificacionId)
 values
	   ('No Game No Life','2017/07/15','12','17','2','4'),
	   ('Kaze ga Tsuyoku Fuiteiru','2018/10/03','23','4','2','3'),
	   ('Hanebado!','2018/07/01','13','4','1','3'),
	   ('Harukana Receive','2018/07/06','22','4','1','3'),
	   ('Megalo Box','2018/04/05','13','1','5','4'),
	   ('Ballroom e Youkoso','2017/07/09','24','1','1','3'),
	    
       ('Shingeki no Kyojin','2013/04/07','25','1','1','5'),


 select*
 from an_anime
 where 
 an_episodios <=25

 select *
 from an_anime
 where 
 an_nombre LIKE '%shin%'


 ---------------------------------------
 VISTA
 --------------------------------------

 create view inf_anime as
 select aa.an_id as 'Id Anime',
        aa.an_nombre as 'Nombre Anime',
        aa.an_fechaEmision as 'Fecha de emisión',
		aa.an_episodios as 'Episodios',
		gg.g_descripcion as 'Genero',
		dd.a_descripcion as 'Adaptacion',
		cc.c_descripcion as 'Clasificación'		 
 from  an_anime aa,
       g_genero gg,
       a_adaptacion dd,
       c_clasificacion cc
 where gg.g_id = aa.an_generoId
   and dd.a_id = aa.an_adaptacionId
   and cc.c_id = aa.an_clasificacionId;

   select * 
   from inf_anime

   drop view inf_anime







 -----------------------------------------------
 Procedimientos almacenados
 -----------------------------------------------
 
CREATE PROCEDURE VerificaUsuario
@Usuario varchar(255),
@Password varchar(255)
as
begin
select
*
from
u_usuario
where
(u_usuario=@Usuario and u_password=@Password)
end

****************************************************************
CREATE PROCEDURE IngresarGenero
@Descripcion Varchar(255)
AS
BEGIN
	insert
	into g_genero 
	     (g_descripcion)
	VALUES
	(@Descripcion)
END


CREATE PROCEDURE ListaGenero
AS
BEGIN
   SELECT
     g_id AS Id,
	 g_descripcion AS Descripción
   FROM
     g_genero
END

CREATE PROCEDURE ActualizarGenero
@Id int,
@Descripcion varchar(255)
as
begin
   UPDATE
   g_genero
   SET
	 g_descripcion=@Descripcion

   WHERE
     g_id=@Id
END


CREATE PROCEDURE EliminarGenero
@generoId int
as
begin
  delete
    from
       g_genero
    where
       g_id=@generoId
END


CREATE PROCEDURE ListaGeneroId
@GeneroId int
as
begin
   SELECT
     g_id AS ID,
     g_descripcion
   FROM
     g_genero
   WHERE
     g_id=@GeneroId
END

****************************************************************
CREATE PROCEDURE IngresarAdaptacion
@Descripcion Varchar(255)
AS
BEGIN
	insert
	into a_adaptacion 
	     (a_descripcion)
	VALUES
	(@Descripcion)
END

CREATE PROCEDURE ListaAdaptacion
AS
BEGIN
   SELECT
     a_id AS Id,
	 a_descripcion AS Descripción
   FROM
     a_adaptacion
END

CREATE PROCEDURE ActualizarAdaptacion
@Id int,
@Descripcion varchar(255)
as
begin
   UPDATE
   a_adaptacion
   SET
	 a_descripcion=@Descripcion

   WHERE
     a_id=@Id
END
 
 CREATE PROCEDURE EliminarAdaptacion
@adaptacionId int
as
begin
  delete
    from
       a_adaptacion
    where
       a_id=@adaptacionId
END

CREATE PROCEDURE ListaAdaptacionId
@AdaptacionId int
as
begin
   SELECT
     a_id AS ID,
     a_descripcion
   FROM
     a_adaptacion
   WHERE
     a_id=@AdaptacionId
END

***********************************************************

CREATE PROCEDURE IngresarClasificacion
@Descripcion Varchar(255)
AS
BEGIN
	insert
	into c_clasificacion 
	     (c_descripcion)
	VALUES
	(@Descripcion)
END

CREATE PROCEDURE ListaClasificacion
AS
BEGIN
   SELECT
     c_id AS Id,
	 c_descripcion AS Descripción
   FROM
     c_clasificacion
END

CREATE PROCEDURE ActualizarClasificacion
@Id int,
@Descripcion varchar(255)
as
begin
   UPDATE
   c_clasificacion
   SET
	 c_descripcion=@Descripcion

   WHERE
     c_id=@Id
END

CREATE PROCEDURE EliminarClasificacion
@clasificacionId int
as
begin
  delete
    from
       c_clasificacion
    where
       c_id=@clasificacionId
END

CREATE PROCEDURE ListaClasificacionId
@clasificacionId int
as
begin
   SELECT
     c_id AS ID,
     c_descripcion
   FROM
     c_clasificacion
   WHERE
     c_id=@clasificacionId
END

*******************************************************

CREATE PROCEDURE ListaAnime
AS
BEGIN
   SELECT*
   FROM
     inf_anime
END


CREATE PROCEDURE IngresarAnime
@nombre Varchar(255),
@Emision date,
@episodio int,
@GeneroID int,
@AdaptacionID int,
@ClasificacionID int
AS
Begin
   INSERT
   INTO
   an_anime
   (
    an_nombre,
    an_fechaEmision,
    an_episodios,
    an_generoId,
    an_adaptacionId,
	an_clasificacionId
	)
   VALUES
   (
   @nombre,
   @Emision,
   @episodio,
   @GeneroID,
   @AdaptacionID,
   @ClasificacionID
   )
END


CREATE PROCEDURE EliminarAnime
@animeId int
as
begin
  delete
    from
       an_anime
    where
       an_id=@animeId
END

CREATE PROCEDURE ListaAnimeId
@AnimeId int
as
begin
   SELECT
     an_id AS ID,
     an_nombre,
	 an_fechaEmision,
	 an_episodios,
	 an_generoId,
	 an_adaptacionId,
	 an_clasificacionId
   FROM
     an_anime
   WHERE
     an_id=@AnimeId
END


CREATE PROCEDURE ActualizarAnime
@Id int,
@nombre varchar(255),
@Emision Varchar(255),
@episodio int,
@GeneroID int,
@AdaptacionID int,
@ClasificacionID int
as
begin
   UPDATE
   an_anime
   SET
     an_nombre=@nombre,
	 an_fechaEmision=@Emision,
	 an_episodios=@episodio,
	 an_generoId=@GeneroID,
	 an_adaptacionId=@AdaptacionID,
	 an_clasificacionId=@ClasificacionID

   WHERE
     an_id=@Id
END

CREATE PROCEDURE ListaAnimeGenero
@Genero varchar (255)
as
begin
   SELECT *
   FROM
     inf_anime
   WHERE
     Genero=@Genero
END


CREATE PROCEDURE ListaAnimeAdaptacion
@Adaptacion varchar (255)
as
begin
   SELECT *
   FROM
     inf_anime
   WHERE
     Adaptacion=@Adaptacion
END

CREATE PROCEDURE ListaAnimeClasificacion
@Clasificacion varchar (255)
as
begin
   SELECT *
   FROM
     inf_anime
   WHERE
     Clasificación=@Clasificacion
END

CREATE PROCEDURE ListaAnimeFiltro
@Clasificacion varchar (255),
@Adaptacion varchar (255),
@Genero varchar (255)
as
begin
   SELECT *
   FROM
     inf_anime
   WHERE
     Clasificación=@Clasificacion
	 and Adaptacion=@Adaptacion
	 and Genero=@Genero
END