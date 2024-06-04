using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục máy in
/// </summary>
public partial class CategoryPrint
{
    public Guid PrintId { get; set; }

    /// <summary>
    /// mã máy tính
    /// </summary>
    public string PrintCode { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryPrintName> CategoryPrintNames { get; set; } = new List<CategoryPrintName>();
}
