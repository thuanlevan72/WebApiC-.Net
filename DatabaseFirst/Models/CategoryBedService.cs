using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ giường
/// </summary>
public partial class CategoryBedService
{
    public Guid BedServiceId { get; set; }

    public string BedServiceCode { get; set; } = null!;

    public string BedServiceName { get; set; } = null!;

    public string EquivalentCode { get; set; } = null!;

    public string? EquivalentName { get; set; }

    public double? PriceNonInsurance { get; set; }

    public double? PriceInsurance { get; set; }

    public decimal? Surcharge { get; set; }

    public Guid? UnitId { get; set; }

    public Guid? GroupServiceLvl1Id { get; set; }

    public Guid? GroupServiceLvl2Id { get; set; }

    public Guid? GroupServiceLvl3Id { get; set; }

    public Guid? BedClassificationAttributeId { get; set; }

    public string? DecisionCode { get; set; }

    public DateTime? DecisionDate { get; set; }

    public Guid? TechServiceTranferUnitMedicalId { get; set; }

    public Guid? ClsImplementUnitMedicalId { get; set; }

    public int? IsNoCharge { get; set; }

    public int IsRetrictDepartment { get; set; }

    public int IsIntensiveCare { get; set; }

    public int IsShowKiosk { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CategoryAttribute? BedClassificationAttribute { get; set; }

    public virtual ICollection<BedServiceOtherSourcesPay> BedServiceOtherSourcesPays { get; set; } = new List<BedServiceOtherSourcesPay>();

    public virtual ICollection<BedServiceServiceList> BedServiceServiceLists { get; set; } = new List<BedServiceServiceList>();

    public virtual ICollection<BedServiceSetUpBedSelection> BedServiceSetUpBedSelections { get; set; } = new List<BedServiceSetUpBedSelection>();

    public virtual ICollection<BedServiceTabAccompanyingService> BedServiceTabAccompanyingServices { get; set; } = new List<BedServiceTabAccompanyingService>();

    public virtual ICollection<BedServiceTabCostGroup> BedServiceTabCostGroups { get; set; } = new List<BedServiceTabCostGroup>();

    public virtual ICollection<BedServiceTabImplementationRoom> BedServiceTabImplementationRooms { get; set; } = new List<BedServiceTabImplementationRoom>();

    public virtual ICollection<BedServiceTabPriceOption> BedServiceTabPriceOptions { get; set; } = new List<BedServiceTabPriceOption>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBedBedService2s { get; set; } = new List<CategoryRoomBed>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBedBedServices { get; set; } = new List<CategoryRoomBed>();

    public virtual ICollection<CategorySettingBedChoose> CategorySettingBedChooses { get; set; } = new List<CategorySettingBedChoose>();

    public virtual CategoryHospital? ClsImplementUnitMedical { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1 { get; set; }

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2 { get; set; }

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3 { get; set; }

    public virtual CategoryHospital? TechServiceTranferUnitMedical { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
