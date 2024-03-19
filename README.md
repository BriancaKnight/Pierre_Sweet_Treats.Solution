# Pierre's Sweet and Savory Bakery

### A bakery marketplace web application

#### By Brianca Knight

## Technologies Used

* C#
* .Net 6
* ASP.Net / MVC
* Entity Framework Core
* MySQL
* MySQL Workbench


## Description

This application serves as an online marketplace where a user can browse the bakery inventory by flavors or by treats. If a user is signed in with Identity they have manager-level access to create, edit, and delete items. 

## Setup/Installation Requirements

* Clone this repo from `https://github.com/BriancaKnight/Pierre_Sweet_Treats.Solution`.

* In the production sub directory (named `Bakery`) create a file named `appsettings.json` and add the following code to it:

 ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```

  Make sure to update the string with your own values for [DATABASE-NAME],[USERNAME] and [PASSWORD], without square brackets. You can name the database whatever you like. 

* In the terminal run the commands `dotnet restore` to install dependencies. 

* To set up the database schema run the command `dotnet ef database update`. 

* Run the command `dotnet watch run` to compile and run the application in development mode with a watcher. Optionally, you can run `dotnet build` to compile without running the app. 

* Open the browser to https://localhost:5001 to use the application. 

## Known Bugs 
* The treat index p tags are slightly off centered. 

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2023 Brianca Knight