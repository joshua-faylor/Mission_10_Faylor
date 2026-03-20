# Bowling League UI

This is the React frontend for the Bowling League application. It displays a table of bowlers from the Marlins and Sharks teams, fetching data from the ASP.NET Core API backend.

## Prerequisites

- Node.js and npm installed
- ASP.NET Core API running on `http://localhost:5000` (or update the API URL in `.env`)

## Project Structure

```
bowling-league-ui/
├── public/              # Static files
├── src/
│   ├── components/      # React components
│   │   ├── PageHeading.jsx      # Page title and description
│   │   └── BowlerTable.jsx      # Bowler data table
│   ├── App.js           # Main application component
│   ├── App.css          # Application styles
│   └── index.js         # React entry point
├── .env                 # Environment configuration
└── package.json         # Dependencies and scripts
```

## Installation

1. Navigate to the project directory:

   ```bash
   cd frontend/bowling-league-ui
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

## Running the Development Server

Start the React development server:

```bash
npm start
```

The app will open in your browser at `http://localhost:3000`

## Configuration

The API endpoint is configured in the `.env` file:

```
REACT_APP_API_BASE_URL=http://localhost:5000
```

Update this URL if your API is running on a different port or host.

## Components

### PageHeading

Displays a descriptive heading for the page about the Bowling League Bowlers.

### BowlerTable

Displays a table with the following columns:

- Full Name (First Middle. Last)
- Team
- Address
- City
- State
- Zip
- Phone Number

The component accepts a `bowlers` prop containing an array of bowler objects.

### App

Main component that:

- Fetches bowler data from the API on component mount
- Manages loading, error, and data states
- Renders PageHeading and BowlerTable components

## Features

- Displays only bowlers from Marlins and Sharks teams
- Shows loading indicator while fetching data
- Displays error message if API call fails
- Responsive table design
- Clean, professional styling

## Building for Production

Create an optimized production build:

```bash
npm run build
```

This will create a `build` folder with optimized files ready for deployment.

## Troubleshooting

- **API Connection Error**: Ensure the ASP.NET Core API is running on the correct port
- **No Data Displays**: Check that the `.env` file has the correct `REACT_APP_API_BASE_URL`
- **CORS Errors**: Ensure CORS is properly configured in the API
