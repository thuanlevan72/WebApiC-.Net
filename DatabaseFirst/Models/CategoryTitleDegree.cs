using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục học hàm học vị
/// </summary>
public partial class CategoryTitleDegree
{
    public Guid TitleDegreeId { get; set; }

    /// <summary>
    /// mã học hàm học vị
    /// </summary>
    public string TitleDegreeCode { get; set; } = null!;

    /// <summary>
    /// tên học hàm học vị
    /// </summary>
    public string TitleDegreeName { get; set; } = null!;

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string Abbreviations { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryEmployee> CategoryEmployees { get; set; } = new List<CategoryEmployee>();
}
