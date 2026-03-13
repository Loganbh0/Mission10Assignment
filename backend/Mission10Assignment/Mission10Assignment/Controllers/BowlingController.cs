using Mission10Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mission10Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlingController : ControllerBase
    {
        private readonly BowlingLeagueDbContext _context;

        public BowlingController(BowlingLeagueDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetBowlers")]
        public IActionResult GetBowlers()
        {
            var bowlers = _context.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team != null &&
                           (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .Select(b => new
                {
                    bowlerID = b.BowlerID,
                    bowlerFirstName = b.BowlerFirstName,
                    bowlerMiddleInit = b.BowlerMiddleInit,
                    bowlerLastName = b.BowlerLastName,
                    bowlerAddress = b.BowlerAddress,
                    bowlerCity = b.BowlerCity,
                    bowlerState = b.BowlerState,
                    bowlerZip = b.BowlerZip,
                    bowlerPhoneNumber = b.BowlerPhoneNumber,
                    teamName = b.Team!.TeamName
                })
                .ToList();

            return Ok(bowlers);
        }
    }
}