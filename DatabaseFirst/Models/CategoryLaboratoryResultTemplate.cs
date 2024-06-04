using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu kết quả xét nghiệm
/// </summary>
public partial class CategoryLaboratoryResultTemplate
{
    public Guid LaboratoryResultTemplateId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string LaboratoryResultTemplateCode { get; set; } = null!;

    /// <summary>
    /// Tên
    /// </summary>
    public string LaboratoryResultTemplateName { get; set; } = null!;

    /// <summary>
    /// kết quả
    /// </summary>
    public string Result { get; set; } = null!;

    /// <summary>
    /// kết luận
    /// </summary>
    public string Conclude { get; set; } = null!;

    /// <summary>
    /// vị thể
    /// </summary>
    public string Position { get; set; } = null!;

    /// <summary>
    /// Đại thể
    /// </summary>
    public string Roughly { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<LaboratoryResultTemplateLaboratoryService> LaboratoryResultTemplateLaboratoryServices { get; set; } = new List<LaboratoryResultTemplateLaboratoryService>();

    public virtual ICollection<LaboratoryResultTemplateTabChildIndex> LaboratoryResultTemplateTabChildIndices { get; set; } = new List<LaboratoryResultTemplateTabChildIndex>();
}
