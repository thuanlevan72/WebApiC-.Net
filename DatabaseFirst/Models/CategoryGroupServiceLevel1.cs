using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm dịch vụ cấp 1
/// </summary>
public partial class CategoryGroupServiceLevel1
{
    public Guid GroupServiceLvl1Id { get; set; }

    /// <summary>
    /// mã nhóm dịch vụ cấp 1
    /// </summary>
    public string GroupServiceLvl1Code { get; set; } = null!;

    /// <summary>
    /// tên mã nhóm dịch vụ cấp 1
    /// </summary>
    public string GroupServiceLvl1Name { get; set; } = null!;

    /// <summary>
    /// stt trên bảng kê
    /// </summary>
    public int? NumberOnList { get; set; }

    /// <summary>
    /// Trạng thái hoàn thành dv
    /// </summary>
    public Guid? ServiceCompleteStatusAttributeId { get; set; }

    /// <summary>
    /// trạng thái sinh số thứ tự
    /// </summary>
    public Guid? NumberGenerateStatusAttributeId { get; set; }

    /// <summary>
    /// Loại dịch vụ
    /// </summary>
    public Guid? ServiceTypeAttributeId { get; set; }

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
    public int? IsIpdPatient { get; set; }

    public int? IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<Category10daySurgeryPackage> Category10daySurgeryPackages { get; set; } = new List<Category10daySurgeryPackage>();

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryGroupServiceLevel2> CategoryGroupServiceLevel2s { get; set; } = new List<CategoryGroupServiceLevel2>();

    public virtual ICollection<CategoryGroupServiceLevel3> CategoryGroupServiceLevel3s { get; set; } = new List<CategoryGroupServiceLevel3>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServices { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServices { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryPlaceOfSamplingSpecimen> CategoryPlaceOfSamplingSpecimen { get; set; } = new List<CategoryPlaceOfSamplingSpecimen>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRetailSurplu> CategoryRetailSurplus { get; set; } = new List<CategoryRetailSurplu>();

    public virtual ICollection<CategorySettingBedChoose> CategorySettingBedChooses { get; set; } = new List<CategorySettingBedChoose>();

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual ICollection<GroupServiceLevel1ServiceUnCompleteStatus> GroupServiceLevel1ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel1ServiceUnCompleteStatus>();

    public virtual ICollection<HistoryPartnerGroupService> HistoryPartnerGroupServices { get; set; } = new List<HistoryPartnerGroupService>();

    public virtual CategoryAttribute? NumberGenerateStatusAttribute { get; set; }

    public virtual ICollection<PartnerGroupService> PartnerGroupServices { get; set; } = new List<PartnerGroupService>();

    public virtual ICollection<ProgramGroupService> ProgramGroupServices { get; set; } = new List<ProgramGroupService>();

    public virtual CategoryAttribute? ServiceCompleteStatusAttribute { get; set; }

    public virtual CategoryAttribute? ServiceTypeAttribute { get; set; }
}
