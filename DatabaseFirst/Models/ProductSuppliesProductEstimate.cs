using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Sản phẩm vật tư - sản phẩm dự trù
/// </summary>
public partial class ProductSuppliesProductEstimate
{
    public Guid ProductSuppliesProductEstimateId { get; set; }

    public Guid? ReceiptCodeProductSuppliesId { get; set; }

    public Guid? ReceiptCodeProductEstimateId { get; set; }

    public int? QtyProductSupplies { get; set; }

    public int? QtyProductEstimate { get; set; }

    public int QtyRemain { get; set; }

    public Guid? WarehouseImport { get; set; }

    public Guid? WarehouseExport { get; set; }

    public Guid? PatientId { get; set; }

    public virtual ReceiptCodeEstimateProduct? ReceiptCodeProductEstimate { get; set; }

    public virtual ReceiptCodeSuppliesProduct? ReceiptCodeProductSupplies { get; set; }

    public virtual ICollection<ReceiptCodeSuppliesProduct> ReceiptCodeSuppliesProducts { get; set; } = new List<ReceiptCodeSuppliesProduct>();

    public virtual CategoryWarehouse? WarehouseExportNavigation { get; set; }

    public virtual CategoryWarehouse? WarehouseImportNavigation { get; set; }
}
