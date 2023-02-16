using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace project.Model
{
    public partial class DeltaContext : DbContext
    {
        public DeltaContext()
        {
        }

        public DeltaContext(DbContextOptions<DeltaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditBond> AuditBonds { get; set; } = null!;
        public virtual DbSet<Bond> Bonds { get; set; } = null!;
        public virtual DbSet<Equity> Equities { get; set; } = null!;
        public virtual DbSet<EquityAudit> EquityAudits { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = 192.168.0.13\\\\\\\\sqlexpress,58264; Database =Delta;\n User = sa; Password=sa@12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditBond>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Audit Bonds");

                entity.Property(e => e.BondId).HasColumnName("Bond Id");

                entity.Property(e => e.NewAskPrice).HasColumnName("New Ask Price");

                entity.Property(e => e.NewAssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Asset Type");

                entity.Property(e => e.NewAvgVolume30days).HasColumnName("New AvgVolume 30days");

                entity.Property(e => e.NewBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Industry Group");

                entity.Property(e => e.NewBbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Industry Sector");

                entity.Property(e => e.NewBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Industry SubGroup");

                entity.Property(e => e.NewBbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Ticker");

                entity.Property(e => e.NewBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG UniqueID");

                entity.Property(e => e.NewBidPrice).HasColumnName("New Bid Price");

                entity.Property(e => e.NewCallDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New CallDate");

                entity.Property(e => e.NewCallPrice).HasColumnName("New CallPrice");

                entity.Property(e => e.NewConvexity).HasColumnName("New Convexity");

                entity.Property(e => e.NewCouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Coupon Cap");

                entity.Property(e => e.NewCouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Coupon Floor");

                entity.Property(e => e.NewCouponFrequency).HasColumnName("New Coupon Frequency");

                entity.Property(e => e.NewCouponRate).HasColumnName("New Coupon Rate");

                entity.Property(e => e.NewCouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Coupon Type");

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New CUSIP");

                entity.Property(e => e.NewFirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New First CouponDate");

                entity.Property(e => e.NewHasPosition).HasColumnName("New Has Position");

                entity.Property(e => e.NewHighPrice).HasColumnName("New High Price");

                entity.Property(e => e.NewInvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Investment Type");

                entity.Property(e => e.NewIsCallable).HasColumnName("New IS Callable");

                entity.Property(e => e.NewIsFixToFloat).HasColumnName("New IsFixToFloat");

                entity.Property(e => e.NewIsPutable).HasColumnName("New IsPutable");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New ISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Issue Country");

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Issue Currency");

                entity.Property(e => e.NewIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New IssueDate");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Issuer");

                entity.Property(e => e.NewLastPrice).HasColumnName("New Last Price");

                entity.Property(e => e.NewLastResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New LastResetDate");

                entity.Property(e => e.NewLowPrice).HasColumnName("New Low Price");

                entity.Property(e => e.NewMacaulayDuration).HasColumnName("New Macaulay Duration");

                entity.Property(e => e.NewMaturity)
                    .HasColumnType("datetime")
                    .HasColumnName("New Maturity");

                entity.Property(e => e.NewMaxCallNoticeDays).HasColumnName("New MaxCallNoticeDays");

                entity.Property(e => e.NewMaxPutNoticeDays)
                    .HasColumnType("datetime")
                    .HasColumnName("New MaxPutNoticeDays");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New Open Price");

                entity.Property(e => e.NewPenultimateCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Penultimate CouponDate");

                entity.Property(e => e.NewPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF AssetClass");

                entity.Property(e => e.NewPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Country");

                entity.Property(e => e.NewPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF CreditRating");

                entity.Property(e => e.NewPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Currency");

                entity.Property(e => e.NewPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Instrument");

                entity.Property(e => e.NewPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF LiquidityProfile");

                entity.Property(e => e.NewPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Maturity");

                entity.Property(e => e.NewPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF NAICS Code");

                entity.Property(e => e.NewPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Region");

                entity.Property(e => e.NewPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Sector");

                entity.Property(e => e.NewPfSubAssetClass)
                    .HasMaxLength(59)
                    .IsUnicode(false)
                    .HasColumnName("New PF SubAssetClass");

                entity.Property(e => e.NewPricingFactor).HasColumnName("New Pricing Factor");

                entity.Property(e => e.NewPutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Put Date");

                entity.Property(e => e.NewPutPrice).HasColumnName("New Put Price");

                entity.Property(e => e.NewResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New ResetFrequency");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Risk Currency");

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Security Description");

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Security Name");

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New SEDOL");

                entity.Property(e => e.NewSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Spread");

                entity.Property(e => e.NewTradingFactor).HasColumnName("New Trading Factor");

                entity.Property(e => e.NewVolatility30days).HasColumnName("New Volatility 30Days");

                entity.Property(e => e.NewVolatility90days).HasColumnName("New Volatility 90Days");

                entity.Property(e => e.NewVolume).HasColumnName("New Volume");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old Ask Price");

                entity.Property(e => e.OldAssetType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Asset Type");

                entity.Property(e => e.OldAvgVolume30days).HasColumnName("Old AvgVolume 30days");

                entity.Property(e => e.OldBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Industry Group");

                entity.Property(e => e.OldBbgIndustrySector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Industry Sector");

                entity.Property(e => e.OldBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Industry SubGroup");

                entity.Property(e => e.OldBbgTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Ticker");

                entity.Property(e => e.OldBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG UniqueID");

                entity.Property(e => e.OldBidPrice).HasColumnName("Old Bid Price");

                entity.Property(e => e.OldCallDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old CallDate");

                entity.Property(e => e.OldCallPrice).HasColumnName("Old CallPrice");

                entity.Property(e => e.OldConvexity).HasColumnName("Old Convexity");

                entity.Property(e => e.OldCouponCap)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Coupon Cap");

                entity.Property(e => e.OldCouponFloor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Coupon Floor");

                entity.Property(e => e.OldCouponFrequency).HasColumnName("Old Coupon frequency");

                entity.Property(e => e.OldCouponRate).HasColumnName("Old Coupon Rate");

                entity.Property(e => e.OldCouponType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Coupon Type");

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old CUSIP");

                entity.Property(e => e.OldFirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old First CouponDate");

                entity.Property(e => e.OldFixToFloat).HasColumnName("Old FixToFloat");

                entity.Property(e => e.OldHasPosition).HasColumnName("Old Has Position");

                entity.Property(e => e.OldHighPrice).HasColumnName("Old High Price");

                entity.Property(e => e.OldInvestmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Investment Type");

                entity.Property(e => e.OldIsCallable).HasColumnName("Old IS Callable");

                entity.Property(e => e.OldIsPutable).HasColumnName("Old IsPutable");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old ISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Issue Country");

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Issue Currency");

                entity.Property(e => e.OldIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old IssueDate");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Issuer");

                entity.Property(e => e.OldLastPrice).HasColumnName("Old Last Price");

                entity.Property(e => e.OldLastResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old LastResetDate");

                entity.Property(e => e.OldLowPrice).HasColumnName("Old Low Price");

                entity.Property(e => e.OldMacaulayDuration).HasColumnName("Old Macaulay Duration");

                entity.Property(e => e.OldMaturity)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Maturity");

                entity.Property(e => e.OldMaxCallNoticeDays).HasColumnName("Old MaxCallNoticeDays");

                entity.Property(e => e.OldMaxPutNoticeDays)
                    .HasColumnType("datetime")
                    .HasColumnName("Old MaxPutNoticeDays");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old Open Price");

                entity.Property(e => e.OldPenultimateCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Penultimate CouponDate");

                entity.Property(e => e.OldPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF AssetClass");

                entity.Property(e => e.OldPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Country");

                entity.Property(e => e.OldPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF CreditRating");

                entity.Property(e => e.OldPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Currency");

                entity.Property(e => e.OldPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Instrument");

                entity.Property(e => e.OldPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF LiquidityProfile");

                entity.Property(e => e.OldPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Maturity");

                entity.Property(e => e.OldPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF NAICS Code");

                entity.Property(e => e.OldPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Region");

                entity.Property(e => e.OldPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Sector");

                entity.Property(e => e.OldPfSubAssetClass)
                    .HasMaxLength(59)
                    .IsUnicode(false)
                    .HasColumnName("Old PF SubAssetClass");

                entity.Property(e => e.OldPricingFactor).HasColumnName("Old Pricing Factor");

                entity.Property(e => e.OldPutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Put Date");

                entity.Property(e => e.OldPutPrice).HasColumnName("Old Put Price");

                entity.Property(e => e.OldResetFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old ResetFrequency");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Risk Currency");

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Security Description");

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Security Name");

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old SEDOL");

                entity.Property(e => e.OldSpread)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Spread");

                entity.Property(e => e.OldTradingFactor).HasColumnName("Old Trading Factor");

                entity.Property(e => e.OldVolatility30days).HasColumnName("Old Volatility 30Days");

                entity.Property(e => e.OldVolatility90days).HasColumnName("Old Volatility 90Days");

                entity.Property(e => e.OldVolume).HasColumnName("Old Volume");

                entity.Property(e => e.TransactionAction)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Action");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bond>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.Property(e => e.SecurityId).HasColumnName("SecurityID");

                entity.Property(e => e.AskPrice).HasColumnName("Ask Price");

                entity.Property(e => e.AssetType)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Asset Type");

                entity.Property(e => e.BbgTicker)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BBG Ticker");

                entity.Property(e => e.BbgUniqueId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("BBG Unique ID");

                entity.Property(e => e.BidPrice).HasColumnName("Bid Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Group");

                entity.Property(e => e.BloombergIndustrySector)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Sector");

                entity.Property(e => e.BloombergIndustrySubGroup)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Sub Group");

                entity.Property(e => e.CallDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Call Date");

                entity.Property(e => e.CallNotificationMaxDays).HasColumnName("Call Notification Max Days");

                entity.Property(e => e.CallPrice).HasColumnName("Call Price");

                entity.Property(e => e.CallableFlag).HasColumnName("Callable Flag");

                entity.Property(e => e.Cap).IsUnicode(false);

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Country of Issuance");

                entity.Property(e => e.CouponFrequency).HasColumnName("Coupon Frequency");

                entity.Property(e => e.CouponType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Coupon Type");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.FirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("First Coupon Date");

                entity.Property(e => e.FixToFloatFlag).HasColumnName("Fix to Float Flag");

                entity.Property(e => e.Floor).IsUnicode(false);

                entity.Property(e => e.HasPosition).HasColumnName("Has Position");

                entity.Property(e => e.HighPrice).HasColumnName("High Price");

                entity.Property(e => e.InvestmentType)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Investment Type");

                entity.Property(e => e.Isin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Issue Currency");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue Date");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last Price");

                entity.Property(e => e.LastResetDate)
                    .IsUnicode(false)
                    .HasColumnName("Last Reset Date");

                entity.Property(e => e.LowPrice).HasColumnName("Low Price");

                entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay Duration");

                entity.Property(e => e.Maturity).HasColumnType("datetime");

                entity.Property(e => e.OpenPrice).HasColumnName("Open Price");

                entity.Property(e => e.PenultimateCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Penultimate Coupon Date");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PF Asset Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("PF Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PF Credit Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("PF Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PF Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PF Liquidity Profile");

                entity.Property(e => e.PfMaturity)
                    .IsUnicode(false)
                    .HasColumnName("PF Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .IsUnicode(false)
                    .HasColumnName("PF NAICS Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("PF Region");

                entity.Property(e => e.PfSector)
                    .IsUnicode(false)
                    .HasColumnName("PF Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(59)
                    .IsUnicode(false)
                    .HasColumnName("PF Sub Asset Class");

                entity.Property(e => e.PricingFactor).HasColumnName("Pricing Factor");

                entity.Property(e => e.PutDate)
                    .IsUnicode(false)
                    .HasColumnName("Put Date");

                entity.Property(e => e.PutNotificationMaxDays)
                    .IsUnicode(false)
                    .HasColumnName("Put Notification Max Days");

                entity.Property(e => e.PutPrice)
                    .IsUnicode(false)
                    .HasColumnName("Put Price");

                entity.Property(e => e.PutableFlag).HasColumnName("Putable Flag");

                entity.Property(e => e.ResetFrequency)
                    .IsUnicode(false)
                    .HasColumnName("Reset Frequency");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Risk Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Security Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Security Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.Spread).IsUnicode(false);

                entity.Property(e => e.TradingFactor).HasColumnName("Trading Factor");

                entity.Property(e => e._30dVolatility).HasColumnName("30D Volatility");

                entity.Property(e => e._30dayAverageVolume).HasColumnName("30Day Average Volume");

                entity.Property(e => e._90dVolatility).HasColumnName("90D Volatility");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.ToTable("Equity");

                entity.Property(e => e.SecurityId).HasColumnName("SecurityID");

                entity.Property(e => e.AdrUnderlyingCurrency)
                    .IsUnicode(false)
                    .HasColumnName("ADR Underlying Currency");

                entity.Property(e => e.AdrUnderlyingTicker)
                    .IsUnicode(false)
                    .HasColumnName("ADR Underlying Ticker");

                entity.Property(e => e.AskPrice).HasColumnName("Ask Price");

                entity.Property(e => e.AverageVolume20d).HasColumnName("Average Volume - 20D");

                entity.Property(e => e.BbgGlobalId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BBG Global ID");

                entity.Property(e => e.BbgIndustrySubGroup)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("BBG Industry Sub Group");

                entity.Property(e => e.BbgUniqueName)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("BBG Unique Name");

                entity.Property(e => e.BidPrice).HasColumnName("Bid Price");

                entity.Property(e => e.BloombergIndustryGroup)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Industry Group");

                entity.Property(e => e.BloombergSector)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Sector");

                entity.Property(e => e.BloombergTicker)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Ticker");

                entity.Property(e => e.BloombergUniqueId)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Bloomberg Unique ID");

                entity.Property(e => e.ClosePrice).HasColumnName("Close Price");

                entity.Property(e => e.CountryOfIncorporation)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Country of Incorporation");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("Country of Issuance");

                entity.Property(e => e.Cusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSIP");

                entity.Property(e => e.DividendAmount).HasColumnName("Dividend Amount");

                entity.Property(e => e.DividendDeclaredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Declared Date");

                entity.Property(e => e.DividendExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Ex Date");

                entity.Property(e => e.DividendPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Pay Date");

                entity.Property(e => e.DividendRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Dividend Record Date ");

                entity.Property(e => e.DividendType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Dividend Type");

                entity.Property(e => e.Exchange)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.HasPosition).HasColumnName("Has Position");

                entity.Property(e => e.IpoDate)
                    .IsUnicode(false)
                    .HasColumnName("IPO Date");

                entity.Property(e => e.IsActiveSecurity).HasColumnName("Is Active Security");

                entity.Property(e => e.IsAdrFlag).HasColumnName("Is ADR Flag");

                entity.Property(e => e.Isin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ISIN");

                entity.Property(e => e.IssueCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Issue Currency");

                entity.Property(e => e.Issuer)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrice).HasColumnName("Last Price");

                entity.Property(e => e.LotSize).HasColumnName("Lot Size");

                entity.Property(e => e.OpenPrice).HasColumnName("Open Price");

                entity.Property(e => e.PeRatio).HasColumnName("PE Ratio");

                entity.Property(e => e.PfAssetClass)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PF Asset Class");

                entity.Property(e => e.PfCountry)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("PF Country");

                entity.Property(e => e.PfCreditRating)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PF Credit Rating");

                entity.Property(e => e.PfCurrency)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasColumnName("PF Currency");

                entity.Property(e => e.PfInstrument)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PF Instrument");

                entity.Property(e => e.PfLiquidityProfile)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PF Liquidity Profile");

                entity.Property(e => e.PfMaturity)
                    .IsUnicode(false)
                    .HasColumnName("PF Maturity");

                entity.Property(e => e.PfNaicsCode)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("PF NAICS Code");

                entity.Property(e => e.PfRegion)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("PF Region");

                entity.Property(e => e.PfSector)
                    .IsUnicode(false)
                    .HasColumnName("PF Sector");

                entity.Property(e => e.PfSubAssetClass)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("PF Sub Asset Class");

                entity.Property(e => e.PricingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Pricing Currency");

                entity.Property(e => e.ReturnYtd).HasColumnName("Return - YTD");

                entity.Property(e => e.RiskCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Risk Currency");

                entity.Property(e => e.SecurityDescription)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("Security Description");

                entity.Property(e => e.SecurityName)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("Security Name");

                entity.Property(e => e.Sedol)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("SEDOL");

                entity.Property(e => e.SettleDays).HasColumnName("Settle Days");

                entity.Property(e => e.SharesPerAdr)
                    .IsUnicode(false)
                    .HasColumnName("Shares Per ADR");

                entity.Property(e => e.ShortInterest).HasColumnName("Short Interest");

                entity.Property(e => e.TickerAndExchange)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Ticker and Exchange");

                entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total Shares Outstanding");

                entity.Property(e => e.TradingCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Trading Currency");

                entity.Property(e => e.Volatility90d).HasColumnName("Volatility - 90D");

                entity.Property(e => e.VotingRightsPerShare).HasColumnName("Voting Rights Per Share");
            });

            modelBuilder.Entity<EquityAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Equity Audit");

                entity.Property(e => e.NewAdrUnderlyingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New ADR Underlying Currency");

                entity.Property(e => e.NewAdrUnderlyingTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New ADR Underlying Ticker");

                entity.Property(e => e.NewAskPrice).HasColumnName("New Ask Price");

                entity.Property(e => e.NewAvgVol20d).HasColumnName("New Avg Vol 20D");

                entity.Property(e => e.NewBbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG GlobalID");

                entity.Property(e => e.NewBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Industry Group");

                entity.Property(e => e.NewBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Industry SubGroup");

                entity.Property(e => e.NewBbgSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Sector");

                entity.Property(e => e.NewBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG UniqueID");

                entity.Property(e => e.NewBbgUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New BBG Unique Name");

                entity.Property(e => e.NewBeta).HasColumnName("New Beta");

                entity.Property(e => e.NewBidPrice).HasColumnName("New Bid Price");

                entity.Property(e => e.NewBloombergTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Bloomberg Ticker");

                entity.Property(e => e.NewClosePrice).HasColumnName("New Close Price");

                entity.Property(e => e.NewCountryOfIncorporation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Country Of Incorporation");

                entity.Property(e => e.NewCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New CUSIP");

                entity.Property(e => e.NewDividendAmount).HasColumnName("New Dividend Amount");

                entity.Property(e => e.NewDividendDeclaredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Dividend Declared Date");

                entity.Property(e => e.NewDividendExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Dividend Ex date");

                entity.Property(e => e.NewDividendPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Dividend Pay date");

                entity.Property(e => e.NewDividendRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New Dividend Record date");

                entity.Property(e => e.NewDividendType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Dividend Type");

                entity.Property(e => e.NewExchange)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("New Exchange");

                entity.Property(e => e.NewFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Frequency");

                entity.Property(e => e.NewHasPosistion).HasColumnName("New Has Posistion");

                entity.Property(e => e.NewIpoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("New IPO Date");

                entity.Property(e => e.NewIsActive).HasColumnName("New Is Active");

                entity.Property(e => e.NewIsAdr).HasColumnName("New Is ADR");

                entity.Property(e => e.NewIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New ISIN");

                entity.Property(e => e.NewIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("New Issue Country");

                entity.Property(e => e.NewIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Issue Currency");

                entity.Property(e => e.NewIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Issuer");

                entity.Property(e => e.NewLastPrice).HasColumnName("New Last Price");

                entity.Property(e => e.NewLotSize).HasColumnName("New Lot Size");

                entity.Property(e => e.NewOpenPrice).HasColumnName("New Open Price");

                entity.Property(e => e.NewPeRatio).HasColumnName("New PE Ratio");

                entity.Property(e => e.NewPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Asset Class");

                entity.Property(e => e.NewPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Country");

                entity.Property(e => e.NewPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Credit Rating");

                entity.Property(e => e.NewPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Currency");

                entity.Property(e => e.NewPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Instrument");

                entity.Property(e => e.NewPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Liquidity Profile");

                entity.Property(e => e.NewPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Maturity");

                entity.Property(e => e.NewPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF NAICS Code");

                entity.Property(e => e.NewPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Region");

                entity.Property(e => e.NewPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Sector");

                entity.Property(e => e.NewPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New PF Sub AssetClass");

                entity.Property(e => e.NewPricingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Pricing Currency");

                entity.Property(e => e.NewReturnYtd).HasColumnName("New Return YTD");

                entity.Property(e => e.NewRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Risk Currency");

                entity.Property(e => e.NewSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Security Description");

                entity.Property(e => e.NewSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Security Name");

                entity.Property(e => e.NewSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New SEDOL");

                entity.Property(e => e.NewSettleDays).HasColumnName("New Settle Days");

                entity.Property(e => e.NewSharesPerAdr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Shares Per ADR");

                entity.Property(e => e.NewShortIntrest).HasColumnName("New Short Intrest");

                entity.Property(e => e.NewTickerAndExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Ticker and Exchange");

                entity.Property(e => e.NewTotalSharesOutstading).HasColumnName("New Total Shares Outstading");

                entity.Property(e => e.NewTradingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Trading Currency");

                entity.Property(e => e.NewVolatility90d).HasColumnName("New Volatility 90D");

                entity.Property(e => e.NewVolume).HasColumnName("New Volume");

                entity.Property(e => e.NewVotingRightPerShare).HasColumnName("New Voting Right Per Share");

                entity.Property(e => e.OldAdrUnderlyingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old ADR Underlying Currency");

                entity.Property(e => e.OldAdrUnderlyingTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old ADR Underlying Ticker");

                entity.Property(e => e.OldAskPrice).HasColumnName("Old Ask Price");

                entity.Property(e => e.OldAvgVol20d).HasColumnName("Old Avg Vol 20D");

                entity.Property(e => e.OldBbgGlobalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG GlobalID");

                entity.Property(e => e.OldBbgIndustryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Industry Group");

                entity.Property(e => e.OldBbgIndustrySubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Industry SubGroup");

                entity.Property(e => e.OldBbgSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Sector");

                entity.Property(e => e.OldBbgUniqueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG UniqueID");

                entity.Property(e => e.OldBbgUniqueName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old BBG Unique Name");

                entity.Property(e => e.OldBeta).HasColumnName("Old Beta");

                entity.Property(e => e.OldBidPrice).HasColumnName("Old Bid Price");

                entity.Property(e => e.OldBloombergTicker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Bloomberg Ticker");

                entity.Property(e => e.OldClosePrice).HasColumnName("Old Close Price");

                entity.Property(e => e.OldCountryOfIncorporation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Country Of Incorporation");

                entity.Property(e => e.OldCusip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old CUSIP");

                entity.Property(e => e.OldDividendAmount).HasColumnName("Old Dividend Amount");

                entity.Property(e => e.OldDividendDeclaredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Dividend Declared Date");

                entity.Property(e => e.OldDividendExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Dividend Ex date");

                entity.Property(e => e.OldDividendPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Dividend Pay date");

                entity.Property(e => e.OldDividendRecordDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old Dividend Record date");

                entity.Property(e => e.OldDividendType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Dividend Type");

                entity.Property(e => e.OldExchange)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Old Exchange");

                entity.Property(e => e.OldFrequency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Frequency");

                entity.Property(e => e.OldHasPosistion).HasColumnName("Old Has Posistion");

                entity.Property(e => e.OldIpoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Old IPO Date");

                entity.Property(e => e.OldIsActive).HasColumnName("Old Is Active");

                entity.Property(e => e.OldIsAdr).HasColumnName("Old Is ADR");

                entity.Property(e => e.OldIsin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old ISIN");

                entity.Property(e => e.OldIssueCountry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Old Issue Country");

                entity.Property(e => e.OldIssueCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Issue Currency");

                entity.Property(e => e.OldIssuer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Issuer");

                entity.Property(e => e.OldLastPrice).HasColumnName("Old Last Price");

                entity.Property(e => e.OldLotSize).HasColumnName("Old Lot Size");

                entity.Property(e => e.OldOpenPrice).HasColumnName("Old Open Price");

                entity.Property(e => e.OldPeRatio).HasColumnName("Old PE Ratio");

                entity.Property(e => e.OldPfAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Asset Class");

                entity.Property(e => e.OldPfCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Country");

                entity.Property(e => e.OldPfCreditRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Credit Rating");

                entity.Property(e => e.OldPfCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Currency");

                entity.Property(e => e.OldPfInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Instrument");

                entity.Property(e => e.OldPfLiquidityProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Liquidity Profile");

                entity.Property(e => e.OldPfMaturity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Maturity");

                entity.Property(e => e.OldPfNaicsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF NAICS Code");

                entity.Property(e => e.OldPfRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Region");

                entity.Property(e => e.OldPfSector)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Sector");

                entity.Property(e => e.OldPfSubAssetClass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old PF Sub AssetClass");

                entity.Property(e => e.OldPricingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Pricing Currency");

                entity.Property(e => e.OldReturnYtd).HasColumnName("Old Return YTD");

                entity.Property(e => e.OldRiskCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Risk Currency");

                entity.Property(e => e.OldSecurityDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Security Description");

                entity.Property(e => e.OldSecurityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Security Name");

                entity.Property(e => e.OldSedol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old SEDOL");

                entity.Property(e => e.OldSettleDays).HasColumnName("Old Settle Days");

                entity.Property(e => e.OldSharesPerAdr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Shares Per ADR");

                entity.Property(e => e.OldShortIntrest).HasColumnName("Old Short Intrest");

                entity.Property(e => e.OldTickerAndExchange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Ticker and Exchange");

                entity.Property(e => e.OldTotalSharesOutstading).HasColumnName("Old Total Shares Outstading");

                entity.Property(e => e.OldTradingCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old Trading Currency");

                entity.Property(e => e.OldVolatility90d).HasColumnName("Old Volatility 90D");

                entity.Property(e => e.OldVolume).HasColumnName("Old Volume");

                entity.Property(e => e.OldVotingRightsPerShare).HasColumnName("Old Voting Rights Per Share");

                entity.Property(e => e.SecurityId).HasColumnName("SecurityID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
