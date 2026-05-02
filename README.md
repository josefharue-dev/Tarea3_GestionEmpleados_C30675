# Tarea3_JosefhArguello
# Gestión de Empleados - Tarea 3

## Nombre
Josefh Argüello Ramos

## Descripción
Aplicación web ASP.NET Core MVC para la gestión de empleados utilizando Entity Framework Core y SQLite.

## Funcionalidades

- CRUD de empleados
- Búsqueda por nombre, apellidos o departamento
- Paginación de resultados
- Activación y desactivación de empleados (sin eliminación física)

## Tecnologías
- ASP.NET Core MVC
- Entity Framework Core
- SQLite

## Instrucciones de ejecución

1. Abrir el proyecto en Visual Studio
2. Ejecutar la aplicación
3. La base de datos se crea automáticamente
4. Acceder a la lista de empleados

## Paginación

Se muestran 5 empleados por página.  
Se puede navegar con los botones "Anterior" y "Siguiente".

## Búsqueda

Se puede buscar usando:

/Empleados?busqueda=texto

Ejemplo:

/Empleados?busqueda=TI
