using Microsoft.AspNetCore.Mvc;
using project.Model;

namespace PROJECT.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class EquityController : ControllerBase
{
    private readonly DeltaContext dbcontext;

    public EquityController(DeltaContext dbcontext)
    {
        this.dbcontext = dbcontext;
    }

    [HttpGet(Name = "GetEquity")]
    public IActionResult GetEquity(){
        return Ok(this.dbcontext.Equities.ToList());
    }

}