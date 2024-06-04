using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu dự trù - Hàng hóa
/// </summary>
public partial class ReceiptCodeEstimateProduct
{
    public Guid ReceiptCodeEstimateProductId { get; set; }

    public Guid ProductId { get; set; }

    /// <summary>
    /// số lượng dự trù
    /// </summary>
    public int QtyEstmatime { get; set; }

    /// <summary>
    /// số lượng duyệt
    /// </summary>
    public int QtyApprove { get; set; }

    public Guid ReceiptCodeEstimateId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid ConceptId { get; set; }

    public Guid? ReceiptCodeSupplieProductId { get; set; }

    public int? QtyRemain { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual ICollection<ProductSuppliesProductEstimate> ProductSuppliesProductEstimates { get; set; } = new List<ProductSuppliesProductEstimate>();

    public virtual CategoryReceiptCodeEstimate ReceiptCodeEstimate { get; set; } = null!;

    public virtual ReceiptCodeSuppliesProduct? ReceiptCodeSupplieProduct { get; set; }
}
