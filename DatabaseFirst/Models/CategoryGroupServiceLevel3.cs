using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm dịch vụ cấp 3
/// </summary>
public partial class CategoryGroupServiceLevel3
{
    public Guid GroupServiceLevel3Id { get; set; }

    /// <summary>
    /// mã nhóm dịch vụ cấp 3
    /// </summary>
    public string GroupServiceLevel3Code { get; set; } = null!;

    /// <summary>
    /// tên nhóm dịch vụ cấp 3
    /// </summary>
    public string GroupServiceLevel3Name { get; set; } = null!;

    /// <summary>
    /// nhóm dịch vụ nhóm cấp 1
    /// </summary>
    public Guid GroupServiceLevel1Id { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 3
    /// </summary>
    public Guid GroupServiceLevel2Id { get; set; }

    /// <summary>
    /// stt trên báo cáo
    /// </summary>
    public int? NumberReport { get; set; }

    public Guid? ReportId { get; set; }

    /// <summary>
    /// Trạng thái hoàn thành dv
    /// </summary>
    public Guid? ServiceCompletedStatusAttributeId { get; set; }

    /// <summary>
    /// Trạng thái sinh số thứ tự
    /// </summary>
    public Guid? NumberGenerateStatusAttributeId { get; set; }

    /// <summary>
    /// Bỏ qua kết quả lâu
    /// </summary>
    public int? IsSkipResult { get; set; }

    /// <summary>
    /// Sinh số riêng cho NB Ưu tiên
    /// </summary>
    public int? IsPriorityPatient { get; set; }

    /// <summary>
    /// Sinh số riêng cho NB Nội trú
    /// </summary>
    public int? IsIpdGenerate { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServices { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual CategoryGroupServiceLevel1 GroupServiceLevel1 { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLevel2 { get; set; } = null!;

    public virtual ICollection<GroupServiceLevel3ServiceUnCompleteStatus> GroupServiceLevel3ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel3ServiceUnCompleteStatus>();

    public virtual CategoryAttribute? NumberGenerateStatusAttribute { get; set; }

    public virtual CategoryReport? Report { get; set; }

    public virtual CategoryAttribute? ServiceCompletedStatusAttribute { get; set; }
}
