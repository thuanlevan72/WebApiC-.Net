using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục văn bằng chuyên môn
/// </summary>
public partial class CategoryProfessionalDiploma
{
    public Guid ProfessionalDiplomaId { get; set; }

    /// <summary>
    /// mã văn bằng chuyên môn
    /// </summary>
    public string ProfessionalDiplomaCode { get; set; } = null!;

    /// <summary>
    /// tên văn bằng chuyên môn
    /// </summary>
    public string ProfessionalDiplomaName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryEmployee> CategoryEmployees { get; set; } = new List<CategoryEmployee>();
}
