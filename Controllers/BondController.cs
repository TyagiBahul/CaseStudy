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

    [HttpGet("columns")]
    public IActionResult GetColumns(){
        var colNames = typeof(Bond).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();
        return Ok(colNames);
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
            SecurityId = bond.SecurityId,
            SecurityDescription = bond.SecurityDescription,
            SecurityName = bond.SecurityName,
            AssetType =  bond.AssetType,
            InvestmentType = bond.InvestmentType,
            TradingFactor = bond.TradingFactor,
            PricingFactor = bond.PricingFactor,
            Isin = bond.Isin,
            BbgTicker = bond.BbgTicker,
            BbgUniqueId = bond.BbgUniqueId,
            FirstCouponDate = bond.FirstCouponDate,
            Cap = bond.Cap,
            Floor = bond.Floor,
            CouponFrequency = bond.CouponFrequency,
            Coupon = bond.Coupon,
            CouponType = bond.CouponType,
            Spread = bond.Spread,
            CallableFlag = bond.CallableFlag,
            FixToFloatFlag = bond.FixToFloatFlag,
            PutableFlag = bond.PutableFlag,
            IssueDate = bond.IssueDate,
            LastResetDate = bond.LastResetDate,
            Maturity = bond.Maturity,
            CallNotificationMaxDays = bond.CallNotificationMaxDays,
            PutNotificationMaxDays = bond.PutNotificationMaxDays,
            PenultimateCouponDate = bond.PenultimateCouponDate,
            ResetFrequency = bond.ResetFrequency,
            HasPosition = bond.HasPosition,
            MacaulayDuration = bond.MacaulayDuration,
            _30dVolatility = bond._30dVolatility,
            _90dVolatility = bond._90dVolatility,
            Convexity = bond.Convexity,
            _30dayAverageVolume = bond._30dayAverageVolume,
            PfAssetClass = bond.PfAssetClass,
            PfCountry = bond.PfCountry,
            PfCreditRating = bond.PfCreditRating,
            PfCurrency = bond.PfCurrency,
            PfInstrument = bond.PfInstrument,
            PfLiquidityProfile = bond.PfLiquidityProfile,
            PfMaturity = bond.PfMaturity,
            PfNaicsCode = bond.PfNaicsCode,
            PfRegion = bond.PfRegion,
            PfSector = bond.PfSector,
            PfSubAssetClass = bond.PfSubAssetClass,
            BloombergIndustryGroup = bond.BloombergIndustryGroup,
            BloombergIndustrySubGroup = bond.BloombergIndustrySubGroup,
            BloombergIndustrySector = bond.BloombergIndustrySector,
            CountryOfIssuance = bond.CountryOfIssuance,
            IssueCurrency = bond.IssueCurrency,
            Issuer = bond.Issuer,
            RiskCurrency = bond.RiskCurrency,
            PutDate = bond.PutDate,
            PutPrice = bond.PutPrice,
            AskPrice = bond.AskPrice,
            HighPrice = bond.HighPrice,
            LowPrice = bond.LowPrice,
            OpenPrice = bond.OpenPrice,
            Volume = bond.Volume,
            BidPrice = bond.BidPrice,
            LastPrice = bond.LastPrice,
            CallDate = bond.CallDate,
            CallPrice = bond.CallPrice
        };
        await dbcontext.Bonds.AddAsync(info);
        await dbcontext.SaveChangesAsync();
        return Ok(info);
    }
    /////////////////////////////////////////////////////////////////////////////

    [HttpPatch]
    [Route("{id}")]
    public async Task<IActionResult> UpdateBond([FromRoute] int id, Bond bond)
    {
        var info = new Bond()
        {
            SecurityId = bond.SecurityId,
            SecurityDescription = bond.SecurityDescription,
            SecurityName = bond.SecurityName,
            AssetType =  bond.AssetType,
            InvestmentType = bond.InvestmentType,
            TradingFactor = bond.TradingFactor,
            PricingFactor = bond.PricingFactor,
            Isin = bond.Isin,
            BbgTicker = bond.BbgTicker,
            BbgUniqueId = bond.BbgUniqueId,
            FirstCouponDate = bond.FirstCouponDate,
            Cap = bond.Cap,
            Floor = bond.Floor,
            CouponFrequency = bond.CouponFrequency,
            Coupon = bond.Coupon,
            CouponType = bond.CouponType,
            Spread = bond.Spread,
            CallableFlag = bond.CallableFlag,
            FixToFloatFlag = bond.FixToFloatFlag,
            PutableFlag = bond.PutableFlag,
            IssueDate = bond.IssueDate,
            LastResetDate = bond.LastResetDate,
            Maturity = bond.Maturity,
            CallNotificationMaxDays = bond.CallNotificationMaxDays,
            PutNotificationMaxDays = bond.PutNotificationMaxDays,
            PenultimateCouponDate = bond.PenultimateCouponDate,
            ResetFrequency = bond.ResetFrequency,
            HasPosition = bond.HasPosition,
            MacaulayDuration = bond.MacaulayDuration,
            _30dVolatility = bond._30dVolatility,
            _90dVolatility = bond._90dVolatility,
            Convexity = bond.Convexity,
            _30dayAverageVolume = bond._30dayAverageVolume,
            PfAssetClass = bond.PfAssetClass,
            PfCountry = bond.PfCountry,
            PfCreditRating = bond.PfCreditRating,
            PfCurrency = bond.PfCurrency,
            PfInstrument = bond.PfInstrument,
            PfLiquidityProfile = bond.PfLiquidityProfile,
            PfMaturity = bond.PfMaturity,
            PfNaicsCode = bond.PfNaicsCode,
            PfRegion = bond.PfRegion,
            PfSector = bond.PfSector,
            PfSubAssetClass = bond.PfSubAssetClass,
            BloombergIndustryGroup = bond.BloombergIndustryGroup,
            BloombergIndustrySubGroup = bond.BloombergIndustrySubGroup,
            BloombergIndustrySector = bond.BloombergIndustrySector,
            CountryOfIssuance = bond.CountryOfIssuance,
            IssueCurrency = bond.IssueCurrency,
            Issuer = bond.Issuer,
            RiskCurrency = bond.RiskCurrency,
            PutDate = bond.PutDate,
            PutPrice = bond.PutPrice,
            AskPrice = bond.AskPrice,
            HighPrice = bond.HighPrice,
            LowPrice = bond.LowPrice,
            OpenPrice = bond.OpenPrice,
            Volume = bond.Volume,
            BidPrice = bond.BidPrice,
            LastPrice = bond.LastPrice,
            CallDate = bond.CallDate,
            CallPrice = bond.CallPrice
        };
        var updateBondInfo = await dbcontext.Bonds.FindAsync(id);

        if (updateBondInfo != null)
        {
            updateBondInfo.SecurityDescription = bond.SecurityDescription;
            updateBondInfo.SecurityName = bond.SecurityName;
            updateBondInfo.AssetType =  bond.AssetType;
            updateBondInfo.InvestmentType = bond.InvestmentType;
            updateBondInfo.TradingFactor = bond.TradingFactor;
            updateBondInfo.PricingFactor = bond.PricingFactor;
            updateBondInfo.Isin = bond.Isin;
            updateBondInfo.BbgTicker = bond.BbgTicker;
            updateBondInfo.BbgUniqueId = bond.BbgUniqueId;
            updateBondInfo.FirstCouponDate = bond.FirstCouponDate;
            updateBondInfo.Cap = bond.Cap;
            updateBondInfo.Floor = bond.Floor;
            updateBondInfo.CouponFrequency = bond.CouponFrequency;
            updateBondInfo.Coupon = bond.Coupon;
            updateBondInfo.CouponType = bond.CouponType;
            updateBondInfo.Spread = bond.Spread;
            updateBondInfo.CallableFlag = bond.CallableFlag;
            updateBondInfo.FixToFloatFlag = bond.FixToFloatFlag;
            updateBondInfo.PutableFlag = bond.PutableFlag;
            updateBondInfo.IssueDate = bond.IssueDate;
            updateBondInfo.LastResetDate = bond.LastResetDate;
            updateBondInfo.Maturity = bond.Maturity;
            updateBondInfo.CallNotificationMaxDays = bond.CallNotificationMaxDays;
            updateBondInfo.PutNotificationMaxDays = bond.PutNotificationMaxDays;
            updateBondInfo.PenultimateCouponDate = bond.PenultimateCouponDate;
            updateBondInfo.ResetFrequency = bond.ResetFrequency;
            updateBondInfo.HasPosition = bond.HasPosition;
            updateBondInfo.MacaulayDuration = bond.MacaulayDuration;
            updateBondInfo._30dVolatility = bond._30dVolatility;
            updateBondInfo._90dVolatility = bond._90dVolatility;
            updateBondInfo.Convexity = bond.Convexity;
            updateBondInfo._30dayAverageVolume = bond._30dayAverageVolume;
            updateBondInfo.PfAssetClass = bond.PfAssetClass;
            updateBondInfo.PfCountry = bond.PfCountry;
           updateBondInfo. PfCreditRating = bond.PfCreditRating;
            updateBondInfo.PfCurrency = bond.PfCurrency;
            updateBondInfo.PfInstrument = bond.PfInstrument;
            updateBondInfo.PfLiquidityProfile = bond.PfLiquidityProfile;
            updateBondInfo.PfMaturity = bond.PfMaturity;
            updateBondInfo.PfNaicsCode = bond.PfNaicsCode;
            updateBondInfo.PfRegion = bond.PfRegion;
            updateBondInfo.PfSector = bond.PfSector;
            updateBondInfo.PfSubAssetClass = bond.PfSubAssetClass;
            updateBondInfo.BloombergIndustryGroup = bond.BloombergIndustryGroup;
            updateBondInfo.BloombergIndustrySubGroup = bond.BloombergIndustrySubGroup;
            updateBondInfo.BloombergIndustrySector = bond.BloombergIndustrySector;
            updateBondInfo.CountryOfIssuance = bond.CountryOfIssuance;
            updateBondInfo.IssueCurrency = bond.IssueCurrency;
            updateBondInfo.Issuer = bond.Issuer;
            updateBondInfo.RiskCurrency = bond.RiskCurrency;
            updateBondInfo.PutDate = bond.PutDate;
            updateBondInfo.PutPrice = bond.PutPrice;
            updateBondInfo.AskPrice = bond.AskPrice;
            updateBondInfo.HighPrice = bond.HighPrice;
            updateBondInfo.LowPrice = bond.LowPrice;
            updateBondInfo.OpenPrice = bond.OpenPrice;
            updateBondInfo.Volume = bond.Volume;
            updateBondInfo.BidPrice = bond.BidPrice;
            updateBondInfo.LastPrice = bond.LastPrice;
            updateBondInfo.CallDate = bond.CallDate;
            updateBondInfo.CallPrice = bond.CallPrice;
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