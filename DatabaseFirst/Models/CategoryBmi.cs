using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đánh giá BMI
/// </summary>
public partial class CategoryBmi
{
    public Guid BmiId { get; set; }

    /// <summary>
    /// mã đánh giá
    /// </summary>
    public string BmiCode { get; set; } = null!;

    /// <summary>
    /// tên đánh giá
    /// </summary>
    public string BmiName { get; set; } = null!;

    /// <summary>
    /// giá trị nhỏ nhất
    /// </summary>
    public decimal? BmiMin { get; set; }

    /// <summary>
    /// giá trị lớn nhất
    /// </summary>
    public decimal? BmiMax { get; set; }

    /// <summary>
    /// mô tả
    /// </summary>
    public string? BmiDesc { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
