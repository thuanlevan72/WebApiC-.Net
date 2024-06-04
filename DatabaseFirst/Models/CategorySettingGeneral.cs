using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập chung
/// </summary>
public partial class CategorySettingGeneral
{
    public Guid SettingGeneralId { get; set; }

    public string SettingGeneralCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<SettingGeneralValue> SettingGeneralValues { get; set; } = new List<SettingGeneralValue>();
}
