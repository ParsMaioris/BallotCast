using Microsoft.AspNetCore.Mvc;
using BallotCast.Data;

namespace BallotCast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReferendumController : ControllerBase
    {
        private readonly ReferendumContext _context;

        public ReferendumController(ReferendumContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Referendum> Get()
        {
            return _context.Referendums.ToList();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Referendum referendum)
        {
            _context.Referendums.Add(referendum);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = referendum.Id }, referendum);
        }
    }
}