using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm dịch vụ cấp 2
/// </summary>
public partial class CategoryGroupServiceLevel2
{
    public Guid GroupServiceLevel2Id { get; set; }

    /// <summary>
    /// mã danh mục nhóm dịch vụ cấp 2
    /// </summary>
    public string GroupServiceLevel2Code { get; set; } = null!;

    /// <summary>
    /// Tên nhóm dịch vụ cấp 2
    /// </summary>
    public string GroupServiceLevel2Name { get; set; } = null!;

    /// <summary>
    /// id nhóm dịch vụ cấp 1
    /// </summary>
    public Guid? GroupServiceLevel1Id { get; set; }

    /// <summary>
    /// Trạng thái hoàn thành dv
    /// </summary>
    public Guid? ServiceCompleteStatusAttributeId { get; set; }

    /// <summary>
    /// Tên báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

    /// <summary>
    /// Trạng thái sinh số thứ tự
    /// </summary>
    public Guid? NumberGenerateStatusId { get; set; }

    /// <summary>
    /// Công suất tối đa
    /// </summary>
    public int? MaxPerformance { get; set; }

    /// <summary>
    /// Mã thiết bị
    /// </summary>
    public string? DeviceCode { get; set; }

    /// <summary>
    /// Lưu phim chụp
    /// </summary>
    public int? IsStoreFilm { get; set; }

    /// <summary>
    /// Tiếp đón CLS
    /// </summary>
    public int IsCls { get; set; }

    /// <summary>
    /// Bỏ qua kết quả lâu
    /// </summary>
    public int? IsSkipResult { get; set; }

    public int? IsPriorityPatient { get; set; }

    /// <summary>
    /// Sinh số riêng cho NB Nội trú
    /// </summary>
    public int? IsIpdGenerate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int? IsMicrobiology { get; set; }

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryGroupServiceLevel3> CategoryGroupServiceLevel3s { get; set; } = new List<CategoryGroupServiceLevel3>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServices { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRetailSurplu> CategoryRetailSurplus { get; set; } = new List<CategoryRetailSurplu>();

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual CategoryGroupServiceLevel1? GroupServiceLevel1 { get; set; }

    public virtual ICollection<GroupServiceLevel2ServiceUnCompleteStatus> GroupServiceLevel2ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel2ServiceUnCompleteStatus>();

    public virtual CategoryAttribute? NumberGenerateStatus { get; set; }

    public virtual ICollection<PlaceOfSamplingServiceGroupLvl2> PlaceOfSamplingServiceGroupLvl2s { get; set; } = new List<PlaceOfSamplingServiceGroupLvl2>();

    public virtual CategoryReport? Report { get; set; }

    public virtual CategoryAttribute? ServiceCompleteStatusAttribute { get; set; }
}
