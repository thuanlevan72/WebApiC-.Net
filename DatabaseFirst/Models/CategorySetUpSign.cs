using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thiết lập chân ký
/// </summary>
public partial class CategorySetUpSign
{
    public Guid SetUpSignId { get; set; }

    public string NumberSign { get; set; } = null!;

    public int ImageHeight { get; set; }

    public int ImageWidth { get; set; }

    public Guid ReportId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategorySignLevel> CategorySignLevels { get; set; } = new List<CategorySignLevel>();

    public virtual CategoryReport Report { get; set; } = null!;
}
