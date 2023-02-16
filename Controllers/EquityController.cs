using Microsoft.AspNetCore.Mvc;
using project.Model;

namespace PROJECT.Controllers;

[ApiController]
[Route("[controller]")]
public class EquityController : ControllerBase
{
    private readonly DeltaContext _dbcontext;

    public EquityController(DeltaContext dbcontext)
    {
        this._dbcontext = dbcontext;
    }

    [HttpGet(Name = "GetEquity")]
    public IActionResult GetEquity(){
        var db = this._dbcontext.Equities;
        return Ok(db);
    }
}