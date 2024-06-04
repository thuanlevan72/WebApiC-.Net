using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục xét nghiệm
/// </summary>
public partial class CategoryLaboratoryService
{
    public Guid LaboratoryServiceId { get; set; }

    /// <summary>
    /// mã dịch vụ xét nghiệm
    /// </summary>
    public string LaboratoryServiceCode { get; set; } = null!;

    /// <summary>
    /// tên dịch vụ xét nghiệm
    /// </summary>
    public string LaboratoryServiceName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// giá không bảo hiểm
    /// </summary>
    public double? PriceNonInsurance { get; set; }

    /// <summary>
    /// giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// phụ thu
    /// </summary>
    public double? Surcharge { get; set; }

    /// <summary>
    /// Tỷ lệ BH thanh toán
    /// </summary>
    public double? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// Tỷ lệ thanh toán DV
    /// </summary>
    public double? PaymentServiceRatio { get; set; }

    public int? ResultType { get; set; }

    public string? ResultReference { get; set; }

    /// <summary>
    /// chuyên khoa
    /// </summary>
    public Guid? SpecialistId { get; set; }

    /// <summary>
    /// báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

    /// <summary>
    /// chỉ số nữ thấp
    /// </summary>
    public string? LowFemaleIndex { get; set; }

    /// <summary>
    /// chỉ số nữ cao
    /// </summary>
    public string? HightFemaleIndex { get; set; }

    /// <summary>
    /// chỉ số nam thấp
    /// </summary>
    public string? LowMaleIndex { get; set; }

