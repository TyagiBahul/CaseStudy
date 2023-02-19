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


    [HttpGet("columns")]
    public IActionResult GetColumns(){
        var colNames = typeof(Equity).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();
        return Ok(colNames);
    }

    //////////////////////////////////////////////////////////////////////////////

    [HttpPost]
    public async Task<IActionResult> AddEquity(Equity equity)
    {
        var info = new Equity()
        {
            SecurityName = equity.SecurityName,
            SecurityDescription =  equity.SecurityDescription,
            HasPosition = equity.HasPosition,
            IsActiveSecurity = equity.IsActiveSecurity,
            LotSize = equity.LotSize,
            BbgUniqueName  = equity.BbgUniqueName ,
            Cusip = equity.Cusip,
            Isin = equity.Isin,
            Sedol = equity.Sedol,
            BloombergTicker = equity.BloombergTicker,
            BloombergUniqueId = equity.BloombergUniqueId,
            BbgGlobalId = equity.BbgGlobalId,
            TickerAndExchange = equity.TickerAndExchange,
            IsAdrFlag = equity.IsAdrFlag,
            AdrUnderlyingTicker = equity.AdrUnderlyingTicker,
            AdrUnderlyingCurrency = equity.AdrUnderlyingCurrency,
            SharesPerAdr = equity.SharesPerAdr,
            IpoDate = equity.IpoDate,
            PricingCurrency = equity.PricingCurrency,
            SettleDays = equity.SettleDays,
            TotalSharesOutstanding = equity.TotalSharesOutstanding,
            VotingRightsPerShare = equity.VotingRightsPerShare,
            AverageVolume20d = equity.AverageVolume20d,
            Beta = equity.Beta,
            ShortInterest = equity.ShortInterest,
            ReturnYtd = equity.ReturnYtd,
            Volatility90d = equity.Volatility90d,
            PfAssetClass= equity.PfAssetClass,
            PfCountry = equity.PfCountry,
            PfCreditRating = equity.PfCreditRating,
            PfCurrency = equity.PfCurrency,
            PfInstrument = equity.PfInstrument,
            PfLiquidityProfile = equity.PfLiquidityProfile,
            PfMaturity = equity.PfMaturity,
            PfNaicsCode  = equity.PfNaicsCode,
            PfRegion = equity.PfRegion,
            PfSector = equity.PfSector,
            PfSubAssetClass = equity.PfSubAssetClass,
            CountryOfIssuance = equity.CountryOfIssuance,
            Exchange = equity.Exchange,
            Issuer = equity.Issuer,
            IssueCurrency = equity.IssueCurrency,
            TradingCurrency = equity.TradingCurrency,
            BbgIndustrySubGroup = equity.BbgIndustrySubGroup,
            BloombergIndustryGroup = equity.BloombergIndustryGroup,
            BloombergSector = equity.BloombergSector,
            CountryOfIncorporation = equity.CountryOfIncorporation,
            RiskCurrency = equity.RiskCurrency,
            OpenPrice = equity.OpenPrice,
            ClosePrice = equity.ClosePrice,
            Volume = equity.Volume,
            LastPrice = equity.LastPrice,
            AskPrice = equity.AskPrice,
            BidPrice = equity.BidPrice,
            PeRatio = equity.PeRatio,
            DividendDeclaredDate  = equity.DividendDeclaredDate ,
            DividendExDate = equity.DividendExDate,
            DividendRecordDate = equity.DividendRecordDate,
            DividendPayDate = equity.DividendPayDate,
            DividendAmount = equity.DividendAmount,
            Frequency = equity.Frequency,
            DividendType = equity.DividendType
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