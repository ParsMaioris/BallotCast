using BallotCast.Application;
using Microsoft.AspNetCore.Mvc;

namespace BallotCast.API;

[ApiController]
[Route("api/[controller]")]
public class VoterController : ControllerBase
{
    private readonly VoterCommandService _voterCommandService;
    private readonly VoterQueryService _voterQueryService;

    public VoterController(VoterCommandService voterCommandService, VoterQueryService voterQueryService)
    {
        _voterCommandService = voterCommandService;
        _voterQueryService = voterQueryService;
    }

    // GET: api/voter
    [HttpGet]
    public async Task<ActionResult<IEnumerable<VoterDto>>> GetAllVoters()
    {
        var voters = await _voterQueryService.GetAllVotersAsync();
        return Ok(voters);
    }

    // GET: api/voter/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<VoterDto>> GetVoterById(int id)
    {
        var voter = await _voterQueryService.GetVoterByIdAsync(id);
        if (voter == null)
        {
            return NotFound();
        }
        return Ok(voter);
    }

    // GET: api/voter/insights/{id}
    [HttpGet("insights/{id}")]
    public async Task<ActionResult<VoterInsightsDto>> GetVoterInsights(int id)
    {
        var insights = await _voterQueryService.GetVoterInsightsAsync(id);
        if (insights == null)
        {
            return NotFound();
        }
        return Ok(insights);
    }

    // POST: api/voter
    [HttpPost]
    public async Task<ActionResult> AddVoter([FromBody] VoterRequestDto voterRequestDto)
    {
        await _voterCommandService.AddVoterAsync(voterRequestDto);
        return CreatedAtAction(nameof(GetVoterById), new { id = voterRequestDto.Id }, voterRequestDto);
    }

    // PUT: api/voter/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateVoter(int id, [FromBody] VoterRequestDto voterRequestDto)
    {
        if (id != voterRequestDto.Id)
        {
            return BadRequest();
        }

        await _voterCommandService.UpdateVoterAsync(voterRequestDto);
        return NoContent();
    }

    // DELETE: api/voter/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteVoter(int id)
    {
        await _voterCommandService.DeleteVoterAsync(id);
        return NoContent();
    }
}