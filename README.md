﻿# Employee Management System

The Employee Management System is a web application built using C# and Entity Framework Core. It provides a platform to manage employee records, including their personal information, job details, and more.

## Features

- User-friendly web interface for managing employee information.
- CRUD (Create, Read, Update, Delete) operations for employee records.
- Secure authentication and authorization for user access.
- Integration with a relational database using Entity Framework Core.
- Responsive design for optimal usage on various devices.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) for development.
- SQL Server (Express or higher) for storing employee data.

## Getting Started

1. Clone this repository:

   ```bash
    https://github.com/jcblanc2/EMP-Management.git

2. Open the project in your preferred development environment.

3. Update the database connection string in the appsettings.json file to point to your SQL Server instance.

4. Open the Package Manager Console and run the Entity Framework migration to create the database schema:
   ```bash
    Update-Database
   
5. Access the application in your web browser at http://localhost:5000.
