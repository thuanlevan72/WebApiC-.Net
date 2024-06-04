using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập chọn giường - phân loại PTTT
/// </summary>
public partial class SettingBedChooseClassifySurgery
{
    public Guid SettingBedChooseClassifySurgery1 { get; set; }

    public Guid SettingBedChooseId { get; set; }

    public Guid ClassifySurgeryId { get; set; }

    public virtual CategoryAttribute ClassifySurgery { get; set; } = null!;

    public virtual CategorySettingBedChoose SettingBedChoose { get; set; } = null!;
}
