# ContosoWeb
This is a N-layer concern web application.

Using SQL Server as local database to store data information. 

For the ORM, using Entity Framework code first approach to create the domain model and add migration manually to update the database.

Upper the database, creating the repository layer for building the data access layer. 

Inside repository, creating the DbContext and generic repository pattern. 

Upper the repository layer, creating the service layer to build the business logic.

both repository and service layer implemented the dependency injection, by installing the Ninject.MVC5 library. 

For the Ninject, creating one class file -- NinjectWebCommon.cs, declare the relationship between interface and concrete classes. 
-- kernel.Bind<Iservice>().To<Service>();
-- kernel.Bind<IRepository>().To<Repository>();

Front end, using MVC View to present the information

Using Git as Version Control.
