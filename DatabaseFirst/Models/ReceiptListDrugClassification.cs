using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh - phân loại thuốc
/// </summary>
public partial class ReceiptListDrugClassification
{
    public Guid ReceiptListDrugClassificationId { get; set; }

    public Guid ReceiptListId { get; set; }

    public Guid DrugClassificationId { get; set; }

    public virtual CategoryDrugClassification DrugClassification { get; set; } = null!;

    public virtual CategoryReceiptList ReceiptList { get; set; } = null!;
}
