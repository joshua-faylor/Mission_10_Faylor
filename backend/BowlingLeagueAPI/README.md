# Bowling League API

This is the ASP.NET Core Web API backend for the Bowling League application. It provides RESTful endpoints to retrieve bowler information from the SQLite database.

## Prerequisites

- .NET 10.0 SDK installed
- SQLite database file (`BowlingLeague.sqlite`) in the project directory

## Project Structure

```
BowlingLeagueAPI/
├── Models/               # Data models (Bowler, Team)
├── Data/                 # Database context and configuration
├── Controllers/          # API endpoint controllers
├── Program.cs            # Application startup configuration
└── BowlingLeague.sqlite  # SQLite database file
```

## Running the API

1. Navigate to the project directory:

   ```bash
   cd backend/BowlingLeagueAPI
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Run the API server:

   ```bash
   dotnet run
   ```

   The API will start on `https://localhost:5000` (or `http://localhost:5000` for HTTP)

## API Endpoints

### GET /api/bowlers

Retrieves all bowlers from the Marlins and Sharks teams, sorted by last name then first name.

**Response Example:**

```json
[
  {
    "bowlerID": 1,
    "bowlerLastName": "Doe",
    "bowlerFirstName": "John",
    "bowlerMiddleInit": "M",
    "bowlerStreetAddress": "123 Main St",
    "bowlerCity": "Springfield",
    "bowlerState": "IL",
    "bowlerZipCode": "62701",
    "bowlerPhoneNumber": "555-0123",
    "teamID": 1,
    "team": {
      "teamID": 1,
      "teamName": "Marlins",
      "captainID": 1
    }
  }
]
```

### GET /api/bowlers/{id}

Retrieves a specific bowler by ID.

## Important Notes

- CORS is configured to allow requests from any origin (suitable for development)
- The database path is hardcoded to `BowlingLeague.sqlite` in the current directory
- Only bowlers from "Marlins" and "Sharks" teams are returned by the main endpoint