    /// <summary>
    /// chỉ số  nam cao
    /// </summary>
    public string? HightMaleIndex { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 2
    /// </summary>
    public Guid GroupServiceLvl2 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 3
    /// </summary>
    public Guid? GroupServiceLvl3 { get; set; }

    /// <summary>
    /// Phân loại PTTT
    /// </summary>
    public Guid? SurgicalClassificationId { get; set; }

    /// <summary>
    /// đơn vj tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// Số ngày cảnh báo kê dịch vụ BHYT
    /// </summary>
    public int? InsuranceWarningNumberDay { get; set; }

    /// <summary>
    /// Số ngày cảnh báo HSD
    /// </summary>
    public int? ExpiredWarningNumberDay { get; set; }

    /// <summary>
    /// Giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// mã quyết định
    /// </summary>
    public string? DecisionCode { get; set; }

    /// <summary>
    /// ngày quyết định
    /// </summary>
    public DateTime DecisionDate { get; set; }

    public Guid? TechServiceTranferUnitMedicalId { get; set; }

    /// <summary>
    /// CSKCB thực hiện CLS
    /// </summary>
    public Guid? ClsImplementUnitMedicalId { get; set; }

    /// <summary>
    /// mã lis
    /// </summary>
    public string? LisCode { get; set; }

    /// <summary>
    /// đợn vị kết nối
    /// </summary>
    public Guid? UnitConnectId { get; set; }

    /// <summary>
    /// Thứ tự hiển thị
    /// </summary>
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public string? UnitName { get; set; }

    public int IsSlowResult { get; set; }

    public int IsRequestSpecimens { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int IsNoCharge { get; set; }

    /// <summary>
    /// Hạn chế khoa chỉ định
    /// </summary>
    public int IsRetrictDepartment { get; set; }

    /// <summary>
    /// Thanh toán sau
    /// </summary>
    public int IsLaterPay { get; set; }

    /// <summary>
    /// Dùng cho Covid
    /// </summary>
    public int IsUseCovid { get; set; }

    /// <summary>
    /// DV theo yêu cầu
    /// </summary>
    public int IsRequestService { get; set; }

    public int IsSplitDuplicateService { get; set; }

    /// <summary>
    /// Thu ngoài
    /// </summary>
    public int IsExternalPay { get; set; }

    /// <summary>
    /// Hiển thị lên KIOSK
    /// </summary>
    public int IsKiosk { get; set; }

    /// <summary>
    /// Tách số lượng khi kê
    /// </summary>
    public int IsListQtySplit { get; set; }

    /// <summary>
    /// Cho sửa đổi DV
    /// </summary>
    public int IsEditService { get; set; }

    public int IsUpTtba { get; set; }

    public int IsTt35 { get; set; }

    public int IsCreateIndex { get; set; }

    /// <summary>
    /// Không được thực hiện SL nhiều cùng lúc
    /// </summary>
    public int IsNotImplemnetQtyMutil { get; set; }

    public int IsEcrcl { get; set; }

    public int IsEgfr { get; set; }

    public DateOnly CreatedAt { get; set; }

    public DateOnly UpdatedAt { get; set; }

    public DateOnly? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid ConceptId { get; set; }

    public int? IsActive { get; set; }

    /// <summary>
    /// sst thông tư 37
    /// </summary>
    public int? NumberTt37 { get; set; }

    /// <summary>
    /// mã giá liên thông bảo hiểm y tế
    /// </summary>
    public string? HealthInsurancePriceCode { get; set; }

    public int? IsInsurance { get; set; }

    public string? CodePrint { get; set; }

    public string? Note { get; set; }

    public int? IsRequestConsultation { get; set; }

    public Guid? FormId { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản gia vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

    /// <summary>
    /// tài khoản vật tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    /// <summary>
    /// tài khoản chi ohi nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài koan do dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryHospital? ClsImplementUnitMedical { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryAttribute? Form { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLvl2Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual ICollection<LaboratoryAttribute> LaboratoryAttributes { get; set; } = new List<LaboratoryAttribute>();

    public virtual ICollection<LaboratoryResultTemplateLaboratoryService> LaboratoryResultTemplateLaboratoryServices { get; set; } = new List<LaboratoryResultTemplateLaboratoryService>();

    public virtual ICollection<LaboratoryServiceOtherSourcePay> LaboratoryServiceOtherSourcePays { get; set; } = new List<LaboratoryServiceOtherSourcePay>();

    public virtual ICollection<LaboratoryServiceServiceList> LaboratoryServiceServiceLists { get; set; } = new List<LaboratoryServiceServiceList>();

    public virtual ICollection<LaboratoryServiceTabAccompanyingService> LaboratoryServiceTabAccompanyingServices { get; set; } = new List<LaboratoryServiceTabAccompanyingService>();

    public virtual ICollection<LaboratoryServiceTabChildIndex> LaboratoryServiceTabChildIndices { get; set; } = new List<LaboratoryServiceTabChildIndex>();

    public virtual ICollection<LaboratoryServiceTabCostGroup> LaboratoryServiceTabCostGroups { get; set; } = new List<LaboratoryServiceTabCostGroup>();

    public virtual ICollection<LaboratoryServiceTabHistoryChanged> LaboratoryServiceTabHistoryChangeds { get; set; } = new List<LaboratoryServiceTabHistoryChanged>();

    public virtual ICollection<LaboratoryServiceTabImplementationRoom> LaboratoryServiceTabImplementationRooms { get; set; } = new List<LaboratoryServiceTabImplementationRoom>();

    public virtual ICollection<LaboratoryServiceTabInsurancePaymentConditon> LaboratoryServiceTabInsurancePaymentConditons { get; set; } = new List<LaboratoryServiceTabInsurancePaymentConditon>();

    public virtual ICollection<LaboratoryServiceTabPriceOption> LaboratoryServiceTabPriceOptions { get; set; } = new List<LaboratoryServiceTabPriceOption>();

    public virtual CategoryReport? Report { get; set; }

    public virtual ICollection<ReportDrugInteractionLaboratoryService> ReportDrugInteractionLaboratoryServices { get; set; } = new List<ReportDrugInteractionLaboratoryService>();

    public virtual CategorySpecialist? Specialist { get; set; }

    public virtual CategoryAttribute? SurgicalClassification { get; set; }

    public virtual CategoryHospital? TechServiceTranferUnitMedical { get; set; }

    public virtual ICollection<TestingProcedureLaboratory> TestingProcedureLaboratories { get; set; } = new List<TestingProcedureLaboratory>();

    public virtual CategoryUnit? Unit { get; set; }

    public virtual CategoryAttribute? UnitConnect { get; set; }
}
