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

    [HttpGet]
    public IActionResult GetEquity()
    {
        var db = this.dbcontext.Equities;
        return Ok(db);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetEquity([FromRoute] int id)
    {
        var specificBond= await dbcontext.Equities.FindAsync(id);

        if(specificBond==null)
        return NotFound();

        return Ok(specificBond);
    }




    //////////////////////////////////////////////////////////////////////////////

    [HttpPost]
    public async Task<IActionResult> AddEquity(Equity equity)
    {
        var info = new Equity()
        {
            SecurityName = equity.SecurityName,
            SecurityDescription = equity.SecurityDescription
        };
        await dbcontext.Equities.AddAsync(info);
        await dbcontext.SaveChangesAsync();
        return Ok(info);
    }
    /////////////////////////////////////////////////////////////////////////////

    [HttpPatch]
    [Route("{id}")]
    public async Task<IActionResult> UpdateEquity([FromRoute] int id, Equity equity)
    {
        var info = new Equity()
        {
            SecurityName = equity.SecurityName,
            SecurityDescription = equity.SecurityDescription
        };
        var updateEquityInfo = await dbcontext.Equities.FindAsync(id);

        if (updateEquityInfo != null)
        {
            updateEquityInfo.SecurityDescription = equity.SecurityDescription;
            updateEquityInfo.SecurityName = equity.SecurityName;
            await dbcontext.SaveChangesAsync();

            return Ok(updateEquityInfo);
        }
        return NotFound();
    }



    /////////////////////////////////////////////////////////////////////////////

[HttpDelete]
[Route("{id}")]
    public async Task<IActionResult> DeleteEquity([FromRoute] int id){

        var deletingEquity=await dbcontext.Equities.FindAsync(id);
        
        if(deletingEquity==null)
        return NotFound();
        else{
        
        dbcontext.Remove(deletingEquity);
        dbcontext.SaveChanges();
        return Ok(deletingEquity);

        }
    }


}