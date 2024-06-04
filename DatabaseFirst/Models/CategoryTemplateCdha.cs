using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// MẪu cdha
/// </summary>
public partial class CategoryTemplateCdha
{
    public Guid TemplateCdhaId { get; set; }

    public Guid TemplateCdhaLv1 { get; set; }

    public Guid TemplateCdhaLv2 { get; set; }

    public Guid TemplateCdhaLv3 { get; set; }

    public string TitleTemplate { get; set; } = null!;

    public string ContentTemplate { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual CategoryTemplateCdhalvl1 TemplateCdhaLv1Navigation { get; set; } = null!;

    public virtual CategoryTemplateCdhalvl2 TemplateCdhaLv2Navigation { get; set; } = null!;

    public virtual CategoryTemplateCdhalvl3 TemplateCdhaLv3Navigation { get; set; } = null!;
}
