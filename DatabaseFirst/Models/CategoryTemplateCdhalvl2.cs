using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục cấp 2 template cdjha
/// </summary>
public partial class CategoryTemplateCdhalvl2
{
    public Guid TemplateCdhaLvl2Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public Guid TemplateCdhaLvl1Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CategoryTemplateCdhalvl3> CategoryTemplateCdhalvl3s { get; set; } = new List<CategoryTemplateCdhalvl3>();

    public virtual ICollection<CategoryTemplateCdha> CategoryTemplateCdhas { get; set; } = new List<CategoryTemplateCdha>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual CategoryTemplateCdhalvl1 TemplateCdhaLvl1 { get; set; } = null!;
}
