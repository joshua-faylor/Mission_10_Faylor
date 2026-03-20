# Quick Start - Run the Application

## Terminal 1: Start the ASP.NET Core API

```bash
cd backend/BowlingLeagueAPI
dotnet run
```

**Expected output:**

```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to exit.
```

## Terminal 2: Start the React Frontend

```bash
cd frontend/bowling-league-ui
npm start
```

**Expected output:**

```
Compiled successfully!

You can now view bowling-league-ui in the browser.

  Local:            http://localhost:3000
```

The React app should automatically open in your browser showing the Bowling League application.

## What You Should See

1. **Page Heading** - "Bowling League Bowlers"
2. **Description** - "View information about bowlers from the Marlins and Sharks teams"
3. **Data Table** with columns:
   - Full Name
   - Team
   - Address
   - City
   - State
   - Zip
   - Phone Number

4. **Data** - All bowlers from the Marlins and Sharks teams with their information

## If Something Doesn't Work

1. **Check API is running** - You should see "Now listening on: https://localhost:5001" or similar
2. **Check React started** - Browser should show app (not a blank page or error)
3. **Check browser console** - Press F12 or Ctrl+Shift+I, check Console tab for errors
4. **Verify database file** - `BowlingLeague.sqlite` should be in `backend/BowlingLeagueAPI/`
5. **Check .env file** - Should have `REACT_APP_API_BASE_URL=http://localhost:5000`

## Common Issues

| Issue                     | Solution                                                                        |
| ------------------------- | ------------------------------------------------------------------------------- |
| "Cannot GET /api/bowlers" | API not running - start it in Terminal 1                                        |
| "CORS error" in console   | API CORS config issue - check Program.cs                                        |
| "No data displays"        | Check API is returning data with Postman at `http://localhost:5000/api/bowlers` |
| "Cannot find module"      | Run `npm install` in the frontend directory                                     |
| Port already in use       | Change port in code or kill process using the port                              |

## To Stop the Applications

- **Backend:** Press `Ctrl+C` in Terminal 1
- **Frontend:** Press `Ctrl+C` in Terminal 2

## API Testing (Optional)

Test the API directly using curl or Postman:

```bash
# Test the API endpoint
curl http://localhost:5000/api/bowlers

# Or with HTTPS
curl https://localhost:5001/api/bowlers
```

You should see a JSON response with bowler data.
