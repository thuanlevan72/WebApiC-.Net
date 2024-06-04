using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại phiếu
/// </summary>
public partial class CategoryBallotType
{
    public Guid BallotTypeId { get; set; }

    /// <summary>
    /// mã loại phiếu
    /// </summary>
    public string BallotTypeCode { get; set; } = null!;

    /// <summary>
    /// tên loại phiếu
    /// </summary>
    public string BallotTypeName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<ReportBallotType> ReportBallotTypes { get; set; } = new List<ReportBallotType>();
}
