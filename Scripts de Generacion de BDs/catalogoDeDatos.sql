/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     14/06/2016 18:39:08                          */
/*==============================================================*/

drop database catalogo;
create database catalogo;
use catalogo;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ATRIBUTO') and o.name = 'FK_ATRIBUTO_ATRIBUTO__ENTIDAD')
alter table ATRIBUTO
   drop constraint FK_ATRIBUTO_ATRIBUTO__ENTIDAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGLA') and o.name = 'FK_REGLA_GRUPO_REG_GRUPO')
alter table REGLA
   drop constraint FK_REGLA_GRUPO_REG_GRUPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGLA_ATRIBUTO') and o.name = 'FK_REGLA_AT_REGLA_ATR_REGLA')
alter table REGLA_ATRIBUTO
   drop constraint FK_REGLA_AT_REGLA_ATR_REGLA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGLA_ATRIBUTO') and o.name = 'FK_REGLA_AT_REGLA_ATR_ATRIBUTO')
alter table REGLA_ATRIBUTO
   drop constraint FK_REGLA_AT_REGLA_ATR_ATRIBUTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGLA_ENTIDAD') and o.name = 'FK_REGLA_EN_REGLA_ENT_REGLA')
alter table REGLA_ENTIDAD
   drop constraint FK_REGLA_EN_REGLA_ENT_REGLA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REGLA_ENTIDAD') and o.name = 'FK_REGLA_EN_REGLA_ENT_ENTIDAD')
alter table REGLA_ENTIDAD
   drop constraint FK_REGLA_EN_REGLA_ENT_ENTIDAD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ATRIBUTO')
            and   name  = 'ATRIBUTO_ENTIDAD_FK'
            and   indid > 0
            and   indid < 255)
   drop index ATRIBUTO.ATRIBUTO_ENTIDAD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ATRIBUTO')
            and   type = 'U')
   drop table ATRIBUTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENTIDAD')
            and   type = 'U')
   drop table ENTIDAD
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GRUPO')
            and   type = 'U')
   drop table GRUPO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGLA')
            and   name  = 'GRUPO_REGLA_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGLA.GRUPO_REGLA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGLA')
            and   type = 'U')
   drop table REGLA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGLA_ATRIBUTO')
            and   name  = 'REGLA_ATRIBUTO_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGLA_ATRIBUTO.REGLA_ATRIBUTO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGLA_ATRIBUTO')
            and   name  = 'REGLA_ATRIBUTO2_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGLA_ATRIBUTO.REGLA_ATRIBUTO2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGLA_ATRIBUTO')
            and   type = 'U')
   drop table REGLA_ATRIBUTO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGLA_ENTIDAD')
            and   name  = 'REGLA_ENTIDAD_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGLA_ENTIDAD.REGLA_ENTIDAD_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('REGLA_ENTIDAD')
            and   name  = 'REGLA_ENTIDAD2_FK'
            and   indid > 0
            and   indid < 255)
   drop index REGLA_ENTIDAD.REGLA_ENTIDAD2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REGLA_ENTIDAD')
            and   type = 'U')
   drop table REGLA_ENTIDAD
go

/*==============================================================*/
/* Table: ATRIBUTO                                              */
/*==============================================================*/
create table ATRIBUTO (
   NOMBREATRIBUTO       varchar(200)                 not null,
   NOMBREENTIDAD        varchar(200)                 not null,
   DESCRIPCIONATRIBUTO  varchar(200)                 null,
   CAMPOFISICO          varchar(200)                 null,
   constraint PK_ATRIBUTO primary key nonclustered (NOMBREATRIBUTO)
)
go

/*==============================================================*/
/* Index: ATRIBUTO_ENTIDAD_FK                                   */
/*==============================================================*/
create index ATRIBUTO_ENTIDAD_FK on ATRIBUTO (
NOMBREENTIDAD ASC
)
go

/*==============================================================*/
/* Table: ENTIDAD                                               */
/*==============================================================*/
create table ENTIDAD (
   NOMBREENTIDAD        varchar(200)                 not null,
   DESCRIPCIONENTIDAD   varchar(200)                 null,
   TABLAFISICA          varchar(200)                 null,
   constraint PK_ENTIDAD primary key nonclustered (NOMBREENTIDAD)
)
go

