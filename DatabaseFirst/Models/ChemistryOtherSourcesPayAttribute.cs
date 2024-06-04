using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hóa chất - Nguồn khác chi trả
/// </summary>
public partial class ChemistryOtherSourcesPayAttribute
{
    public Guid ChemistryOtherSourcePayAttributeId { get; set; }

    public Guid ChemistriesId { get; set; }

    public Guid OtherSourcePayAttributeId { get; set; }

    public virtual CategoryChemistry Chemistries { get; set; } = null!;

    public virtual CategoryAttribute OtherSourcePayAttribute { get; set; } = null!;
}
