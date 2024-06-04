using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thiết lập dịch vụ tách gộp
/// </summary>
public partial class CategorySettingSeparateMergeService
{
    public Guid SettingSeparateMergeServiceId { get; set; }

    /// <summary>
    /// tên các dịch vụ
    /// </summary>
    public string SettingSeparateMergeServiceName { get; set; } = null!;

    /// <summary>
    /// 1: xét nghiệm 2 là chỉ đinh dvkt
    /// </summary>
    public int SettingSeparateMergeServiceType { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<SettingSeparateMergeServiceGeneralService> SettingSeparateMergeServiceGeneralServices { get; set; } = new List<SettingSeparateMergeServiceGeneralService>();
}
