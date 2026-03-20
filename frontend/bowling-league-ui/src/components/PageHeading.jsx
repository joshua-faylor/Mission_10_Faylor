import React from "react";

/**
 * PageHeading Component
 *
 * Displays a descriptive heading for the Bowling League application.
 * This component provides context about what the page is displaying.
 */
function PageHeading() {
  return (
    <div className="page-heading">
      <h1>Bowling League Bowlers</h1>
      <p>View information about bowlers from the Marlins and Sharks teams</p>
    </div>
  );
}

export default PageHeading;
