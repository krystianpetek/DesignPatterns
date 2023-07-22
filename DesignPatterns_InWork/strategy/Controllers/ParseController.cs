using Microsoft.AspNetCore.Mvc;
using strategy.Interfaces;

namespace strategy.Controllers;

[ApiController]
[Route("[controller]")]
public class ParseController : ControllerBase
{
    private readonly Func<IEvents, IParseEventStrategy> _parseEventStrategy;

    public ParseController(Func<IEvents, IParseEventStrategy> parseEventStrategy)
    {
        _parseEventStrategy = parseEventStrategy;
    }

    [HttpGet("first")]
    public IActionResult First()
    {
        string response = _parseEventStrategy(IEvents.FirstEvent).Parse();
        return Ok(response);
    }

    [HttpGet("second")]
    public IActionResult Second()
    {
        string response = _parseEventStrategy(IEvents.SecondEvent).Parse();
        return Ok(response);
    }

    [HttpGet("third")]
    public IActionResult Third()
    {
        string response = _parseEventStrategy(IEvents.ThirdEvent).Parse();
        return Ok(response);
    }
}
