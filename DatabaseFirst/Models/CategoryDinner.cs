using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ suất ăn
/// </summary>
public partial class CategoryDinner
{
    public Guid DinnerId { get; set; }

    /// <summary>
    /// loại bữa ăn
    /// </summary>
    public Guid? AttributeId { get; set; }

    /// <summary>
    /// đơn vị
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// tên dịch vụ
    /// </summary>
    public string DinnerName { get; set; } = null!;

    /// <summary>
    /// mã dịch vụ
    /// </summary>
    public string DinnerCode { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? ConceptId { get; set; }

    public double? PriceNonInsurance { get; set; }

    public double? PriceInsurance { get; set; }

    public double? Surcharge { get; set; }

    public virtual CategoryAttribute? Attribute { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
