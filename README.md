# Fitness Membership Management System

## Features

- **Membership Management**: Create, retrieve, update, and delete memberships with details such as type, price, duration, and benefits.
- **Member Management**: Create, retrieve, update, and delete member profiles with details such as name, email, date of birth, and gender.
- **Search and Filtering**: Search for memberships and members based on various criteria, such as membership type, price range, and duration.
- **Authentication and Authorization**: Secure API endpoints with authentication and authorization mechanisms to protect sensitive data.
- **Data Persistence**: Store membership and member data in a relational database for efficient data management.

#Still in Progress :
- **Authentication and Authorization**: Secure API endpoints with authentication and authorization mechanisms to protect sensitive data.

## Technologies Used

- **ASP.NET Core**: Framework for building web APIs and console applications.
- **Entity Framework Core**: ORM for interacting with the database.
- **Swagger**: API documentation and testing tool for easy API exploration.
- **JSON Web Tokens (JWT)**: Authentication mechanism for securing API endpoints.
- **SQL Server**: Relational database for persistent data storage.
- 
## Project Structure


### 1. API (Application Programming Interface): Membership.ProAPI

The API component provides web services for managing memberships and members. 

- **Controllers**: Contains ASP.NET Core MVC controllers for handling HTTP requests and routing them to appropriate actions.
- **Services**: Implements business logic and interacts with the data access layer to perform CRUD operations on memberships and members.
- **Data Access Layer**: Defines database models and sets up the database context for Entity Framework Core.
- **DTOs (Data Transfer Objects)**: Contains classes for transferring data between the API and client applications.

### 2. Console Application: FitnessApp


## Getting Started

To run the Fitness Membership Management System on your local machine, follow these steps:

1. **Clone the Repository**: Clone this repository to your local machine using Git.
2. **Set up the Database**: Ensure that you have SQL Server installed locally. Update the connection string in the `appsettings.json` file with your database credentials.
3. **Install Dependencies**: Navigate to the project directory and install the required NuGet packages for both the API and console application.
4. **Run Migrations**: Apply any pending database migrations to create the necessary tables in the database.
5. **Start the API**: Run the API application to start the web server.
6. **Explore the API**: Open your web browser and navigate to `https://localhost:5001/swagger` to access the Swagger UI. Here, you can explore and test the API endpoints.

## Configuration

The application settings are stored in the `appsettings.json` file. Customize the settings as needed for your environment, such as database connection strings, authentication settings(still in progress), etc.
For the Jwt key property , I will be using a random string generator.

## Authentication

The API uses JSON Web Tokens (JWT) for authentication. To access protected endpoints, obtain a JWT token by authenticating with valid credentials. Include the token in the `Authorization` header of your HTTP requests.

## Packages 
-Microsoft.EntityFrameworkCore
-Microsoft.EntityFrameworkCore.Tools
-Microsoft.EntityFramwwork.SqlServer
Package Regarding the Authentication and Authorization with JWT (Json Web Token)
- Microsoft.AspNetCore.Authentication.JwtBearer 
- Microsoft.IdentityModel.Tokens 
- System.IdentityModel.Tokens.Jwt 
