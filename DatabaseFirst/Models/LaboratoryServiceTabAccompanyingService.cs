using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Xét nghiệm - dịch vụ kèm theo
/// </summary>
public partial class LaboratoryServiceTabAccompanyingService
{
    public Guid LaboratoryServiceTabAccompanyingServiceId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public Guid TabAccompanyingServiceId { get; set; }

    public Guid ProductId { get; set; }

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual CategoryTabAccompanyingService TabAccompanyingService { get; set; } = null!;
}
