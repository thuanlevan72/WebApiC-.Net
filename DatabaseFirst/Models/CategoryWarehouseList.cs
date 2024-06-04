using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách kho
/// </summary>
public partial class CategoryWarehouseList
{
    public Guid ReceiptWarehouseListId { get; set; }

    public Guid? ReceiptCodeSuppliesId { get; set; }

    public Guid? ReceiptCodeEstimateId { get; set; }

    public Guid? CompensationSlipId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual CategoryCompensationSlip? CompensationSlip { get; set; }

    public virtual CategoryReceiptCodeEstimate? ReceiptCodeEstimate { get; set; }

    public virtual CategoryReceiptCodeSupply? ReceiptCodeSupplies { get; set; }
}
