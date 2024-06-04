using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - lịch sử thay đổi
/// </summary>
public partial class SurgicalProceduresServicesTabHistoryChanged
{
    public Guid SurgicalProcedureServiceTabHistoryChangedId { get; set; }

    public Guid SurgicalProcedureServiceId { get; set; }

    public Guid TabHistoryChangedId { get; set; }

    public virtual CategorySurgicalProceduresService SurgicalProcedureService { get; set; } = null!;

    public virtual CategoryTabHistoryChanged TabHistoryChanged { get; set; } = null!;
}
