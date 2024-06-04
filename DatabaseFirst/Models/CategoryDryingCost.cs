using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi phí hấp sấy
/// </summary>
public partial class CategoryDryingCost
{
    public Guid DryingCostId { get; set; }

    public decimal DryingCost { get; set; }

    public string DecisionBidId { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<DryingCostSupply> DryingCostSupplies { get; set; } = new List<DryingCostSupply>();
}
