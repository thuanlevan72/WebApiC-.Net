using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục liều dùng
/// </summary>
public partial class CategoryDosage
{
    public Guid DosageId { get; set; }

    /// <summary>
    /// mã liều dùng
    /// </summary>
    public string DosageCode { get; set; } = null!;

    /// <summary>
    /// tên liều dùng
    /// </summary>
    public string DosageName { get; set; } = null!;

    /// <summary>
    /// số lần/ ngày
    /// </summary>
    public int? TimePerDay { get; set; }

    /// <summary>
    /// số lượng/ lần
    /// </summary>
    public int? QuantityPerTimes { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryDesignationKitService> CategoryDesignationKitServices { get; set; } = new List<CategoryDesignationKitService>();

    public virtual ICollection<CategoryServiceOfPackage> CategoryServiceOfPackages { get; set; } = new List<CategoryServiceOfPackage>();

    public virtual ICollection<DesignateServicePrescriptionExamine> DesignateServicePrescriptionExamines { get; set; } = new List<DesignateServicePrescriptionExamine>();

    public virtual ICollection<DrugTabDosage> DrugTabDosages { get; set; } = new List<DrugTabDosage>();

    public virtual ICollection<PatientDesignateServiceDrug> PatientDesignateServiceDrugs { get; set; } = new List<PatientDesignateServiceDrug>();

    public virtual ICollection<PatientDesignateServiceVaccine> PatientDesignateServiceVaccines { get; set; } = new List<PatientDesignateServiceVaccine>();

    public virtual ICollection<PrescriptionMedicineDosage> PrescriptionMedicineDosages { get; set; } = new List<PrescriptionMedicineDosage>();
}
