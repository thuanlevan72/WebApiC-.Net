using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử Đối tác - Loại dịch vụ
/// </summary>
public partial class HistoryPartnerTypeServiceAttribute
{
    public Guid HistoryPartnerTypeServiceId { get; set; }

    public Guid HistoryPartnerId { get; set; }

    public Guid? TypeServiceAttributeId { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryHistoryPartner HistoryPartner { get; set; } = null!;

    public virtual CategoryAttribute? TypeServiceAttribute { get; set; }
}
