import React, { useState, useEffect } from "react";
import "./App.css";
import PageHeading from "./components/PageHeading";
import BowlerTable from "./components/BowlerTable";

/**
 * App Component
 *
 * Main application component that:
 * 1. Fetches bowler data from the ASP.NET API endpoint
 * 2. Manages loading and error states
 * 3. Renders the PageHeading and BowlerTable components
 */
function App() {
  // State to store the list of bowlers
  const [bowlers, setBowlers] = useState([]);

  // State to track whether data is currently loading
  const [loading, setLoading] = useState(true);

  // State to store any error messages that occur during data fetching
  const [error, setError] = useState(null);

  /**
   * Effect hook that runs once when the component mounts.
   * Fetches bowler data from the API endpoint.
   */
  useEffect(() => {
    // Define an async function to fetch bowlers
    const fetchBowlers = async () => {
      try {
        // Set loading to true while fetching
        setLoading(true);

        // Call the API endpoint on the ASP.NET backend
        // The API runs on http://localhost:7000 (HTTP port 7000, avoiding macOS port 5000)
        const response = await fetch("http://localhost:7000/api/bowlers");

        // Check if the response was successful
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }

        // Parse the JSON response
        const data = await response.json();

        // Update state with the fetched bowlers
        setBowlers(data);

        // Clear any previous errors
        setError(null);
      } catch (err) {
        // Log the error and set it in state for display
        console.error("Error fetching bowlers:", err);
        setError(
          err.message ||
            "Failed to fetch bowlers. Please ensure the API is running.",
        );
      } finally {
        // Set loading to false when the request completes (success or error)
        setLoading(false);
      }
    };

    // Call the fetch function
    fetchBowlers();
  }, []); // Empty dependency array means this effect runs only once on component mount

  return (
    <div className="App">
      {/* Render the page heading */}
      <PageHeading />

      {/* Display loading message while data is being fetched */}
      {loading && <p className="loading-message">Loading bowlers...</p>}

      {/* Display error message if an error occurred during fetching */}
      {error && <p className="error-message">Error: {error}</p>}

      {/* Render the bowler table with the fetched data (only if not loading and no error) */}
      {!loading && !error && <BowlerTable bowlers={bowlers} />}
    </div>
  );
}

export default App;
