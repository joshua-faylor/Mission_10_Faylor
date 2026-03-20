namespace BowlingLeagueAPI.Models
{
    /// <summary>
    /// Represents a bowler in the bowling league.
    /// Maps to the Bowlers table in the database.
    /// </summary>
    public class Bowler
    {
        // Primary key for the bowler
        public int BowlerID { get; set; }

        // Bowler's last name (can be NULL in database)
        public string? BowlerLastName { get; set; }

        // Bowler's first name (can be NULL in database)
        public string? BowlerFirstName { get; set; }

        // Bowler's middle initial - single character, can be NULL (no middle initial)
        public string? BowlerMiddleInit { get; set; }

        // Bowler's street address (can be NULL in database)
        public string? BowlerAddress { get; set; }

        // Bowler's city (can be NULL in database)
        public string? BowlerCity { get; set; }

        // Bowler's state - abbreviation like "TX", "CA" (can be NULL in database)
        public string? BowlerState { get; set; }

        // Bowler's zip code (can be NULL in database)
        public string? BowlerZip { get; set; }

        // Bowler's phone number (can be NULL in database)
        public string? BowlerPhoneNumber { get; set; }

        // Foreign key to the Team table (can be NULL in database)
        public int? TeamID { get; set; }

        // Navigation property to the associated team
        public Team? Team { get; set; }
    }
}
