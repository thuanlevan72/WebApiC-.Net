using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tab tùy chọn giá
/// </summary>
public partial class CategoryTabPriceOption
{
    public Guid TabPriceOptionId { get; set; }

    public Guid DepartmentId { get; set; }

    public double PriceNonInsurance { get; set; }

    public double PriceInsurance { get; set; }

    public double Surcharge { get; set; }

    public Guid PaymentTypeId { get; set; }

    public DateTime FromDated { get; set; }

    public DateTime ToDated { get; set; }

    public int IsNoCharge { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<BedServiceTabPriceOption> BedServiceTabPriceOptions { get; set; } = new List<BedServiceTabPriceOption>();

    public virtual ICollection<CdhatdcnTabPriceOption> CdhatdcnTabPriceOptions { get; set; } = new List<CdhatdcnTabPriceOption>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<LaboratoryServiceTabPriceOption> LaboratoryServiceTabPriceOptions { get; set; } = new List<LaboratoryServiceTabPriceOption>();

    public virtual ICollection<MedicalExaminationServiceTabPriceOption> MedicalExaminationServiceTabPriceOptions { get; set; } = new List<MedicalExaminationServiceTabPriceOption>();

    public virtual ICollection<OutsiteOfTreatmentServiceTabOptionPrice> OutsiteOfTreatmentServiceTabOptionPrices { get; set; } = new List<OutsiteOfTreatmentServiceTabOptionPrice>();

    public virtual CategoryPaymentType PaymentType { get; set; } = null!;

    public virtual ICollection<RehabilitationsServiceTabPriceOption> RehabilitationsServiceTabPriceOptions { get; set; } = new List<RehabilitationsServiceTabPriceOption>();

    public virtual ICollection<SurgicalProceduresServiceTabPriceOption> SurgicalProceduresServiceTabPriceOptions { get; set; } = new List<SurgicalProceduresServiceTabPriceOption>();

    public virtual ICollection<TabPriceOptionAttribute> TabPriceOptionAttributes { get; set; } = new List<TabPriceOptionAttribute>();
}
