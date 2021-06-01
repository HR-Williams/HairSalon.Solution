<div align="center">

# Eau Claire's Salon

</div>

<h3 align="center">An application for a Salon Owner, 6/1/2021</h3>
<h4 align="center"> By HR Williams</h4>

## Description

An application created for an Epicodus independent project which allows a Salon owner to keep track of her stylists and the clients in relation to the styliests.

## Specifications/User Stories

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [https://github.com/HR-Williams/HairSalon.Solution]()
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone https://github.com/HR-Williams/HairSalon.Solution` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`5.0.100`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the HairSalon folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the HairSalon folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Import Database Using MySQL Workbench

- Open MySQL Workbench
- In the Admin Tab under Management Click on Data Import
- Select `Import from Self-Contained File` and navigate to HairSalon.Solution/hr_williams.sql
- Under `Default Scheme to be Imported To` select the `New` Button
- Enter a name for your database, click *ok*
- Click `Start Import`


### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- Update all the information above in the square brackets. If you named the database the same name as the .sql file that was imported, then `database =` should be `hr_williams`. Change the server, port, and uid if necessary.



</details>

##### View In Browser

- To view in browser, navigate to HairSalon folder in the command line
- Use the command `dotnet run` to execute the compiled code and start a localhost
- In browser navigate to http://localhost:5000

## Known Bugs

- I would like to finish Edit functionality for client
- I would like to style the app

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support).

## Technologies Used

- .NET Core 5.0.1
- ASP.NET Core MVC
- ASP.NET Core Razor Pages
- C#
- Entity Framework Core
- GitHub
- HTML
- MySQL
- MySQL Workbench
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 HR Williams
