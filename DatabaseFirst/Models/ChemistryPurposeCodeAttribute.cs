using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hóa chất - Mục đích sử dụng
/// </summary>
public partial class ChemistryPurposeCodeAttribute
{
    public Guid ChemistryPurposeCodeAttributeId { get; set; }

    public Guid ChemistriesId { get; set; }

    public Guid PurposeCodeAttributeId { get; set; }

    public virtual CategoryChemistry Chemistries { get; set; } = null!;

    public virtual CategoryAttribute PurposeCodeAttribute { get; set; } = null!;
}
