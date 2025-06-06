UtilizandoFluentAPI
<br />
A personal project by João Luiz demonstrating the use of Entity Framework Core's Fluent API for configuring entity relationships and database schema in an ASP.NET Core MVC application.

📁 Project Structure
Controllers/: MVC controllers handling HTTP requests.

Entities/: Domain entities representing the data model.

Models/: View models used for data transfer between views and controllers.

Persistence/: Contains the DbContext and Fluent API configurations.

Views/: Razor views for the user interface.

wwwroot/: Static files such as CSS, JavaScript, and images.

LiveEFCore.sln: Visual Studio solution file.

🛠️ Technologies Used
ASP.NET Core MVC

Entity Framework Core

Fluent API for model configuration

.NET Core 3.1

🚀 Getting Started
Clone the repository:

git clone https://github.com/JoaoLuizDeveloper/UtilizandoFluentAPI.git
<br />
cd UtilizandoFluentAPI
Set up the database:

Ensure you have a SQL Server instance running.

Update the connection string in appsettings.json to point to your SQL Server instance.

Apply migrations and update the database:

dotnet ef database update
Run the application:

Open LiveEFCore.sln in Visual Studio.

Press F5 to build and run the application.

The application will be available at http://localhost:5000.

📄 License
This project is licensed under the MIT License.
