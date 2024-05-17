
## TodoApp BackEnd using DotNet

TodoTaskApp is dotnet based web api created using asp dotnet boilerplate template. Go through the below steps get this project in your system.

## Versions

- TodoTaskApp requires [Asp.Net Boilerplate](https://aspnetboilerplate.com/) v8+ to run.
- MicroSoft Visual Studio 2022.
- Angular CLI version v15+ to run
- Node Js version v18+ to run
- NPM version v9+ to run


## Features

- CRUD Opertions like (get,put,post,delete)
- Using IRepository, AppService and IApplicationService created entities in the Database with Data Transfer Object
- Given these endpoints to client appication Angular

This application is server side application which gives different endpoints to the client application in this project created the Todo App with getting all todos, creaating a todo, updating a todo, deleting the todo. 

## Tech

This App uses a number of open source projects to work properly:

- [ASP.Net Boilerplate] - web core api!


## Installation

Unzip the downloaded folder from official website, and navigate to dotnet.core and run the .sln file in MS Visual Code

## Process
- Now you can see two folders src and test.
- inside src right-click on Web.Host and click on start up project.
- Set the conncetion string of SQL DB
- create DbSet with entity type class 
- add-migration "msg" and update database it will create table in the database
- create folder and create Entity Class
- Create a DTO folder and corresponding dto file and declare the class with properties like Entity
- Create AppService and IApplicationService and write the required endpionts in AppService
- Run the swagger to test the api endpoints

