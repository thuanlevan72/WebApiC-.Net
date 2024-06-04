using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại bệnh án
/// </summary>
public partial class CategoryTypeOfMedicalRecord
{
    public Guid TypeOfMedicalRecordId { get; set; }

    /// <summary>
    /// mã bệnh án
    /// </summary>
    public string TypeOfMedicalRecordCode { get; set; } = null!;

    /// <summary>
    /// tên bệnh án
    /// </summary>
    public string TypeOfMedicalRecordName { get; set; } = null!;

    public int IsLongTermMedicalRecord { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryDepartment> CategoryDepartments { get; set; } = new List<CategoryDepartment>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodes { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual ICollection<ReportTypeOfMedicalRecord> ReportTypeOfMedicalRecords { get; set; } = new List<ReportTypeOfMedicalRecord>();
}
