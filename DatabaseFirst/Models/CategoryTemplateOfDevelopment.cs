using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mẫu diễn biến
/// </summary>
public partial class CategoryTemplateOfDevelopment
{
    public Guid TemplateOfDevelopmentsId { get; set; }

    /// <summary>
    /// mã mẫu diễn biến
    /// </summary>
    public string TemplateOfDevelopmentsCode { get; set; } = null!;

    /// <summary>
    /// tên mẫu diễn biến
    /// </summary>
    public string TemplateOfDevelopmentsName { get; set; } = null!;

    /// <summary>
    /// diễn biến
    /// </summary>
    public string TemplateOfDevelopmentsDesc { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecords { get; set; } = new List<PageTreatmentMedicalRecord>();

    public virtual ICollection<TemplateOfDevelopmentsAccount> TemplateOfDevelopmentsAccounts { get; set; } = new List<TemplateOfDevelopmentsAccount>();

    public virtual ICollection<TemplateOfDevelopmentsDepartment> TemplateOfDevelopmentsDepartments { get; set; } = new List<TemplateOfDevelopmentsDepartment>();

    public virtual ICollection<TemplateOfDevelopmentsRoom> TemplateOfDevelopmentsRooms { get; set; } = new List<TemplateOfDevelopmentsRoom>();
}
