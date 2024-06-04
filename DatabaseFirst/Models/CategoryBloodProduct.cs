using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chế phẩm máu
/// </summary>
public partial class CategoryBloodProduct
{
    public Guid BloodProductId { get; set; }

    public string ServiceCode { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public string? EquivalentCode { get; set; }

    public string? EquivalentName { get; set; }

    public string? Abbreviations { get; set; }

    public decimal? PriceNonInsurance { get; set; }

    public decimal? PriceInsurance { get; set; }

    public decimal? Surcharge { get; set; }

    public int? InsurancePaymentRatio { get; set; }

    public int? ServicePaymentRatio { get; set; }

    public Guid? BloodTypeAttributeId { get; set; }

    public int? Volume { get; set; }

    public int? NumberDayUsed { get; set; }

    public Guid? GroupServiceLvl1 { get; set; }

    public Guid? GroupServiceLvl2 { get; set; }

    public Guid? GroupServiceLvl3 { get; set; }

    public Guid? UnitId { get; set; }

    public Guid? RoutesId { get; set; }

    public int? NumberDayWarningExpired { get; set; }

    public int? IsTransportationCosts { get; set; }

    public int? IsNoCharge { get; set; }

    public int? IsUseCovid { get; set; }

    public int? IsRequimentService { get; set; }

    public int? IsExtenalPayment { get; set; }

    public int? IsKiosk { get; set; }

    public int? IsEcrcl { get; set; }

    public int? IsEGfr { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public int? NumberDayWarningInsurance { get; set; }

    public virtual ICollection<BloodProductsCostGroup> BloodProductsCostGroups { get; set; } = new List<BloodProductsCostGroup>();

    public virtual ICollection<BloodProductsOtherSourcesPay> BloodProductsOtherSourcesPays { get; set; } = new List<BloodProductsOtherSourcesPay>();

    public virtual ICollection<BloodProductsTabAccompanyingService> BloodProductsTabAccompanyingServices { get; set; } = new List<BloodProductsTabAccompanyingService>();

    public virtual CategoryAttribute? BloodTypeAttribute { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1Navigation { get; set; }

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2Navigation { get; set; }

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual CategoryRoute? Routes { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
