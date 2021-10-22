<----------------- <<Proyecto Administracion Ordenes Servicios>> ------------------->

Creando la solucion del proyecto en C# mediante la termina de C# usando dotnet

dotnet new sln -o HotelService.App


<----------------- <<Capa Dominio>> ------------------->




<----------------- <<Capa Persistencia>> ------------------->


<----------------- <<Capa API>> ------------------->


<----------------- <<Capa Frontend>> ------------------->





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

