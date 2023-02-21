using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
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
            SecurityDescription =  equity.SecurityDescription,
            HasPosition = equity.HasPosition,
            IsActiveSecurity = equity.IsActiveSecurity,
            LotSize = equity.LotSize,
            BbgUniqueName  = equity.BbgUniqueName,
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
        var u = await dbcontext.Equities.FindAsync(id);

        if (u != null)
        {
            u.SecurityName = equity.SecurityName;
            u.SecurityDescription =  equity.SecurityDescription;
            u.HasPosition = equity.HasPosition;
            u.IsActiveSecurity = equity.IsActiveSecurity;
            u.LotSize = equity.LotSize;
            u.BbgUniqueName  = equity.BbgUniqueName;
            u.Cusip = equity.Cusip;
            u.Isin = equity.Isin;
            u.Sedol = equity.Sedol;
            u.BloombergTicker = equity.BloombergTicker;
            u.BloombergUniqueId = equity.BloombergUniqueId;
            u.BbgGlobalId = equity.BbgGlobalId;
            u.TickerAndExchange = equity.TickerAndExchange;
            u.IsAdrFlag = equity.IsAdrFlag;
            u.AdrUnderlyingTicker = equity.AdrUnderlyingTicker;
            u.AdrUnderlyingCurrency = equity.AdrUnderlyingCurrency;
            u.SharesPerAdr = equity.SharesPerAdr;
            u.IpoDate = equity.IpoDate;
            u.PricingCurrency = equity.PricingCurrency;
            u.SettleDays = equity.SettleDays;
            u.TotalSharesOutstanding = equity.TotalSharesOutstanding;
            u.VotingRightsPerShare = equity.VotingRightsPerShare;
            u.AverageVolume20d = equity.AverageVolume20d;
            u.Beta = equity.Beta;
            u.ShortInterest = equity.ShortInterest;
            u.ReturnYtd = equity.ReturnYtd;
            u.Volatility90d = equity.Volatility90d;
            u.PfAssetClass= equity.PfAssetClass;
            u.PfCountry = equity.PfCountry;
            u.PfCreditRating = equity.PfCreditRating;
            u.PfCurrency = equity.PfCurrency;
            u.PfInstrument = equity.PfInstrument;
            u.PfLiquidityProfile = equity.PfLiquidityProfile;
            u.PfMaturity = equity.PfMaturity;
            u.PfNaicsCode  = equity.PfNaicsCode;
            u.PfRegion = equity.PfRegion;
            u.PfSector = equity.PfSector;
            u.PfSubAssetClass = equity.PfSubAssetClass;
            u.CountryOfIssuance = equity.CountryOfIssuance;
            u.Exchange = equity.Exchange;
            u.Issuer = equity.Issuer;
            u.IssueCurrency = equity.IssueCurrency;
            u.TradingCurrency = equity.TradingCurrency;
            u.BbgIndustrySubGroup = equity.BbgIndustrySubGroup;
            u.BloombergIndustryGroup = equity.BloombergIndustryGroup;
            u.BloombergSector = equity.BloombergSector;
            u.CountryOfIncorporation = equity.CountryOfIncorporation;
            u.RiskCurrency = equity.RiskCurrency;
            u.OpenPrice = equity.OpenPrice;
            u.ClosePrice = equity.ClosePrice;
            u.Volume = equity.Volume;
            u.LastPrice = equity.LastPrice;
            u.AskPrice = equity.AskPrice;
            u.BidPrice = equity.BidPrice;
            u.PeRatio = equity.PeRatio;
            u.DividendDeclaredDate  = equity.DividendDeclaredDate ;
            u.DividendExDate = equity.DividendExDate;
            u.DividendRecordDate = equity.DividendRecordDate;
            u.DividendPayDate = equity.DividendPayDate;
            u.DividendAmount = equity.DividendAmount;
            u.Frequency = equity.Frequency;
            u.DividendType = equity.DividendType;
            await dbcontext.SaveChangesAsync();

            return Ok(u);
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