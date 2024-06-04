using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// tên máy in
/// </summary>
public partial class CategoryPrintName
{
    public Guid PrintNameId { get; set; }

    public string PrintName { get; set; } = null!;

    public string PrintIp { get; set; } = null!;

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? PrintId { get; set; }

    public virtual ICollection<CategoryPrintType> CategoryPrintTypes { get; set; } = new List<CategoryPrintType>();

    public virtual CategoryPrint? Print { get; set; }
}
