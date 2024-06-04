using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mẫu QMS
/// </summary>
public partial class CategoryTemplateQm
{
    public Guid TemplateQmsId { get; set; }

    public string TemplateQmsCode { get; set; } = null!;

    public string TemplateQmsName { get; set; } = null!;

    public Guid QmsTypeId { get; set; }

    public string QmsLink { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryKiosk> CategoryKiosks { get; set; } = new List<CategoryKiosk>();

    public virtual CategoryAttribute QmsType { get; set; } = null!;
}
