# Sprout.Exam.WebApp

## How I answered the requirement for this exam
### Database Portion

To be able to communicate to database, I followed the dependency injection and repository pattern for the abstraction layers and installed the EntityFrameworkCore 
NuGet package to perform database manipulation operations (CRUD).

The **EmployeesController** was edited to replace the functions that came from StaticEmployees class. I then created the dependency injection abstraction services and registered it in the
Startup class and have a constructor dependency added in the EmployeesController. The services are found in the following class files under the Sprout.Exam.Business namespace:

 * IEmployeeDAL.cs
 * EmployeeDAL.cs
 
 To be able to communicate to the appsettings.json file to get the connection string, a service was created and added as a constructor dependency to the Employee Data Access Layer class file:
 
 * IDatabaseManager.cs
 * DatabaseManager.cs
 
 
### Calculate Portion

Following the requirement in the commented section of the Calculate method which is to utilize the Factory pattern, the class file where the factory pattern is implemented is located under the Sprout.Exam.Business namespace:

* EmployeeFactory.cs

The parameter of the Calculate method was changed to a view-model since the annotation of HttpPost was implemented in the method.


## Answering the question requirement

 * "If we are going to deploy this on production, what do you think is the next improvement that you will prioritize next? This can be a feature, a tech debt, or an architectural design" *

The feature that this app lacks is the logging ability. I will add a logging abstraction service and implement a constructor dependency injection in the controller so that there will be a log everytime an API call is invoked.


