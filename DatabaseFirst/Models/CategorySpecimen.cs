using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục bệnh phẩm
/// </summary>
public partial class CategorySpecimen
{
    public Guid SpecimensId { get; set; }

    public string SpecimensCode { get; set; } = null!;

    public string SpecimensName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }
}
