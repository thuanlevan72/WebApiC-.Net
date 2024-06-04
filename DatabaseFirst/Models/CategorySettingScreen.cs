using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thiết lập màn hình
/// </summary>
public partial class CategorySettingScreen
{
    public Guid SettingScreenId { get; set; }

    /// <summary>
    /// Tên màn hình và tên phiếu khi parent_id != null
    /// </summary>
    public string SettingScreenName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ParentId { get; set; }

    public virtual ICollection<SettingScreenVote> SettingScreenVoteSettingScreens { get; set; } = new List<SettingScreenVote>();

    public virtual ICollection<SettingScreenVote> SettingScreenVoteVoteScreens { get; set; } = new List<SettingScreenVote>();
}
