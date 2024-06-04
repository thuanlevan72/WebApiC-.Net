using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục ca làm việc
/// </summary>
public partial class CategoryShift
{
    public Guid ShiftId { get; set; }

    /// <summary>
    /// mã ca làm việc
    /// </summary>
    public string ShiftCode { get; set; } = null!;

    /// <summary>
    /// tên mã làm việc
    /// </summary>
    public string ShiftName { get; set; } = null!;

    /// <summary>
    /// từ ngày
    /// </summary>
    public TimeOnly FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public TimeOnly ToDate { get; set; }

    /// <summary>
    /// khác ngày làm việc
    /// </summary>
    public int IsDiffWork { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();
}
