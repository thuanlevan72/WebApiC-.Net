using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đối tượng miễn giảm
/// </summary>
public partial class CategorySubjectOfExemption
{
    public Guid SubjectOfExemptionId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string SubjectOfExemptionCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string SubjectOfExemptionName { get; set; } = null!;

    /// <summary>
    /// phần trăm
    /// </summary>
    public int PercentDiscount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();
}
