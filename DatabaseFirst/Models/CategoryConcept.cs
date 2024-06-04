using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục dịch vụ
/// </summary>
public partial class CategoryConcept
{
    public Guid ConceptId { get; set; }

    public string ConceptName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// 1: dịch vụ 2 hàng hóa
    /// </summary>
    public int ConceptType { get; set; }

    public virtual ICollection<BidServiceServiceType> BidServiceServiceTypes { get; set; } = new List<BidServiceServiceType>();

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlips { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryConceptType> CategoryConceptTypes { get; set; } = new List<CategoryConceptType>();

    public virtual ICollection<CategoryDesignationKit> CategoryDesignationKits { get; set; } = new List<CategoryDesignationKit>();

    public virtual ICollection<CategoryDinner> CategoryDinners { get; set; } = new List<CategoryDinner>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServices { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicines { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodes { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryService> CategoryServices { get; set; } = new List<CategoryService>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategoryUnit> CategoryUnits { get; set; } = new List<CategoryUnit>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual ICollection<CategoryWarehouseSource> CategoryWarehouseSources { get; set; } = new List<CategoryWarehouseSource>();

    public virtual ICollection<CdhatdcnlistChangeService> CdhatdcnlistChangeServices { get; set; } = new List<CdhatdcnlistChangeService>();

    public virtual ICollection<DesignationKitServiceType> DesignationKitServiceTypes { get; set; } = new List<DesignationKitServiceType>();

    public virtual ICollection<HistoryPartnerTypeAtrribute> HistoryPartnerTypeAtrributes { get; set; } = new List<HistoryPartnerTypeAtrribute>();

    public virtual ICollection<HistoryPartnerTypeServiceAttribute> HistoryPartnerTypeServiceAttributes { get; set; } = new List<HistoryPartnerTypeServiceAttribute>();

    public virtual ICollection<Hospitalize> Hospitalizes { get; set; } = new List<Hospitalize>();

    public virtual ICollection<PackageServiceConcept> PackageServiceConcepts { get; set; } = new List<PackageServiceConcept>();

    public virtual ICollection<PartnerTypeAtrribute> PartnerTypeAtrributes { get; set; } = new List<PartnerTypeAtrribute>();

    public virtual ICollection<PartnerTypeServiceAttribute> PartnerTypeServiceAttributes { get; set; } = new List<PartnerTypeServiceAttribute>();

    public virtual ICollection<ReceiptCodeEstimateProduct> ReceiptCodeEstimateProducts { get; set; } = new List<ReceiptCodeEstimateProduct>();

    public virtual ICollection<ServiceConcept> ServiceConcepts { get; set; } = new List<ServiceConcept>();

    public virtual ICollection<SurgeryPackageGeneralService> SurgeryPackageGeneralServices { get; set; } = new List<SurgeryPackageGeneralService>();

    public virtual ICollection<WarehouseWareHouseType> WarehouseWareHouseTypes { get; set; } = new List<WarehouseWareHouseType>();
}
