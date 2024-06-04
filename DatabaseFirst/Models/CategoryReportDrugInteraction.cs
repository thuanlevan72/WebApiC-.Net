using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục khai báo tương tác thuốc
/// </summary>
public partial class CategoryReportDrugInteraction
{
    public Guid ReportDrugInteractionId { get; set; }

    /// <summary>
    /// đặc tính dược lý1
    /// </summary>
    public Guid? PharmacologicalPropertiesId1 { get; set; }

    /// <summary>
    /// đặc tính dược lý 2
    /// </summary>
    public Guid? PharmacologicalPropertiesId2 { get; set; }

    /// <summary>
    /// Hoạt chất 1
    /// </summary>
    public Guid ActiveElementId1 { get; set; }

    /// <summary>
    /// hoặc chất 2
    /// </summary>
    public Guid ActiveElementId2 { get; set; }

    /// <summary>
    /// mức độ tương tác
    /// </summary>
    public Guid LevelOfInteractionId { get; set; }

    /// <summary>
    /// Hậu quả
    /// </summary>
    public Guid InteractionConsequencesId { get; set; }

    /// <summary>
    /// Cơ chế
    /// </summary>
    public string? Mechanism { get; set; }

    /// <summary>
    /// xử trí
    /// </summary>
    public string? Solve { get; set; }

    /// <summary>
    /// cảnh báo icd
    /// </summary>
    public int? IcdWarning { get; set; }

    /// <summary>
    /// chặn kê thuốc
    /// </summary>
    public int IsStopPrescribingMedication { get; set; }

    /// <summary>
    /// xét nghiệm
    /// </summary>
    public int? IsLaboratory { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsIcdWarning { get; set; }

    public virtual CategoryActiveElement ActiveElementId1Navigation { get; set; } = null!;

    public virtual CategoryActiveElement ActiveElementId2Navigation { get; set; } = null!;

    public virtual CategoryInteractionConsequence InteractionConsequences { get; set; } = null!;

    public virtual CategoryLevelOfInteraction LevelOfInteraction { get; set; } = null!;

    public virtual CategoryPharmacologicalProperty? PharmacologicalPropertiesId1Navigation { get; set; }

    public virtual CategoryPharmacologicalProperty? PharmacologicalPropertiesId2Navigation { get; set; }

    public virtual ICollection<ReportDrugInteractionLaboratoryService> ReportDrugInteractionLaboratoryServices { get; set; } = new List<ReportDrugInteractionLaboratoryService>();

    public virtual ICollection<ReportDrugInteractionsAtc1code> ReportDrugInteractionsAtc1codes { get; set; } = new List<ReportDrugInteractionsAtc1code>();

    public virtual ICollection<ReportDrugInteractionsAtc2code> ReportDrugInteractionsAtc2codes { get; set; } = new List<ReportDrugInteractionsAtc2code>();

    public virtual ICollection<ReportDrugInteractionsDiseaseName> ReportDrugInteractionsDiseaseNames { get; set; } = new List<ReportDrugInteractionsDiseaseName>();

    public virtual ICollection<ReportDrugInteractionsDrug1> ReportDrugInteractionsDrug1s { get; set; } = new List<ReportDrugInteractionsDrug1>();

    public virtual ICollection<ReportDrugInteractionsDrug2> ReportDrugInteractionsDrug2s { get; set; } = new List<ReportDrugInteractionsDrug2>();
}
