using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hàng hóa
/// </summary>
public partial class CategoryProduct
{
    public Guid ProductId { get; set; }

    public Guid? CdhaTdcnId { get; set; }

    public Guid? BedId { get; set; }

    public Guid? BloodProductId { get; set; }

    public Guid? ChemistriesId { get; set; }

    public Guid? DrugId { get; set; }

    public Guid? SuppliesId { get; set; }

    public Guid? MedicalExaminationId { get; set; }

    public Guid? LaboratoryId { get; set; }

    public Guid? SurgicalProceduresId { get; set; }

    public Guid? ConceptId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? VaccineId { get; set; }

    public Guid? ServiceId { get; set; }

    /// <summary>
    /// thuốc kê  ngoài
    /// </summary>
    public Guid? PrescriptionMedicineId { get; set; }

    public Guid? AttributeId { get; set; }

    public Guid? RehabilitationId { get; set; }

    public Guid? DinnerId { get; set; }

    public virtual CategoryAttribute? Attribute { get; set; }

    public virtual CategoryBedService? Bed { get; set; }

    public virtual ICollection<BedServiceTabAccompanyingService> BedServiceTabAccompanyingServices { get; set; } = new List<BedServiceTabAccompanyingService>();

    public virtual ICollection<BidDetailsProduct> BidDetailsProducts { get; set; } = new List<BidDetailsProduct>();

    public virtual CategoryBloodProduct? BloodProduct { get; set; }

    public virtual ICollection<BloodProductsTabAccompanyingService> BloodProductsTabAccompanyingServices { get; set; } = new List<BloodProductsTabAccompanyingService>();

    public virtual ICollection<CategoryDesignationKitService> CategoryDesignationKitServices { get; set; } = new List<CategoryDesignationKitService>();

    public virtual ICollection<CategoryGenerateProduct> CategoryGenerateProducts { get; set; } = new List<CategoryGenerateProduct>();

    public virtual ICollection<CategoryInventory> CategoryInventories { get; set; } = new List<CategoryInventory>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServices { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryServiceOfPackage> CategoryServiceOfPackages { get; set; } = new List<CategoryServiceOfPackage>();

    public virtual CategoryCdhatdcn? CdhaTdcn { get; set; }

    public virtual ICollection<CdhatdcnTabAccompanyingService> CdhatdcnTabAccompanyingServices { get; set; } = new List<CdhatdcnTabAccompanyingService>();

    public virtual ICollection<CdhatdcnlistChangeService> CdhatdcnlistChangeServices { get; set; } = new List<CdhatdcnlistChangeService>();

    public virtual CategoryChemistry? Chemistries { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual ICollection<DesignateServicePrescriptionExamine> DesignateServicePrescriptionExamines { get; set; } = new List<DesignateServicePrescriptionExamine>();

    public virtual CategoryDinner? Dinner { get; set; }

    public virtual CategoryDrug? Drug { get; set; }

    public virtual CategoryLaboratoryService? Laboratory { get; set; }

    public virtual ICollection<LaboratoryServiceTabAccompanyingService> LaboratoryServiceTabAccompanyingServices { get; set; } = new List<LaboratoryServiceTabAccompanyingService>();

    public virtual CategoryMedicalExaminationService? MedicalExamination { get; set; }

    public virtual ICollection<MedicalExaminationServiceTabAccompanyingService> MedicalExaminationServiceTabAccompanyingServices { get; set; } = new List<MedicalExaminationServiceTabAccompanyingService>();

    public virtual ICollection<OrderPackageServiceUsed> OrderPackageServiceUseds { get; set; } = new List<OrderPackageServiceUsed>();

    public virtual ICollection<PatientAppointmentService> PatientAppointmentServices { get; set; } = new List<PatientAppointmentService>();

    public virtual CategoryPrescriptionMedicine? PrescriptionMedicine { get; set; }

    public virtual ICollection<ProgramService> ProgramServices { get; set; } = new List<ProgramService>();

    public virtual ICollection<ReceiptCodeEstimateProduct> ReceiptCodeEstimateProducts { get; set; } = new List<ReceiptCodeEstimateProduct>();

    public virtual ICollection<ReceiptCodeSuppliesProduct> ReceiptCodeSuppliesProducts { get; set; } = new List<ReceiptCodeSuppliesProduct>();

    public virtual CategoryRehabilitationsService? Rehabilitation { get; set; }

    public virtual CategoryService? Service { get; set; }

    public virtual CategorySupply? Supplies { get; set; }

    public virtual CategorySurgicalProceduresService? SurgicalProcedures { get; set; }

    public virtual ICollection<SurgicalProceduresServiceTabAccompanyingService> SurgicalProceduresServiceTabAccompanyingServices { get; set; } = new List<SurgicalProceduresServiceTabAccompanyingService>();

    public virtual CategoryVaccine? Vaccine { get; set; }
}
