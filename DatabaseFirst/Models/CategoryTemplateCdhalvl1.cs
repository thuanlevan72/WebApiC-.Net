using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mẫu cdha level1
/// </summary>
public partial class CategoryTemplateCdhalvl1
{
    public Guid TemplateCdhaLvl1Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CategoryTemplateCdhalvl2> CategoryTemplateCdhalvl2s { get; set; } = new List<CategoryTemplateCdhalvl2>();

    public virtual ICollection<CategoryTemplateCdha> CategoryTemplateCdhas { get; set; } = new List<CategoryTemplateCdha>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();
}
