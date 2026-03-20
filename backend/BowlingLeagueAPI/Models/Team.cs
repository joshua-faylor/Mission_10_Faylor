namespace BowlingLeagueAPI.Models
{
    /// <summary>
    /// Represents a team in the bowling league.
    /// Maps to the Teams table in the database.
    /// </summary>
    public class Team
    {
        // Primary key for the team
        public int TeamID { get; set; }

        // Name of the team (e.g., "Marlins", "Sharks")
        public string? TeamName { get; set; }

        // ID of the team captain (foreign key to Bowlers)
        public int CaptainID { get; set; }
    }
}
