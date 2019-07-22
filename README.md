# Introduction to Dependency Injection

This is the companion repository for the "Introduction to Dependency Injection" Tech Talk.

## Overview

Dependency Injection (DI) is a set of software design principles and patterns that promote loosely coupled code.

This guide starts with a multi-tier application, then examines some of the architectural issues and investigates how dependency injection can help address these concerns.

### Benefits loose coupling

* easier to extend*
* easier to test*
* easier to maintain
* facilitates parallel development - less merge conflicts
* facilitates late binding*

###	Patterns

* constructor injection*
* property injection*
* method injection
* ambient context
* service locator


### Containers

* [Autofac](https://autofac.org/)*
* [Ninject](http://www.ninject.org/)*
* [Unity Container](https://github.com/unitycontainer/unity)
* [Castle Windsor](https://github.com/castleproject/Windsor)
* [Spring.NET](http://www.springframework.net/doc-latest/reference/html/objects.html)
* [ASP.NET Core DI](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2)

[The Ultimate List of .NET Dependency Injection Frameworks](https://www.claudiobernasconi.ch/2019/01/24/the-ultimate-list-of-net-dependency-injection-frameworks/)

[List of .NET Dependency Injection Containers (IOC)](https://weblogs.asp.net/jhallal/list-of-net-dependency-injection-containers-ioc)


*indicates focus area of this talk

## Prerequisites

* [.NET core SDK 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

To verify what version of dotnet you have installed use `dotnet --version` on the command line.

## Clone the Initial Project

Clone this repository: [introduction-to-dependency-injection](https://github.com/handsome-b-wonderful/introduction-to-dependency-injection.git)

## Review the Solution Structure

* __Pets.Service__ is the web service providing data
* __Pets.DataAccess__ is the data repository
* __Pets.Presentation__ is the view model provider
* __Pets.Viewer__ is the UI application
* __Pets.Common__ includes common POCO entities

## Running the Example Application

* Build the entire solution
* open a new console window and navigate to the `/Pets.Service` directory
* `dotnet run` to start the web service

You can now run the __Pets.Viewer__ application and retrieve data from the service.
