# Project Title

GlobalErrorHandling

## Description

This simple solution tries to outline an easy way to handle exceptions in a .NET 8 Web API project.
2 different handlers have been implemented:
- Validation: intercepts all the exceptions caused by failed data validations performed by FluentValidation. It is an example for more fine grained control over the exception handling.
- Global: handles all the exception that have not been intercepted by other exception handlers.
   

### Dependencies

.NET 8

### Installing

Download the project from the repo and you are ready to go.

### Executing program

Either:
- Open the project with Visual Studio and run it, or
- Run the "dotnet run" command from the root folder of the project.

The app should be available at this url http://localhost:5003/customers?id=1


## Version History

0.1
    Initial Release


## Acknowledgments

This project is based completely on the following article written by Milan Jovanović:
[Global Error Handling in ASP.NET Core: From Middleware to Modern Handlers](https://www.milanjovanovic.tech/blog/global-error-handling-in-aspnetcore-from-middleware-to-modern-handlers)