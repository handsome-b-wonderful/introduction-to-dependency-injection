# Introduction to Dependency Injection

This is the companion repository for the "Introduction to Dependency Injection" Tech Talk.

## Overview

Dependency Injection (DI) is a set of software design principles and patterns that promote loosely coupled code.

This guide starts with a multi-tier application, then examines some of the architectural issues and investigates how dependency injection can help address these concerns.

### Benefits loose coupling

* easier to extend
* easier to test
* easier to maintain
* facilitates parallel development - less merge conflicts
* facilitates late binding

###	Patterns

* constructor injection*
* property injection*
* method injection
* service locator

*indicates focus area of this talk

### Containers

* [Autofac](https://autofac.org/)
* [Ninject](http://www.ninject.org/)
* [Unity Container](https://github.com/unitycontainer/unity)
* [Castle Windsor](https://github.com/castleproject/Windsor)
* [Spring.NET](http://www.springframework.net/doc-latest/reference/html/objects.html)
* [ASP.NET Core DI](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2)

[The Ultimate List of .NET Dependency Injection Frameworks](https://www.claudiobernasconi.ch/2019/01/24/the-ultimate-list-of-net-dependency-injection-frameworks/)

[List of .NET Dependency Injection Containers (IOC)](https://weblogs.asp.net/jhallal/list-of-net-dependency-injection-containers-ioc)

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

If you wish to change out data sources:

1. Retrieve the repository commit that includes the desired data reader
2. Ensure the backing data source is configured and setup correctly (i.e. Sql Server schema is created, populated and connection string defined)
3. Update __App.xaml.cs__ to pass in the target reader:

```csharp
public partial class App : Application
{
	protected override void OnStartup(StartupEventArgs e)
	{
		base.OnStartup(e);

		// remove the Service reader
		// ComposeService();
		
		// replace with the Csv reader
		ComposeCsv();
		Application.Current.MainWindow.Show();
	}

	private static void ComposeCsv()
	{
		var reader = new CsvReader();
		var viewModel = new PetsViewModel(reader);
		Application.Current.MainWindow = new PetViewerWindow(viewModel);
	}

	private static void ComposeService()
	{
		var reader = new ServiceReader();
		var viewModel = new PetsViewModel(reader);
		Application.Current.MainWindow = new PetViewerWindow(viewModel);
	}
}
```
