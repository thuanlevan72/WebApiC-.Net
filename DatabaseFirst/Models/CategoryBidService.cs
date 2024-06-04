using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thầu
/// </summary>
public partial class CategoryBidService
{
    public Guid BidServiceId { get; set; }

    /// <summary>
    /// năm
    /// </summary>
    public int BidYear { get; set; }

    /// <summary>
    /// quyết định thầu
    /// </summary>
    public string DecisionBid { get; set; } = null!;

    /// <summary>
    /// tên gói thầu
    /// </summary>
    public string BidName { get; set; } = null!;

    /// <summary>
    /// nguồn kho
    /// </summary>
    public Guid WarehouseSourceId { get; set; }

    /// <summary>
    /// loại thầu
    /// </summary>
    public int BidType { get; set; }

    /// <summary>
    /// ngày công bố
    /// </summary>
    public DateTime PublicDate { get; set; }

    /// <summary>
    /// hiệu lực thầu
    /// </summary>
    public DateTime ActiveDate { get; set; }

    public Guid DepartmentId { get; set; }

    /// <summary>
    /// ngày hợp đồng
    /// </summary>
    public DateTime? ContactDated { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int? StatusBid { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<BidServiceServiceType> BidServiceServiceTypes { get; set; } = new List<BidServiceServiceType>();

    public virtual ICollection<CategoryBidDetail> CategoryBidDetails { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryWarehouseSource WarehouseSource { get; set; } = null!;
}
