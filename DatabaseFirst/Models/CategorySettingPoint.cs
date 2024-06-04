using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// thiết lập tích điểm
/// </summary>
public partial class CategorySettingPoint
{
    public Guid SettingPointId { get; set; }

    /// <summary>
    /// chi phí khám bệnh (đ)
    /// </summary>
    public int CostExaminePrice { get; set; }

    /// <summary>
    /// chi phí khám bệnh (điểm)
    /// </summary>
    public int CostExaminePoint { get; set; }

    /// <summary>
    /// số lần khám (lần)
    /// </summary>
    public int ExaminePerTimes { get; set; }

    /// <summary>
    /// số lần khám (điểm)
    /// </summary>
    public int ExaminePerTimesPoint { get; set; }

    /// <summary>
    /// số lượt giới thiệu (lần)
    /// </summary>
    public int IntrolduceNumberTimes { get; set; }

    /// <summary>
    /// số lần giới thiệu (điểm)
    /// </summary>
    public int IntrolduceNumberPoint { get; set; }

    /// <summary>
    /// thanh toán (điểm)
    /// </summary>
    public int PaymentPoint { get; set; }

    /// <summary>
    /// thanh toán(đ)
    /// </summary>
    public int PaymentPrice { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
