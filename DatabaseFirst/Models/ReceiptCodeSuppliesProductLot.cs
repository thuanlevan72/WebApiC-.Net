using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu nhập nhà cung cấp - số lô
/// </summary>
public partial class ReceiptCodeSuppliesProductLot
{
    public Guid ReceiptCodeSuppliesProductLotId { get; set; }

    public Guid ReceiptCodeSuppliesProductId { get; set; }

    public string LotNumber { get; set; } = null!;

    public DateTime ExpiredDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ReceiptCodeSuppliesProduct ReceiptCodeSuppliesProduct { get; set; } = null!;
}
