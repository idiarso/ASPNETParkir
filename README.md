# Parking Management System

A web-based parking management system built with ASP.NET Core that helps manage parking spaces, vehicles, and parking tickets efficiently.

## Features

- Vehicle management (registration, tracking)
- Parking space allocation and monitoring
- Parking ticket generation and management
- Real-time parking space availability

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core 9.0.2
- SQL Server (LocalDB)
- C#
- MVC Architecture

## Prerequisites

- .NET 8.0 SDK
- SQL Server LocalDB
- Visual Studio 2022 (recommended) or VS Code

## Getting Started

1. Clone the repository
2. Ensure SQL Server LocalDB is installed
3. Update the connection string in `appsettings.json` if needed
4. Open terminal in the project directory and run:
   ```bash
   dotnet ef database update
   dotnet run
   ```

## Database Configuration

The application uses SQL Server LocalDB with Entity Framework Core. The connection string is configured in `appsettings.json`:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ParkingManagementSystem;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

## Project Structure

- `Controllers/`: MVC Controllers
- `Models/`: Entity models (Vehicle, ParkingSpace, ParkingTicket)
- `Data/`: Database context and configurations
- `Views/`: MVC views
- `wwwroot/`: Static files (CSS, JavaScript, etc.)

## Features Details

### Vehicle Management
- Register new vehicles
- Track vehicle information
- Associate vehicles with parking spaces

### Parking Space Management
- Monitor parking space availability
- Assign/remove vehicles from spaces
- Track space occupancy history

### Parking Ticket System
- Generate parking tickets
- Track parking duration
- Manage parking fees

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.