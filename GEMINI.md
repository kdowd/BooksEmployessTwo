# Project Overview

This is a C# WPF desktop application designed to display information about books and employees. The application retrieves data from a MongoDB database and presents it in a tabular format.

## Technologies Used

*   **.NET/C# with WPF:** For the application framework and user interface.
*   **MongoDB:** As the backend database for storing book and employee data.
*   **MongoDB.Driver:** The official .NET driver for MongoDB is used for database communication.

## Architecture

*   **Main Application:** The main window and application logic are contained within `MainWindow.xaml` and `MainWindow.xaml.cs`.
*   **Database Connection:** The `Database/Connection.cs` class manages the connection to the MongoDB Atlas cluster.
*   **Data Models:** The `ORM` (Object-Relational Mapping) directory contains the C# classes (`BookDTO.cs`, `EmployeeDTO.cs`) that model the data retrieved from the database.

## Building and Running

To build and run this project:

1.  **Restore Dependencies:** Ensure the `MongoDB.Driver` NuGet package is restored. This should happen automatically when you build the project in Visual Studio.
2.  **Build:** Build the solution in Visual Studio.
3.  **Run:** Run the application from Visual Studio.

**Note:** The application connects to a MongoDB Atlas cluster. The connection string is currently hardcoded in `Database/Connection.cs`. You may need to update this with your own MongoDB connection string.

## Development Conventions

*   **Data Models:** Data is modeled using DTOs (Data Transfer Objects) in the `ORM` folder.
*   **Database Logic:** All database-related code, including the connection, is centralized in the `Database` folder.
*   **UI:** The user interface is built with WPF and the main data display is a `DataGrid` control.
