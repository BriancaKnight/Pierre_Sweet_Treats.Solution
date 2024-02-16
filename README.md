# Project Name

### Short Project Description

#### By Brianca Knight

## Technologies Used

* C#
* .Net 6
* ASP.Net / MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

This is a longer description of the application.

Here is a diagram of the schema structure:

![Add Schema Diagram](diagram.png)

## Setup/Installation Requirements

* Clone this repo from `https://github.com/BriancaKnight/ProjectName.Solution`.

* In the production sub directory (named `ProjectName`) create a file named `appsettings.json` and add the following code to it:

 ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```

  Make sure to update the string with your own values for [DATABASE-NAME],[USERNAME] and [PASSWORD], without square brackets. You can name the database whatever you like. 

* In the terminal run the commands `dotnet tool install --global dotnet-ef --version 6.0.0` and `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0` to download the tools dotnet-ef that will create migrations and update your database. 

* To create a data migration for the database, initialize with `dotnet ef migrations add Initial` in your terminal. This should create a Migrations folder in the production subdirectory of your project. 

* To add subsequent migrations run the command `dotnet ef migrations add [AddExamplePriority]` You can name the migration whatever you like, however it is common to start with a verb and use upper camel case. Remember to remove the square brackets!

* Run the following command to update the database. `dotnet ef database update`.

* If you would like to remove a migration from the database, run `dotnet ef migrations remove`.

* Run the command `dotnet watch run` to compile and run the application in development mode with a watcher. Optionally, you can run `dotnet build` to compile without running the app. 

* Open the browser to https://localhost:5001 to use the application. 

## Known Bugs
* None.

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2023 Brianca Knight