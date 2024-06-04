using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục vật tư theo kích cỡ
/// </summary>
public partial class CategorySupplieBySize
{
    public Guid SupplieBySizeId { get; set; }

    public string SupplieBySizeCode { get; set; } = null!;

    public string SuppliesBySizeName { get; set; } = null!;

    public string EquivalentCode { get; set; } = null!;

    public string BidName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<SuppliesSupplieBySize> SuppliesSupplieBySizes { get; set; } = new List<SuppliesSupplieBySize>();
}
