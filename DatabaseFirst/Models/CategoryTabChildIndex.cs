using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chỉ số con
/// </summary>
public partial class CategoryTabChildIndex
{
    public Guid TabChildIndexId { get; set; }

    public string ChildIndexCode { get; set; } = null!;

    public string ChildIndexName { get; set; } = null!;

    public string? EquivalentCode { get; set; }

    public string? EquivalentName { get; set; }

    public string? LisCode { get; set; }

    public int? ResultType { get; set; }

    public string? ResultReference { get; set; }

    public string? OrderNumber { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? UnitId { get; set; }

    public string? IndexFemaleLow { get; set; }

    public string? IndexFemaleHight { get; set; }

    public string? IndexMaleLow { get; set; }

    public string? IndexMaleHight { get; set; }

    public string? Unit { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<LaboratoryResultTemplateTabChildIndex> LaboratoryResultTemplateTabChildIndices { get; set; } = new List<LaboratoryResultTemplateTabChildIndex>();

    public virtual ICollection<LaboratoryServiceTabChildIndex> LaboratoryServiceTabChildIndices { get; set; } = new List<LaboratoryServiceTabChildIndex>();

    public virtual CategoryUnit? UnitNavigation { get; set; }
}
