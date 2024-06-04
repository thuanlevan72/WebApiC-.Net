using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phục hồi chức năng - lịch sử thay đổi
/// </summary>
public partial class RehabilitationsServicesTabHistoryChanged
{
    public Guid RehabilitationServiceTabHistoryChangedId { get; set; }

    public Guid RehabilitationServiceId { get; set; }

    public Guid TabHistoryChangedId { get; set; }

    public virtual CategoryRehabilitationsService RehabilitationService { get; set; } = null!;

    public virtual CategoryTabHistoryChanged TabHistoryChanged { get; set; } = null!;
}
