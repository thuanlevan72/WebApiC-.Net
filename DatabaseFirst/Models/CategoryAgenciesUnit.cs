using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục cơ quan đơn vị
/// </summary>
public partial class CategoryAgenciesUnit
{
    public Guid AgenciesUnitId { get; set; }

    /// <summary>
    /// mã cơ quan đơn vị
    /// </summary>
    public string AgenciesUnitCode { get; set; } = null!;

    /// <summary>
    /// tên cơ quan đơn vị
    /// </summary>
    public string AgenciesUnitName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryRepresentative> CategoryRepresentatives { get; set; } = new List<CategoryRepresentative>();
}
