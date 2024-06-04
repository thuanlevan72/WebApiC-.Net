using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục lời dặn
/// </summary>
public partial class CategoryAdvice
{
    public Guid AdviceId { get; set; }

    /// <summary>
    /// mã lời dặn
    /// </summary>
    public string AdviceCode { get; set; } = null!;

    /// <summary>
    /// tên lời dặn
    /// </summary>
    public string AdviceName { get; set; } = null!;

    /// <summary>
    /// dành cho thuốc
    /// </summary>
    public int? IsMedicine { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<DesignateServicePrescription> DesignateServicePrescriptions { get; set; } = new List<DesignateServicePrescription>();
}
