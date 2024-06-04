using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đặc tính dược lý
/// </summary>
public partial class CategoryPharmacologicalProperty
{
    public Guid PharmacologicalPropertiesId { get; set; }

    public string PharmacologicalPropertiesCode { get; set; } = null!;

    public string PharmacologicalPropertiesName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryActiveElement> CategoryActiveElements { get; set; } = new List<CategoryActiveElement>();

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractionPharmacologicalPropertiesId1Navigations { get; set; } = new List<CategoryReportDrugInteraction>();

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractionPharmacologicalPropertiesId2Navigations { get; set; } = new List<CategoryReportDrugInteraction>();
}
