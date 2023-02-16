using Microsoft.AspNetCore.Mvc;
using project.Model;

namespace PROJECT.Controllers;

[ApiController]
[Route("[controller]")]
public class BondController : ControllerBase
{
    private readonly DeltaContext _dbcontext;

    public BondController(DeltaContext dbcontext)
    {
        this._dbcontext = dbcontext;
    }

    [HttpGet(Name = "GetBond")]
    public IActionResult GetBond(){
        var db = this._dbcontext.Bonds;
        return Ok(db);
    }
}