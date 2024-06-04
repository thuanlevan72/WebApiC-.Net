using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục cấp 3 template cdha
/// </summary>
public partial class CategoryTemplateCdhalvl3
{
    public Guid TemplateCdhaLvl3Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public Guid TemplateCdhaLvl2Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CategoryTemplateCdha> CategoryTemplateCdhas { get; set; } = new List<CategoryTemplateCdha>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual CategoryTemplateCdhalvl2 TemplateCdhaLvl2 { get; set; } = null!;
}
