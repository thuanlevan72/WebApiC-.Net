using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thẻ bảo hiểm
/// </summary>
public partial class CategoryInsuranceCard
{
    public Guid InsuranceCardId { get; set; }

    /// <summary>
    /// mã thẻ bảo hiểm
    /// </summary>
    public string InsuranceCardCode { get; set; } = null!;

    /// <summary>
    /// tên thẻ bảo hiểm
    /// </summary>
    public string InsuranceCardName { get; set; } = null!;

    /// <summary>
    /// mức hưởng
    /// </summary>
    public int BenefitLevel { get; set; }

    public Guid? JobId { get; set; }

    public string? Note { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryJob? Job { get; set; }
}
