using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Chương trình - Dịch vụ
/// </summary>
public partial class ProgramService
{
    public Guid ProgramServiceId { get; set; }

    public Guid ProductId { get; set; }

    public Guid ProgramId { get; set; }

    public double? PercentDiscount { get; set; }

    public decimal? MoneyDiscount { get; set; }

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual CategoryProgram Program { get; set; } = null!;
}
