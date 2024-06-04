using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập chung - Giá trị
/// </summary>
public partial class SettingGeneralValue
{
    public Guid SettingGeneralValueId { get; set; }

    public Guid SettingGeneralId { get; set; }

    public string SettingGeneralValue1 { get; set; } = null!;

    public DateTime SettingGeneralFromDate { get; set; }

    public DateTime? SettingGeneralToDate { get; set; }

    public virtual CategorySettingGeneral SettingGeneral { get; set; } = null!;
}
