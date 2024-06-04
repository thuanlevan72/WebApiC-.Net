using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phương pháp vô cảm
/// </summary>
public partial class CategoryEmotionlessMethod
{
    public Guid EmotionlessMethodId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string EmotionlessMethodCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string EmotionlessMethodName { get; set; } = null!;

    /// <summary>
    /// phân loai phương pháp vô cảm
    /// </summary>
    public Guid? EmotionlessMethodClassificationId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAttribute? EmotionlessMethodClassification { get; set; }

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();
}