/*==============================================================*/
/* Table: GRUPO                                                 */
/*==============================================================*/
create table GRUPO (
   IDGRUPO              int                  not null,
   NOMBREGRUPO          varchar(200)                 null,
   DESCRIPCIONGRUPO     varchar(200)                 null,
   constraint PK_GRUPO primary key nonclustered (IDGRUPO)
)
go

/*==============================================================*/
/* Table: REGLA                                                 */
/*==============================================================*/
create table REGLA (
   IDREGLA              int                  not null,
   IDGRUPO              int                  not null,
   NOMBREREGLA          varchar(200)                 null,
   DESCRIPCIONFORMAL     varchar(200)                 null,
   DESCRIPCIONINFORMAL     varchar(200)                 null,
   constraint PK_REGLA primary key nonclustered (IDREGLA)
)
go

/*==============================================================*/
/* Index: GRUPO_REGLA_FK                                        */
/*==============================================================*/
create index GRUPO_REGLA_FK on REGLA (
IDGRUPO ASC
)
go

/*==============================================================*/
/* Table: REGLA_ATRIBUTO                                        */
/*==============================================================*/
create table REGLA_ATRIBUTO (
   IDREGLA              int                  not null,
   NOMBREATRIBUTO       varchar(200)                 not null,
   constraint PK_REGLA_ATRIBUTO primary key nonclustered (IDREGLA, NOMBREATRIBUTO)
)
go

/*==============================================================*/
/* Index: REGLA_ATRIBUTO2_FK                                    */
/*==============================================================*/
create index REGLA_ATRIBUTO2_FK on REGLA_ATRIBUTO (
NOMBREATRIBUTO ASC
)
go

/*==============================================================*/
/* Index: REGLA_ATRIBUTO_FK                                     */
/*==============================================================*/
create index REGLA_ATRIBUTO_FK on REGLA_ATRIBUTO (
IDREGLA ASC
)
go

/*==============================================================*/
/* Table: REGLA_ENTIDAD                                         */
/*==============================================================*/
create table REGLA_ENTIDAD (
   IDREGLA              int                  not null,
   NOMBREENTIDAD        varchar(200)                 not null,
   constraint PK_REGLA_ENTIDAD primary key nonclustered (IDREGLA, NOMBREENTIDAD)
)
go

/*==============================================================*/
/* Index: REGLA_ENTIDAD2_FK                                     */
/*==============================================================*/
create index REGLA_ENTIDAD2_FK on REGLA_ENTIDAD (
NOMBREENTIDAD ASC
)
go

/*==============================================================*/
/* Index: REGLA_ENTIDAD_FK                                      */
/*==============================================================*/
create index REGLA_ENTIDAD_FK on REGLA_ENTIDAD (
IDREGLA ASC
)
go

alter table ATRIBUTO
   add constraint FK_ATRIBUTO_ATRIBUTO__ENTIDAD foreign key (NOMBREENTIDAD)
      references ENTIDAD (NOMBREENTIDAD)
go

alter table REGLA
   add constraint FK_REGLA_GRUPO_REG_GRUPO foreign key (IDGRUPO)
      references GRUPO (IDGRUPO)
go

alter table REGLA_ATRIBUTO
   add constraint FK_REGLA_AT_REGLA_ATR_REGLA foreign key (IDREGLA)
      references REGLA (IDREGLA)
go

alter table REGLA_ATRIBUTO
   add constraint FK_REGLA_AT_REGLA_ATR_ATRIBUTO foreign key (NOMBREATRIBUTO)
      references ATRIBUTO (NOMBREATRIBUTO)
go

alter table REGLA_ENTIDAD
   add constraint FK_REGLA_EN_REGLA_ENT_REGLA foreign key (IDREGLA)
      references REGLA (IDREGLA)
go

alter table REGLA_ENTIDAD
   add constraint FK_REGLA_EN_REGLA_ENT_ENTIDAD foreign key (NOMBREENTIDAD)
      references ENTIDAD (NOMBREENTIDAD)
go

