-- Script Date: 1/5/2026 19:19  - ErikEJ.SqlCeScripting version 3.5.2.103
-- Database information:
-- Database: C:\Users\josef\source\repos\Tarea3_JosefhArguello\Tarea3_JosefhArguello\empleados.db
-- ServerVersion: 3.46.1
-- DatabaseSize: 12 KB
-- Created: 1/5/2026 16:54

-- User Table information:
-- Number of tables: 1
-- Empleados: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Empleados] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [Nombre] text NOT NULL
, [Apellidos] text NOT NULL
, [Departamento] text NOT NULL
, [Salario] text NOT NULL
, [FechaIngreso] text NOT NULL
, [Activo] bigint NOT NULL
);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
1,'Santiago','Alfaro','Recursos Humanos','650000.0','2026-05-01 19:12:36.7648401',1);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
2,'Joshua','Álvarez','RRHH','650000.0','2026-05-01 19:13:16.1999779',1);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
3,'Carlos','Fonseca','Marketing','700000.0','2026-05-01 19:13:53.063152',1);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
4,'Ricardo','Quirós','Jefatura','1500000.0','2026-05-01 19:10:22.5869854',1);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
5,'Randy','Miranda','Contabilidad','850000.0','2026-05-01 19:12:00.8410693',1);
INSERT INTO [Empleados] ([Id],[Nombre],[Apellidos],[Departamento],[Salario],[FechaIngreso],[Activo]) VALUES (
6,'Antonio','Suárez','Contabilidad','1000000.0','2026-05-01 19:14:27.051602',1);
COMMIT;

