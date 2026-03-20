import React from "react";

/**
 * BowlerTable Component
 *
 * Displays a table of bowlers with their information including:
 * - Full name (First, Middle Initial, Last)
 * - Team name
 * - Address details (Street, City, State, Zip)
 * - Phone number
 *
 * Props:
 *   bowlers (array): Array of bowler objects to display
 */
function BowlerTable({ bowlers }) {
  return (
    <div className="bowler-table-container">
      <table className="bowler-table">
        <thead>
          <tr>
            <th>Full Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {/* Map through the bowlers array and create a table row for each bowler */}
          {bowlers.map((bowler) => (
            <tr key={bowler.bowlerID}>
              {/* Format the full name: First Middle. Last */}
              <td>
                {bowler.bowlerFirstName}{" "}
                {bowler.bowlerMiddleInit && bowler.bowlerMiddleInit + ". "}
                {bowler.bowlerLastName}
              </td>
              {/* Team name - access through the team relationship */}
              <td>{bowler.team?.teamName || "N/A"}</td>
              {/* Street address */}
              <td>{bowler.bowlerAddress}</td>
              {/* City */}
              <td>{bowler.bowlerCity}</td>
              {/* State abbreviation */}
              <td>{bowler.bowlerState}</td>
              {/* Zip code */}
              <td>{bowler.bowlerZip}</td>
              {/* Phone number */}
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>

      {/* Display a message if there are no bowlers to display */}
      {bowlers.length === 0 && (
        <p className="no-data-message">
          No bowlers found. Please try again later.
        </p>
      )}
    </div>
  );
}

export default BowlerTable;
