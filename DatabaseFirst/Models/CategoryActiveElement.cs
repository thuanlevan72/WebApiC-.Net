using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hoạt chất
/// </summary>
public partial class CategoryActiveElement
{
    public Guid ActiveElementId { get; set; }

    /// <summary>
    /// mã hoạt chất
    /// </summary>
    public string ActiveElementCode { get; set; } = null!;

    /// <summary>
    /// tên hoạt chất
    /// </summary>
    public string ActiveElementName { get; set; } = null!;

    /// <summary>
    /// id loại dịch vụ
    /// </summary>
    public Guid? ServiceTypeAttributeId { get; set; }

    /// <summary>
    /// id dược lý
    /// </summary>
    public Guid? PharmacologicalId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? ActiveElementCodeTt40 { get; set; }

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicines { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractionActiveElementId1Navigations { get; set; } = new List<CategoryReportDrugInteraction>();

    public virtual ICollection<CategoryReportDrugInteraction> CategoryReportDrugInteractionActiveElementId2Navigations { get; set; } = new List<CategoryReportDrugInteraction>();

    public virtual CategoryPharmacologicalProperty? Pharmacological { get; set; }

    public virtual CategoryAttribute? ServiceTypeAttribute { get; set; }
}
