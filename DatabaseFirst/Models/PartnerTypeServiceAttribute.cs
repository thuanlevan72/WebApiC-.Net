using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác - Loại dịch vụ
/// </summary>
public partial class PartnerTypeServiceAttribute
{
    public Guid PartnerTypeServiceId { get; set; }

    public Guid PartnerId { get; set; }

    public Guid? TypeServiceAttributeId { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryPartner Partner { get; set; } = null!;

    public virtual CategoryAttribute? TypeServiceAttribute { get; set; }
}
