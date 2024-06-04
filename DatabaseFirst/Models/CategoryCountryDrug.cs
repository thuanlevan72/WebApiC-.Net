using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nước sản xuất thuốc
/// </summary>
public partial class CategoryCountryDrug
{
    public Guid CountryDrugId { get; set; }

    public string CountryName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();
}
