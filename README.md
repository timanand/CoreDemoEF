# CoreDemoEF

CoreDemoEF is a an ASP.NET Core Application that does CRUD (Create, Read, Update and Delete) operations on a SQL Server Database.


## Pre-Requisite
The following are mandatory for the CoreDemoEF application to run :

1. Microsoft .NET Core 5.0 Runtime or SDK.
2. Microsoft SQL Server. 


## Installation

1. Run Visual Studio 2019

2. Select 'Clone a repository'

 	Repository location: 
 	https://github.com/timanand/CoreDemoEF.git

 	Path:
 	This is the location on your computer where Repository shall be copied to. For example: 'C:\DEVELOP\CoreDemoEF\'.

 	Click on 'Clone' button.




3. On the right side, you will see the Solution Explorer window. Double click on 'CoreDemoEF.sln'.



4. From 'Build' menu, select 'Rebuild Solution'. 
	--> It will say : 
		
		- Rebuild All: 3 succeeded


5. Goto Solution Explorer

	Click CoreDemoEF.Application
		Click 'appsettings.json'
		
			Update the following based on your SQL Server Management Studio settings:
			
			Data Source=
			User Id=
			Password=
			


6. From 'Build' menu, select 'Rebuild Solution'.
	--> It will say : 
		
		- Rebuild All: 3 succeeded


7. From 'Tools' menu, select 'NuGet Package Manager' - 'Package Manager Console'

	PM> Update-Database
	--> It will say :
	
		- Build started

		- Build succeeded
		
		- Done.


8. Step 7 creates Database, 'CoreDemoEF' and Table : 'dbo.StaffMembers' in SQL Server.


9. Load Stored Procedure, 'sp_getEmployees' into CoreDemoEF SQL Server Database by following the instructions:

	i. Run SQL Server Management Studio or Equivalent

	ii. Sign onto System

	iii. In Explorer, double click on file, '\CoreDemoEF\CoreDemoEF.Application\SQL Server Files\sp_getEmployees.sql'
	It will display the contents of 'sp_getEmployees.sql'.

	iv. Run the Execute command or equivalent to run the query which will load the stored procedure into the database.



## Usage

Press F5 or click on the Play button icon from the toolbar in Visual Studio 2019 for the above solution.

When you run the Web application it will allow the ability to Create, Update and Delete Staff Members.




## License & Copyright

(c) 2021 Arvinder Anand (Tim)
