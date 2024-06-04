using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử Đối tác - Loại đối tác
/// </summary>
public partial class HistoryPartnerTypeAtrribute
{
    public Guid HistoryPartnerTypeAttributeId { get; set; }

    public Guid HistoryPartnerId { get; set; }

    public Guid? TypeAttributeId { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryHistoryPartner HistoryPartner { get; set; } = null!;

    public virtual CategoryAttribute? TypeAttribute { get; set; }
}
