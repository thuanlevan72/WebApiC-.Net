using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mẫu kết quả PHCN
/// </summary>
public partial class CategoryResultTemplateSurgery
{
    public Guid ResultTemplatedSurgeryId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string ResultTemplatedSurgeryCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string ResultTemplatedSurgeryName { get; set; } = null!;

    /// <summary>
    /// phương pháp vô cảm
    /// </summary>
    public Guid? ResultTemplatedSurgeryMethodAttributeId { get; set; }

    /// <summary>
    /// kết luận
    /// </summary>
    public string? ResultTemplatedSurgeryResult { get; set; }

    /// <summary>
    /// chẩn đoán sau PTTT
    /// </summary>
    public string? ResultTemplatedSurgeryLaterDiagnosis { get; set; }

    /// <summary>
    /// phương pháp PTTT
    /// </summary>
    public string? ResultTemplatedSurgeryMethod { get; set; }

    /// <summary>
    /// Cách thức PTTT
    /// </summary>
    public string ResultTemplatedSurgeryType { get; set; } = null!;

    public string? ResultTemplatedSurgeryImage { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual CategoryAttribute? ResultTemplatedSurgeryMethodAttribute { get; set; }
}
