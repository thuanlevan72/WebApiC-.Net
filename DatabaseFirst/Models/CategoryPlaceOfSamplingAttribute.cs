using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nơi lấy mẫu bệnh phẩm - đối tượng KCB
/// </summary>
public partial class CategoryPlaceOfSamplingAttribute
{
    public Guid PlaceOfSamplingAttributedId { get; set; }

    public Guid PlaceOfSamplingId { get; set; }

    public Guid AttributeId { get; set; }

    public virtual CategoryAttribute Attribute { get; set; } = null!;

    public virtual CategoryPlaceOfSamplingSpecimen PlaceOfSampling { get; set; } = null!;
}
