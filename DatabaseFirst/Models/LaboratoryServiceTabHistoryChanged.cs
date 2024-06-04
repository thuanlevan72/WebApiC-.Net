using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - lích sửa chỉnh sửa
/// </summary>
public partial class LaboratoryServiceTabHistoryChanged
{
    public Guid LaboratoryServiceTabHistoryChangedId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabHistoryChangedId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryTabHistoryChanged TabHistoryChanged { get; set; } = null!;
}
