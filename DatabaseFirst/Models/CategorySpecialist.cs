using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chuyên khoa
/// </summary>
public partial class CategorySpecialist
{
    public Guid SpecialistId { get; set; }

    /// <summary>
    /// mã chuyên khoa
    /// </summary>
    public string SpecialistCode { get; set; } = null!;

    /// <summary>
    /// tên chuyên khoa
    /// </summary>
    public string SpecialistName { get; set; } = null!;

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? SpecialistNote { get; set; }

    public string? Logo { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryExamineCode> CategoryExamineCodes { get; set; } = new List<CategoryExamineCode>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRoom> CategoryRooms { get; set; } = new List<CategoryRoom>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<EmployeeSpecialist> EmployeeSpecialists { get; set; } = new List<EmployeeSpecialist>();

    public virtual ICollection<MedicalExaminationServiceSpecialist> MedicalExaminationServiceSpecialists { get; set; } = new List<MedicalExaminationServiceSpecialist>();
}
