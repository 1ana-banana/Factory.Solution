## _Dr.Sillystringz Factory Database_

#### _By Anastasia Han_

<br>

####  C# web application using CRUD and MySQL databases to store and show machines and engineers, including their status.

<br>
 
</div>

## Technologies Used

* C#
* .NET v5.0
* ASP.NET Core MVC
* HTML 
* Bootstrap
* MySQL
* CSS
* MySQL Workbench
* Razor
* Entity FrameworkCore

## Description

C# web application using CRUD and MySQL databases to store and show machines and engineers, including their status.

## Installation Requirements

* _Clone or download the zip file of this repository to your desktop_
* _Navigate into the top level directory_
* _Open in your code editor_
* _Commit and push your .gitignore file to your repo_
* _Add the file Factory.Solution/Factory/appsettings.json and insert the following:_
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME];uid=[YOUR-UID];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Insert your MySQL password, database name and user Id_
* _Make sure to have .NET 5.0 installed_
* _Run `$ dotnet restore` to install bin & obj folders_


## Steps To Use
* _In your terminal of choice, navigate into Factory.Solution/Factory_
* _If Migrations folder is not present, run `$ dotnet ef migrations add Initial`._
* _Then run `$ dotnet ef database update`._
* _Run `$ dotnet build`._
* _Run `$ dotnet run`._

## Known Bugs

* _N/A_

## License

MIT
Copyright (c) 2022 Anstasia Han
