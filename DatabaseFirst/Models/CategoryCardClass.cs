using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hạng thẻ
/// </summary>
public partial class CategoryCardClass
{
    public Guid CardClassId { get; set; }

    /// <summary>
    /// mã hạng thẻ
    /// </summary>
    public string CardClassCode { get; set; } = null!;

    /// <summary>
    /// tên hạng thẻ
    /// </summary>
    public string CardClassName { get; set; } = null!;

    /// <summary>
    /// số điểm tối thiểu
    /// </summary>
    public int PointMin { get; set; }

    /// <summary>
    /// hình ảnh thẻ
    /// </summary>
    public string? Icon { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryGroupCustomerCare> CategoryGroupCustomerCares { get; set; } = new List<CategoryGroupCustomerCare>();
}
