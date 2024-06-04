using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hình thức nhập/Loại xuất
/// </summary>
public partial class CategoryInputOrOutputType
{
    public Guid InputOrOutputTypeId { get; set; }

    /// <summary>
    /// Mã hình thức nhập/loại xuất
    /// </summary>
    public string InputOrOutputTypeCode { get; set; } = null!;

    /// <summary>
    /// Tên hình thức nhập/loại xuất
    /// </summary>
    public string InputOrOutputTypeName { get; set; } = null!;

    /// <summary>
    /// Hình thức
    /// </summary>
    public Guid? MethodAttributeId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<InputOrOutputTypeMethod> InputOrOutputTypeMethods { get; set; } = new List<InputOrOutputTypeMethod>();

    public virtual CategoryAttribute? MethodAttribute { get; set; }
}
