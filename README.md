# StackOverflowMVC

## Overview

- An ASP.NET Core MVC web application with search functionality to retrieve the most relevant posts (Q&A) based on a keyword(s), similar to Stack Overflow, leveraging the public StackOverflow2010 database.
- Tech Stack: C#, ASP.NET Core MVC, MSSQL
- Users can easily retrieve posts with keyword searches, view paginated results with relevant details like question titles, answer descriptions, number of answers and their votes, authors’ information.

## Running the Application

1. Clone this repository into local.
2. Open Visual Studio 2019 and Click on Open and navigate to the project file "StackOverflowMVC.csproj".
3. In the menu bar, navigate to "Project", click on "Manage Nuget Packages..." and check if the following packages are installed:
- Microsoft.EntityFrameworkCore.Sqlite 8.0.3
- Microsoft.EntityFrameworkCore.SqlServer 8.0.3
- Microsoft.EntityFrameworkCore.Tools 8.0.3
- Microsoft.Extensions.Configuration 8.0.0
- Microsoft.VisualStudio.Web.CodeGeneration.Design 8.0.2
- Microsoft.EntityFrameworkCore 8.0.3
4. In the menu bar of Visual Studio, navigate to "Build" and in the dropdown, click on "Clean All". Once the clean is successful, navigate to "Build" and in the dropdown, click on "Rebuild Solution" and wait for successful build.
5. Run the project as ISS Express to get the frontend in local.