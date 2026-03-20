using Microsoft.AspNetCore.Mvc;
using BowlingLeagueAPI.Data;
using BowlingLeagueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BowlingLeagueAPI.Controllers
{
    /// <summary>
    /// API Controller for managing bowler data.
    /// Provides endpoints to retrieve bowlers filtered by team.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BowlersController : ControllerBase
    {
        private readonly BowlingContext _context;

        // Constructor that injects the database context
        public BowlersController(BowlingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET /api/bowlers
        /// Retrieves all bowlers from the Marlins and Sharks teams.
        /// Returns bowler information including name, team, address details, and phone number.
        /// </summary>
        /// <returns>A list of bowlers and their associated team information</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bowler>>> GetBowlers()
        {
            try
            {
                // Query the database for bowlers on Marlins or Sharks teams
                // Includes the related Team data for each bowler
                var bowlers = await _context.Bowlers
                    .Include(b => b.Team)
                    .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                    .OrderBy(b => b.BowlerLastName)
                    .ThenBy(b => b.BowlerFirstName)
                    .ToListAsync();

                return Ok(bowlers);
            }
            catch (Exception ex)
            {
                // Log the full error details for debugging
                Console.WriteLine($"ERROR in GetBowlers: {ex.Message}");
                Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                
                // Return a 500 error with detailed message
                return StatusCode(500, new { 
                    message = "An error occurred while retrieving bowlers.", 
                    error = ex.Message,
                    innerError = ex.InnerException?.Message
                });
            }
        }

        /// <summary>
        /// GET /api/bowlers/{id}
        /// Retrieves a specific bowler by their ID.
        /// </summary>
        /// <param name="id">The ID of the bowler to retrieve</param>
        /// <returns>The bowler with the specified ID, or 404 if not found</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Bowler>> GetBowler(int id)
        {
            try
            {
                var bowler = await _context.Bowlers
                    .Include(b => b.Team)
                    .FirstOrDefaultAsync(b => b.BowlerID == id);

                if (bowler == null)
                {
                    return NotFound(new { message = $"Bowler with ID {id} not found." });
                }

                return Ok(bowler);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the bowler.", error = ex.Message });
            }
        }
    }
}
