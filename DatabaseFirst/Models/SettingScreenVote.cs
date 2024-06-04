using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập phiếu tại màn hinh
/// </summary>
public partial class SettingScreenVote
{
    public Guid SettingScreenVoteId { get; set; }

    /// <summary>
    /// Tên màn hình vị trí
    /// </summary>
    public Guid SettingScreenId { get; set; }

    /// <summary>
    /// tên phiếu
    /// </summary>
    public Guid VoteScreenId { get; set; }

    public Guid ReportId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid ChangedBy { get; set; }

    public virtual CategorySettingScreen SettingScreen { get; set; } = null!;

    public virtual CategorySettingScreen VoteScreen { get; set; } = null!;
}
