using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ kèm theo - Loại đối tượng
/// </summary>
public partial class TabAccompanyingServicesObjectType
{
    public Guid AccompanyingServicesObjectTypeId { get; set; }

    public Guid AccompanyingServicesId { get; set; }

    public Guid ObjectTypeId { get; set; }

    public virtual CategoryTabAccompanyingService AccompanyingServices { get; set; } = null!;

    public virtual CategoryAttribute ObjectType { get; set; } = null!;
}
