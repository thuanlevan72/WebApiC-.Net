using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - Dịch vụ kèm theo
/// </summary>
public partial class SurgicalProceduresServiceTabAccompanyingService
{
    public Guid SurgicalProceduresServiceTabAccompanyingServiceId { get; set; }

    public Guid SurgicalProceduresServiceId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategorySurgicalProceduresService SurgicalProceduresService { get; set; } = null!;

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
