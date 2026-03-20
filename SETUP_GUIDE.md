# Bowling League Application - Setup Guide

This is a full-stack web application that displays bowler information from the Bowling League database. The application consists of an ASP.NET Core API backend and a React frontend.

## Project Structure

```
Mission_10_Faylor/
├── backend/
│   └── BowlingLeagueAPI/       # ASP.NET Core Web API
│       ├── Controllers/         # API endpoints
│       ├── Models/             # Data models (Bowler, Team)
│       ├── Data/               # Database context
│       ├── Program.cs          # API configuration
│       ├── BowlingLeague.sqlite # SQLite database
│       └── README.md           # Backend documentation
├── frontend/
│   └── bowling-league-ui/      # React application
│       ├── public/             # Static files
│       ├── src/
│       │   ├── components/     # React components
│       │   ├── App.js          # Main app component
│       │   └── App.css         # Styles
│       ├── .env                # Environment configuration
│       └── README_BOWLING.md   # Frontend documentation
├── BowlingLeague.sqlite        # Original database file
└── Setup Instructions (this file)
```

## Prerequisites

- **.NET 10.0 SDK** - Download from https://dotnet.microsoft.com/download
- **Node.js & npm** - Download from https://nodejs.org/
- **A terminal/command prompt**

## Quick Start

### 1. Start the ASP.NET Core API Backend

```bash
# Navigate to the backend directory
cd backend/BowlingLeagueAPI

# Restore dependencies
dotnet restore

# Run the API server
dotnet run
```

The API will start on `http://localhost:5000` (or `https://localhost:5001` for HTTPS)

### 2. Start the React Frontend (in a new terminal)

```bash
# Navigate to the frontend directory
cd frontend/bowling-league-ui

# Install dependencies (first time only)
npm install

# Start the development server
npm start
```

The React app will automatically open in your browser at `http://localhost:3000`

## Architecture

### Backend (ASP.NET Core)

**Key Components:**

- `BowlersController` - Handles HTTP GET requests for bowler data
- `BowlingContext` - Entity Framework Core DbContext for database access
- `Bowler` & `Team` Models - Data models representing database entities

**API Endpoint:**

- `GET /api/bowlers` - Returns all bowlers from Marlins and Sharks teams

**Configuration:**

- CORS enabled to allow requests from React frontend
- SQLite database connection configured in `Program.cs`
- Entity Framework Core handles data mapping

### Frontend (React)

**Key Components:**

- `App.jsx` - Main component that fetches data and manages application state
- `PageHeading.jsx` - Displays the page title and description
- `BowlerTable.jsx` - Renders the bowler data in a table format

**Features:**

- Uses `useEffect` hook to fetch data on component mount
- Manages loading and error states
- Displays formatted bowler information including full name, team, address, and phone

## Features Implemented

✅ ASP.NET Core Web API with SQLite database integration
✅ Database filtering - Only displays Marlins and Sharks team bowlers
✅ RESTful API endpoint `/api/bowlers`
✅ CORS configuration for frontend communication
✅ React components:

- PageHeading component for page title
- BowlerTable component with formatted data display
- App component with API integration
  ✅ Complete error handling and loading states
  ✅ Professional styling with responsive design
  ✅ Comprehensive code comments for maintainability

## Bowler Information Displayed

For each bowler, the application displays:

- **Full Name** - First, Middle Initial, Last Name
- **Team Name** - Either "Marlins" or "Sharks"
- **Address** - Street address
- **City** - Bowler's city
- **State** - State abbreviation
- **Zip Code** - Postal code
- **Phone Number** - Contact phone number

## Troubleshooting

### "API Connection Error" in React app

- Ensure the ASP.NET Core API is running on `http://localhost:5000`
- Check the `.env` file in the frontend directory
- Try updating the API URL in `App.js` if using a different port

### Database file not found

- Ensure `BowlingLeague.sqlite` is in the `backend/BowlingLeagueAPI/` directory
- The file should have been copied during setup

### CORS errors

- CORS is configured to accept all origins in development mode
- If errors persist, check `Program.cs` in the backend

### npm install fails

- Try clearing npm cache: `npm cache clean --force`
- Delete `node_modules` folder and `package-lock.json`
- Run `npm install` again

## Development Notes

- The API uses Entity Framework Core to abstract database operations
- Bowlers are automatically filtered by team name in the API query
- React state management uses hooks (useState, useEffect)
- All code includes comments for easy understanding and maintenance
- The table uses semantic HTML for accessibility

## Next Steps / Future Enhancements

Possible improvements for future versions:

- Add search/filter functionality
- Implement sorting by column
- Add pagination for large datasets
- Create edit/add/delete functionality
- Add authentication and authorization
- Implement data validation
- Add unit tests
- Deploy to cloud service (Azure, AWS)

## Files Modified/Created

**Backend Files:**

- `Program.cs` - Server configuration
- `Models/Bowler.cs` - Bowler entity model
- `Models/Team.cs` - Team entity model
- `Data/BowlingContext.cs` - Database context
- `Controllers/BowlersController.cs` - API endpoint
- `README.md` - Backend documentation

**Frontend Files:**

- `src/App.js` - Main application component
- `src/App.css` - Application styles
- `src/components/PageHeading.jsx` - Page heading component
- `src/components/BowlerTable.jsx` - Bowler table component
- `.env` - Environment configuration
- `README_BOWLING.md` - Frontend documentation

## Support

For issues or questions:

1. Check the respective README files in backend and frontend directories
2. Review code comments throughout the application
3. Ensure all prerequisites are installed
4. Verify API is running before starting React app
5. Check browser console for error messages
