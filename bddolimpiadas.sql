/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2/8/2023 0:17:27                             */
/*==============================================================*/

create database bddolimpiadas;
go
use bddolimpiadas;
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_DEPORTISTAS') and o.name = 'FK_TAB_DEPO_REFERENCE_TAB_NACI')
alter table TAB_DEPORTISTAS
   drop constraint FK_TAB_DEPO_REFERENCE_TAB_NACI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_EVENTOS') and o.name = 'FK_TAB_EVEN_REFERENCE_TAB_DEPO')
alter table TAB_EVENTOS
   drop constraint FK_TAB_EVEN_REFERENCE_TAB_DEPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_EVENTOS') and o.name = 'FK_TAB_EVEN_REFERENCE_TAB_SEDE')
alter table TAB_EVENTOS
   drop constraint FK_TAB_EVEN_REFERENCE_TAB_SEDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESULTADOS') and o.name = 'FK_TAB_RESU_REFERENCE_TAB_EVEN')
alter table TAB_RESULTADOS
   drop constraint FK_TAB_RESU_REFERENCE_TAB_EVEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESULTADOS') and o.name = 'FK_TAB_RESU_REFERENCE_TAB_DEPO')
alter table TAB_RESULTADOS
   drop constraint FK_TAB_RESU_REFERENCE_TAB_DEPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_SEDESOLIMPICAS') and o.name = 'FK_TAB_SEDE_REFERENCE_TAB_CIUD')
alter table TAB_SEDESOLIMPICAS
   drop constraint FK_TAB_SEDE_REFERENCE_TAB_CIUD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CIUDADES')
            and   type = 'U')
   drop table TAB_CIUDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_DEPORTES')
            and   type = 'U')
   drop table TAB_DEPORTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_DEPORTISTAS')
            and   type = 'U')
   drop table TAB_DEPORTISTAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_EVENTOS')
            and   type = 'U')
   drop table TAB_EVENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_NACIONALIDADES')
            and   type = 'U')
   drop table TAB_NACIONALIDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_RESULTADOS')
            and   type = 'U')
   drop table TAB_RESULTADOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_SEDESOLIMPICAS')
            and   type = 'U')
   drop table TAB_SEDESOLIMPICAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_USUARIOS')
            and   type = 'U')
   drop table TAB_USUARIOS
go

/*==============================================================*/
/* Table: TAB_CIUDADES                                          */
/*==============================================================*/
create table TAB_CIUDADES (
   IDCIUDAD             int                  identity,
   NOMBRECIUDAD         varchar(50)          null,
   PAIS                 varchar(50)          null,
   constraint PK_TAB_CIUDADES primary key (IDCIUDAD)
)
go

/*==============================================================*/
/* Table: TAB_DEPORTES                                          */
/*==============================================================*/
create table TAB_DEPORTES (
   IDDEPORTE            integer              identity,
   NOMBREDEPORTE        varchar(50)          null,
   constraint PK_TAB_DEPORTES primary key (IDDEPORTE)
)
go

/*==============================================================*/
/* Table: TAB_DEPORTISTAS                                       */
/*==============================================================*/
create table TAB_DEPORTISTAS (
   IDDEPORTISTA         integer              identity,
   IDNACIONALIDAD       integer              null,
   NOMBREDEPORTISTA     varchar(100)         null,
   FECHANACIMIENTO      date                 null,
   TELEFONO             varchar(10)          null,
   constraint PK_TAB_DEPORTISTAS primary key (IDDEPORTISTA)
)
go

/*==============================================================*/
/* Table: TAB_EVENTOS                                           */
/*==============================================================*/
create table TAB_EVENTOS (
   IDEVENTO             int                  identity,
   IDDEPORTE            integer              null,
   IDSEDE               int                  null,
   NOMBREEVENTO         varchar(50)          null,
   FECHAEVENTO          date                 null,
   constraint PK_TAB_EVENTOS primary key (IDEVENTO)
)
go

/*==============================================================*/
/* Table: TAB_NACIONALIDADES                                    */
/*==============================================================*/
create table TAB_NACIONALIDADES (
   IDNACIONALIDAD       integer              identity,
   NOMBRENACIONALIDAD   varchar(50)          null,
   constraint PK_TAB_NACIONALIDADES primary key (IDNACIONALIDAD)
)
go

/*==============================================================*/
/* Table: TAB_RESULTADOS                                        */
/*==============================================================*/
create table TAB_RESULTADOS (
   IDRESULTADO          int                  identity,
   IDEVENTO             int                  null,
   IDDEPORTISTA         integer              null,
   POSICION             int                  null,
   MARCATIEMPO          time                 null,
   RONDA                varchar(50)          null,
   constraint PK_TAB_RESULTADOS primary key (IDRESULTADO)
)
go

/*==============================================================*/
/* Table: TAB_SEDESOLIMPICAS                                    */
/*==============================================================*/
create table TAB_SEDESOLIMPICAS (
   IDSEDE               int                  identity,
   IDCIUDAD             int                  null,
   NOMBRESEDE           varchar(50)          null,
   ANIOCELEBRACION      int                  null,
   constraint PK_TAB_SEDESOLIMPICAS primary key (IDSEDE)
)
go

/*==============================================================*/
/* Table: TAB_USUARIOS                                          */
/*==============================================================*/
create table TAB_USUARIOS (
   IDUSUARIO            int                  identity,
   NOMBREUSUARIO        varchar(50)          null,
   USUARIO              varchar(50)          null,
   CLAVE                varchar(50)          null,
   ROL                  varchar(50)          null,
   constraint PK_TAB_USUARIOS primary key (IDUSUARIO)
)
go

alter table TAB_DEPORTISTAS
   add constraint FK_TAB_DEPO_REFERENCE_TAB_NACI foreign key (IDNACIONALIDAD)
      references TAB_NACIONALIDADES (IDNACIONALIDAD)
go

alter table TAB_EVENTOS
   add constraint FK_TAB_EVEN_REFERENCE_TAB_DEPO foreign key (IDDEPORTE)
      references TAB_DEPORTES (IDDEPORTE)
go

alter table TAB_EVENTOS
   add constraint FK_TAB_EVEN_REFERENCE_TAB_SEDE foreign key (IDSEDE)
      references TAB_SEDESOLIMPICAS (IDSEDE)
go

alter table TAB_RESULTADOS
   add constraint FK_TAB_RESU_REFERENCE_TAB_EVEN foreign key (IDEVENTO)
      references TAB_EVENTOS (IDEVENTO)
go

alter table TAB_RESULTADOS
   add constraint FK_TAB_RESU_REFERENCE_TAB_DEPO foreign key (IDDEPORTISTA)
      references TAB_DEPORTISTAS (IDDEPORTISTA)
go

alter table TAB_SEDESOLIMPICAS
   add constraint FK_TAB_SEDE_REFERENCE_TAB_CIUD foreign key (IDCIUDAD)
      references TAB_CIUDADES (IDCIUDAD)
go

