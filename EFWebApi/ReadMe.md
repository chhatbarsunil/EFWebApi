Install tools for Scaffold-DbContext and create model
-----------------------------------------------------
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.15


Working Example of  :Scaffold-DbContext
---------------------------------------
Scaffold-DbContext "Server=127.0.0.1;User ID=root;Database=diamondecommerce" MySql.EntityFrameworkCore  -OutputDir Models  -ContextDir Context -Context DbContext


Connection String for MySql
"Server=127.0.0.1;User ID=root;Database=diamondecommerce"

