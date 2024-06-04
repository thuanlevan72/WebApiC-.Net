using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thay đổi dịch vụ
/// </summary>
public partial class CdhatdcnlistChangeService
{
    public Guid CdhaTdcnListChangeServiceId { get; set; }

    public Guid CdhaTdcnListId { get; set; }

    public Guid ProductId { get; set; }

    public Guid RoomId { get; set; }

    public Guid ReasonForAdvanceId { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CdhaTdcnList CdhaTdcnList { get; set; } = null!;

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual CategoryReasonForAdvance ReasonForAdvance { get; set; } = null!;

    public virtual CategoryRoom Room { get; set; } = null!;
}
