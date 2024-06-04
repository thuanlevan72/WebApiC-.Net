using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu nhập dự trù
/// </summary>
public partial class CategoryReceiptCodeEstimate
{
    public Guid ReceiptCodeEstimateId { get; set; }

    /// <summary>
    /// kho nhập
    /// </summary>
    public Guid WarehouseImport { get; set; }

    /// <summary>
    /// kho xuất
    /// </summary>
    public Guid WarehouseExport { get; set; }

    /// <summary>
    /// tháng dự trù
    /// </summary>
    public int? MonthEstimate { get; set; }

    /// <summary>
    /// hình thức nhập
    /// </summary>
    public Guid? MethodImportType { get; set; }

    public string? Note { get; set; }

    public int IsStatus { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? ReceiptCodeEstimateCode { get; set; }

    /// <summary>
    /// số lượng dự trù
    /// </summary>
    public int? QtyEstimate { get; set; }

    /// <summary>
    /// số lần
    /// </summary>
    public int? Times { get; set; }

    public Guid? ReceiptCodeSuppliesId { get; set; }

    public string? Reason { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ApprovedAccount { get; set; }

    public int? IsType { get; set; }

    public virtual CategoryAccount? ApprovedAccountNavigation { get; set; }

    public virtual ICollection<CategoryWarehouseList> CategoryWarehouseLists { get; set; } = new List<CategoryWarehouseList>();

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryAttribute? MethodImportTypeNavigation { get; set; }

    public virtual ICollection<ReceiptCodeEstimateProduct> ReceiptCodeEstimateProducts { get; set; } = new List<ReceiptCodeEstimateProduct>();

    public virtual CategoryReceiptCodeSupply? ReceiptCodeSupplies { get; set; }

    public virtual CategoryWarehouse WarehouseExportNavigation { get; set; } = null!;

    public virtual CategoryWarehouse WarehouseImportNavigation { get; set; } = null!;
}
