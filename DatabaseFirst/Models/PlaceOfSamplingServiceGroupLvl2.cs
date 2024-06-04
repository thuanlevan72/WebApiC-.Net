using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// nơi lấy mẫu bệnh phẩm - nhóm dịch vụ cấp 2
/// </summary>
public partial class PlaceOfSamplingServiceGroupLvl2
{
    public Guid PlaceOfSamplingServiceGroupId { get; set; }

    public Guid PlaceOfSamplingId { get; set; }

    public Guid GroupServiceId { get; set; }

    public virtual CategoryGroupServiceLevel2 GroupService { get; set; } = null!;

    public virtual CategoryPlaceOfSamplingSpecimen PlaceOfSampling { get; set; } = null!;
}
