using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh- phân loại thuốc
/// </summary>
public partial class ReceiptCodeDrugClassification
{
    public Guid ReceiptCodeMedicineTypeId { get; set; }

    public Guid ReceiptCodeId { get; set; }

    public Guid DrugClassificationId { get; set; }

    public virtual CategoryDrugClassification DrugClassification { get; set; } = null!;

    public virtual CategoryReceiptCode ReceiptCode { get; set; } = null!;
}
