using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục vật tư bộ
/// </summary>
public partial class CategoryKitSupply
{
    public Guid KitSuppliesId { get; set; }

    /// <summary>
    /// mã chi tiết
    /// </summary>
    public string KitSuppliesCode { get; set; } = null!;

    /// <summary>
    /// tên chi tiết
    /// </summary>
    public string KitSuppliesName { get; set; } = null!;

    /// <summary>
    /// đơn vị tính
    /// </summary>
    public Guid UnitId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int Quantity { get; set; }

    public decimal PriceVat { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán
    /// </summary>
    public int PaymentRatio { get; set; }

    /// <summary>
    /// mã ánh xạ
    /// </summary>
    public string MappingCode { get; set; } = null!;

    /// <summary>
    /// tên thầu
    /// </summary>
    public string BidName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<SuppliesKitSupply> SuppliesKitSupplies { get; set; } = new List<SuppliesKitSupply>();

    public virtual CategoryUnit Unit { get; set; } = null!;
}
