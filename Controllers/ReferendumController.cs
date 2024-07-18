using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ReferendumController : ControllerBase
{
    private readonly ReferendumContext _context;
    private readonly ILogger<ReferendumController> _logger;

    public ReferendumController(ReferendumContext context, ILogger<ReferendumController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("eager")]
    public IEnumerable<Referendum> GetWithEagerLoading()
    {
        _logger.LogInformation("Eager loading referendums with paragraphs and options.");
        var referendums = _context.Referendums
            .Include(r => r.Paragraphs)
            .Include(r => r.Options)
            .ToList();

        foreach (var referendum in referendums)
        {
            _logger.LogInformation("Referendum {Id}: ParagraphsLoaded = {ParagraphsLoaded}, OptionsLoaded = {OptionsLoaded}",
                referendum.Id,
                _context.IsCollectionLoaded(referendum, nameof(referendum.Paragraphs)),
                _context.IsCollectionLoaded(referendum, nameof(referendum.Options)));
        }

        return referendums;
    }

    [HttpGet("lazy")]
    public IActionResult GetWithLazyLoading()
    {
        _logger.LogInformation("Lazy loading referendums.");
        var referendums = _context.Referendums.ToList();

        foreach (var referendum in referendums)
        {
            _logger.LogInformation("Referendum {Id}: ParagraphsLoaded = {ParagraphsLoaded}, OptionsLoaded = {OptionsLoaded}",
                referendum.Id,
                _context.IsCollectionLoaded(referendum, nameof(referendum.Paragraphs)),
                _context.IsCollectionLoaded(referendum, nameof(referendum.Options)));
        }

        return Ok(referendums);
    }

    [HttpGet("explicit")]
    public IEnumerable<Referendum> GetWithExplicitLoading()
    {
        _logger.LogInformation("Explicit loading referendums with paragraphs and options.");
        var referendums = _context.Referendums.ToList();

        foreach (var referendum in referendums)
        {
            _context.Entry(referendum).Collection(r => r.Paragraphs).Load();
            _context.Entry(referendum).Collection(r => r.Options).Load();

            _logger.LogInformation("Referendum {Id}: ParagraphsLoaded = {ParagraphsLoaded}, OptionsLoaded = {OptionsLoaded}",
                referendum.Id,
                _context.IsCollectionLoaded(referendum, nameof(referendum.Paragraphs)),
                _context.IsCollectionLoaded(referendum, nameof(referendum.Options)));
        }

        return referendums;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Referendum referendum)
    {
        _context.Referendums.Add(referendum);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetWithEagerLoading), new { id = referendum.Id }, referendum);
    }
}