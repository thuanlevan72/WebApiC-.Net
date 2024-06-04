using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh
/// </summary>
public partial class CategoryReceiptList
{
    public Guid ReceiptListId { get; set; }

    public Guid ConceptId { get; set; }

    public Guid ReceiptType { get; set; }

    public Guid FromWarehouseId { get; set; }

    public Guid ToWarehouseId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public Guid DepartmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public DateTime DeletedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public virtual ICollection<ReceiptListDrugClassification> ReceiptListDrugClassifications { get; set; } = new List<ReceiptListDrugClassification>();
}
