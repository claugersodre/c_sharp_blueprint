dotnet add sln
dotnet new mvc -o name_project
dotnet add package Microsoft.EntityFrameworkCore --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool update --global dotnet-ef  --version 6.0


dotnet ef migrations add "InitialDbSetup" / at .csproject folder
dotnet ef database update



