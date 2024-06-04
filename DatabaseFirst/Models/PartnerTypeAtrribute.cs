using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác - Loại đối tác
/// </summary>
public partial class PartnerTypeAtrribute
{
    public Guid PartnerTypeAttributeId { get; set; }

    public Guid PartnerId { get; set; }

    public Guid TypeAttributeId { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryPartner Partner { get; set; } = null!;

    public virtual CategoryAttribute TypeAttribute { get; set; } = null!;
}
