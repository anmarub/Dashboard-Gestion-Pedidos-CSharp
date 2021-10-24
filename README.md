<----------------- <<Proyecto Administracion Ordenes Servicios>> ------------------->

Creando la solucion en C# mediante la termina de C# usando dotnet

dotnet new sln -o HotelService.App

instalaciones de Paquetes necesarios:

dotnet tool install --global dotnet-ef 
dotnet tool update --global dotnet-ef



<----------------- <<Capa Dominio>> ------------------->

Crear la capa de Dominio mediante comandos en terminal usando dotnet

dotnet new classlib -o HotelService.App.Domain


<----------------- <<Capa Persistencia>> ------------------->

Crear la capa de Persistencia mediante comandos en terminal usando dotnet

dotnet new classlib -o HotelService.App.Persistence

Instalación de librerias de EF en la capa de persistencia
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0
dotnet add package MySql.EntityFrameworkCore --version 5.0.8
dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.22

dotnet add reference ..\HotelService.App.Domain\

migracion de la base de datos 

dotnet ef migrations add Inicial --startup-project ..\HotelService.App.Console\
dotnet ef database update --startup-project ..\HotelService.App.Console\
dotnet ef migrations remove --startup-project ..\HotelService.App.Consola\



<----------------- <<Capa API>> ------------------->

Crear la capa de API mediante comandos en terminal usando dotnet

dotnet new webapi -o HotelService.App.Service

<----------------- <<Capa Consola>> ------------------->

Crear la capa de Consola mediante comandos en terminal usando dotnet

dotnet new console -o HotelService.App.Console
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
dotnet add reference ..\HotelService.App.Persistence\
dotnet add reference ..\HotelService.App.Domain\


<----------------- <<Capa Frontend>> ------------------->

Crear la capa de Frontend mediante comandos en terminal usando dotnet

dotnet new blazorserver -o {APP NAME} -au {AUTHENTICATION}

Mecanismo de autenticación	Descripción
None (defecto)	            Sin autenticacion
Individual	                Usuarios almacenados en la aplicación con ASP.NET Core Identity
IndividualB2C	            Usuarios almacenados en Azure AD B2C
SingleOrg	                Autenticación organizacional para un solo inquilino
MultiOrg	                Autenticación organizacional para múltiples inquilinos
Windows	                    Autenticación de Windows


dotnet new blazorserver -o HotelService.App.Frontend -au Individual

Instalación de librerias de EF en la capa de Frontend
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0 
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.0 
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0

Vinculacion con las capas de dominio y persistencia

dotnet add reference ..\HotelService.App.Persistence\
dotnet add reference ..\HotelService.App.Domain\



Proyecto MisionTic 2021

Intranet Gestion de Produccion para la empresa Consecha Tropical - Colombia

Programado en Lenguaje C# usando los siguientes Framework

Backend
 - ORM Entity Framework Core 3
 - Base de Datos SqlServer

Frontend
- Razor Pages in ASP.NET Core

Data Complementaria

Comandos En la capa de Persistencia 

dotnet add package Microsoft.EntityFrameworkCore --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.4
dotnet add package Microsoft.EntityFrameworkCore.sqlServer --version 5.0.4

Comandos de relacionamiento de proyectos

dotnet add reference ..\Produccion.App.Domain

Capa consola

dotnet add reference ..\Produccion.App.Domain\
dotnet add reference ..\Produccion.App.Persistence\
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.10

dotnet ef migrations add initial --startup-project ..\Produccion.App.Console\
dotnet ef database update --startup-project ..\Produccion.App.Console\
dotnet ef migrations remove Inicial --startup-project ..\Produccion.App.Console\


Comandos Login 

dotnet tool install -g dotnet-aspnet-codegenerator

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet aspnet-codegenerator identity -h

