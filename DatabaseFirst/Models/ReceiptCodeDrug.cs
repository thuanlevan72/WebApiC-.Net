using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh - Đơn thuốc
/// </summary>
public partial class ReceiptCodeDrug
{
    public Guid ReceiptCodeDrugId { get; set; }

    public Guid ReceiptCodeId { get; set; }

    public Guid DrugId { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryReceiptCode ReceiptCode { get; set; } = null!;
}
