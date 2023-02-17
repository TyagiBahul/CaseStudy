using Microsoft.AspNetCore.Mvc;
using project.Model;

namespace PROJECT.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class BondController : ControllerBase
{
    private readonly DeltaContext dbcontext;

    public BondController(DeltaContext dbcontext)
    {
        this.dbcontext = dbcontext;
    }

    [HttpGet]
    public IActionResult GetBond()
    {
        var db = this.dbcontext.Bonds;
        return Ok(db);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetBond([FromRoute] int id)
    {
        var specificBond= await dbcontext.Bonds.FindAsync(id);

        if(specificBond==null)
        return NotFound();

        return Ok(specificBond);
    }




    //////////////////////////////////////////////////////////////////////////////

    [HttpPost]
    public async Task<IActionResult> AddBond(Bond bond)
    {
        var info = new Bond()
        {
            SecurityName = bond.SecurityName,
            SecurityDescription = bond.SecurityDescription
        };
        await dbcontext.Bonds.AddAsync(info);
        await dbcontext.SaveChangesAsync();
        return Ok(info);
    }
    /////////////////////////////////////////////////////////////////////////////

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateBond([FromRoute] int id, Bond bond)
    {
        var info = new Bond()
        {
            SecurityName = bond.SecurityName,
            SecurityDescription = bond.SecurityDescription
        };
        var updateBondInfo = await dbcontext.Bonds.FindAsync(id);

        if (updateBondInfo != null)
        {
            updateBondInfo.SecurityDescription = bond.SecurityDescription;
            updateBondInfo.SecurityName = bond.SecurityName;
            await dbcontext.SaveChangesAsync();

            return Ok(updateBondInfo);
        }
        return NotFound();
    }



    /////////////////////////////////////////////////////////////////////////////

[HttpDelete]
[Route("{id}")]
    public async Task<IActionResult> DeleteBond([FromRoute] int id){

        var deletingBond=await dbcontext.Bonds.FindAsync(id);
        
        if(deletingBond==null)
        return NotFound();
        else{
        
        dbcontext.Remove(deletingBond);
        dbcontext.SaveChanges();
        return Ok(deletingBond);

        }
    }


}