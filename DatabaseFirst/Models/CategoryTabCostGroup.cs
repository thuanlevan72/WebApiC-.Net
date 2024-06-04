using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm chi phí
/// </summary>
public partial class CategoryTabCostGroup
{
    public Guid TabCostGroupId { get; set; }

    public Guid CostGroupId { get; set; }

    public Guid TypeTimeAttributeId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsActive { get; set; }

    public virtual ICollection<BedServiceTabCostGroup> BedServiceTabCostGroups { get; set; } = new List<BedServiceTabCostGroup>();

    public virtual ICollection<BloodProductsCostGroup> BloodProductsCostGroups { get; set; } = new List<BloodProductsCostGroup>();

    public virtual ICollection<CdhatdcnTabCostGroup> CdhatdcnTabCostGroups { get; set; } = new List<CdhatdcnTabCostGroup>();

    public virtual ICollection<ChemistyCostGroup> ChemistyCostGroups { get; set; } = new List<ChemistyCostGroup>();

    public virtual CategoryCostGroup CostGroup { get; set; } = null!;

    public virtual ICollection<DrugCostGroup> DrugCostGroups { get; set; } = new List<DrugCostGroup>();

    public virtual ICollection<LaboratoryServiceTabCostGroup> LaboratoryServiceTabCostGroups { get; set; } = new List<LaboratoryServiceTabCostGroup>();

    public virtual ICollection<MedicalExaminationServiceTabCostGroup> MedicalExaminationServiceTabCostGroups { get; set; } = new List<MedicalExaminationServiceTabCostGroup>();

    public virtual ICollection<OutsiteOfTreatmentServiceTabCostGroup> OutsiteOfTreatmentServiceTabCostGroups { get; set; } = new List<OutsiteOfTreatmentServiceTabCostGroup>();

    public virtual ICollection<RehabilitationServiceTabCostGroup> RehabilitationServiceTabCostGroups { get; set; } = new List<RehabilitationServiceTabCostGroup>();

    public virtual ICollection<SuppliesCostGroup> SuppliesCostGroups { get; set; } = new List<SuppliesCostGroup>();

    public virtual ICollection<SurgicalProceduresServiceTabCostGroup> SurgicalProceduresServiceTabCostGroups { get; set; } = new List<SurgicalProceduresServiceTabCostGroup>();

    public virtual CategoryAttribute TypeTimeAttribute { get; set; } = null!;
}
