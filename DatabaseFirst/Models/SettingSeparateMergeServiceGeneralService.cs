using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập -tách gộp các dịch vụ
/// </summary>
public partial class SettingSeparateMergeServiceGeneralService
{
    public Guid SettingSeparateMergeServiceGeneralServiceId { get; set; }

    public Guid SettingSeparateMergeServiceId { get; set; }

    /// <summary>
    /// gộp phiếu xét nghiệm or  gộp phiếu cddv 1:Tách 2 gộp
    /// </summary>
    public int MergeBallots { get; set; }

    /// <summary>
    /// chung tờ chỉ định 1:Tách 2 gộp
    /// </summary>
    public int GeneralIndication { get; set; }

    public string? Note { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategorySettingSeparateMergeService SettingSeparateMergeService { get; set; } = null!;
}
