using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đơn vị tính
/// </summary>
public partial class CategoryUnit
{
    public Guid UnitId { get; set; }

    public Guid? ParentId { get; set; }

    /// <summary>
    /// mã đơn vị tính
    /// </summary>
    public string UnitCode { get; set; } = null!;

    /// <summary>
    /// tên đơn vị tính
    /// </summary>
    public string UnitName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBidDetail> CategoryBidDetails { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDinner> CategoryDinners { get; set; } = new List<CategoryDinner>();

    public virtual ICollection<CategoryDrug> CategoryDrugUnitLvl1Navigations { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugUnitLvl2Navigations { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugUnitUsedNavigations { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryKitSupply> CategoryKitSupplies { get; set; } = new List<CategoryKitSupply>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServices { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicineUnitUsedNavigations { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicineUnits { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategorySupply> CategorySupplyUnitLvl1Navigations { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySupply> CategorySupplyUnitLvl2Navigations { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategoryTabChildIndex> CategoryTabChildIndices { get; set; } = new List<CategoryTabChildIndex>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual CategoryConcept? Concept { get; set; }
}
