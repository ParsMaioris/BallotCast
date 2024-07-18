# BallotCast API

**BallotCast API** is a simple referendum voting API built to help learn Entity Framework Core with .NET 8. This project serves as an educational tool to understand the basics of setting up Entity Framework Core, handling database migrations, and integrating it into a .NET application. SQLite is used as the database provider.

## Features

- **Entity Framework Core**: Learn how to set up and use EF Core for data access.
- **SQLite Integration**: Uses SQLite for data storage which makes it easy to set up and portable.
- **Swagger Integration**: Provides an interactive API documentation and testing interface.

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQLite

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/ParsMaioris/BallotCast.git
   ```

2. **Navigate to the project directory**
    ```
    cd BallotCast
    ```

3.	**Install the .NET EF tool (if not already installed globally)**
    ```
    dotnet tool install --global dotnet-ef
    ```

### Running the Application

1.	**Run the application**
    ```
    dotnet run
    ```

2.	**Access the Swagger UI** at http://localhost:5109/index.html to interact with the API.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any bugs or enhancements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.