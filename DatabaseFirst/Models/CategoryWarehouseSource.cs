using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nguồn nhập kho
/// </summary>
public partial class CategoryWarehouseSource
{
    public Guid WarehouseSourceId { get; set; }

    /// <summary>
    /// mã nguồn nhập kho
    /// </summary>
    public string WarehouseSourceCode { get; set; } = null!;

    /// <summary>
    /// tên nguồn nhập kho
    /// </summary>
    public string WarehouseSourceName { get; set; } = null!;

    /// <summary>
    /// id loại dịch vụ
    /// </summary>
    public Guid? ServiceTypeAttributeId { get; set; }

    /// <summary>
    /// thầu
    /// </summary>
    public int IsBid { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual ICollection<CategoryBidService> CategoryBidServices { get; set; } = new List<CategoryBidService>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryAttribute? ServiceTypeAttribute { get; set; }
}
