Install donet sdk for of version 5 if not already installed
-----------------------------------------------------------

Install tools for Scaffold-DbContext and create model
-----------------------------------------------------
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.15

Example of :Scaffold-DbContext ( checked working command) 
---------------------------------------
Note:
1) to scaffolding models and dbcontext using database first approach
2) delete the dbcontext and models folder
3) check the database exist and updated
Use below command in package manager console

Scaffold-DbContext "Server=127.0.0.1;User ID=root;Database=efwebapidb" MySql.EntityFrameworkCore  -OutputDir Models  -ContextDir Context -Context EfWebApiDbContext

## Used MySql Database Check MySql Service is running in Xampp or in system
---------------------------------------------------------------------------
Connection String for MySql
"Server=127.0.0.1;User ID=root;Database=efwebapidb"

## to create db if not exist
----------------------------
Use below command in package manager console
Add-Migration InitialCreate
Update-Database



