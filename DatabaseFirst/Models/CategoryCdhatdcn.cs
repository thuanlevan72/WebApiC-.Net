using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chuẩn đoán hình ảnh  - thăm dò chức năng
/// </summary>
public partial class CategoryCdhatdcn
{
    public Guid CdhaTdcnId { get; set; }

    /// <summary>
    /// mã cdha tdcn
    /// </summary>
    public string CdhaTdcnCode { get; set; } = null!;

    /// <summary>
    /// tên cdha tdcn
    /// </summary>
    public string CdhaTdcnName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// từ viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// giá không BH
    /// </summary>
    public double PriceNonInsurance { get; set; }

    /// <summary>
    /// giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// phụ thu
    /// </summary>
    public double Surcharge { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán bảo hiểm
    /// </summary>
    public double? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán dịch vụ
    /// </summary>
    public double? ServicePaymentRatio { get; set; }

    /// <summary>
    /// Chuyên khoa
    /// </summary>
    public Guid? SpecialistId { get; set; }

    /// <summary>
    /// Tên báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 1
    /// </summary>
    public Guid GroupServiceLvl1Id { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 2
    /// </summary>
    public Guid GroupServiceLvl2Id { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 3
    /// </summary>
    public Guid? GroupServiceLvl3Id { get; set; }

    /// <summary>
    /// Phân loại PTTT
    /// </summary>
    public Guid? ClassificationSurgeryAttributeId { get; set; }

    /// <summary>
    /// ĐVT
    /// </summary>
    public Guid? UnitCalId { get; set; }

    /// <summary>
    /// Số ngày cảnh báo kê dịch vụ BHYT
    /// </summary>
    public int? InsuranceWarningNumber { get; set; }

    /// <summary>
    /// Số ngày cảnh báo HSD
    /// </summary>
    public int? ExpiredWarningDay { get; set; }

    /// <summary>
    /// Giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// Tiếp đón CLS
    /// </summary>
    public int? IsCls { get; set; }

    /// <summary>
    /// Mã số quyết định
    /// </summary>
    public string? DecisionCode { get; set; }

    /// <summary>
    /// Ngày quyết định
    /// </summary>
    public DateTime? DecisionDate { get; set; }

    /// <summary>
    /// CSKCB chuyển giao DVKT
    /// </summary>
    public Guid? TechServiceTranferUnitMedicalId { get; set; }

    /// <summary>
    /// CSKCB thực hiện CLS
    /// </summary>
    public Guid? ClsImplementUnitMedicalId { get; set; }

    /// <summary>
    /// Mã gửi LIS/PACS
    /// </summary>
    public string? LisSendCode { get; set; }

    /// <summary>
    /// Đơn vị kết nối
    /// </summary>
    public Guid? UnitConnectAttributeId { get; set; }

    /// <summary>
    /// Thứ tự hiển thị
    /// </summary>
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Đơn vị
    /// </summary>
    public string? UnitId { get; set; }

    /// <summary>
    /// DV có kết quả lâu
    /// </summary>
    public int? IsSkipResult { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    /// <summary>
    /// Hạn chế khoa chỉ định
    /// </summary>
    public int? IsRetrictDepartment { get; set; }

    public int IsActive { get; set; }

    /// <summary>
    /// Thanh toán sau
    /// </summary>
    public int? IsLaterPayment { get; set; }

    /// <summary>
    /// Dùng cho Covid
    /// </summary>
    public int? IsUseCovid { get; set; }

    /// <summary>
    /// DV theo yêu cầu
    /// </summary>
    public int? IsRequestService { get; set; }

    /// <summary>
    /// Tách phiếu chỉ định khi trùng DV
    /// </summary>
    public int? IsSplitVoteDupplicate { get; set; }

    /// <summary>
    /// Đặt khám online
    /// </summary>
    public int? IsBookOnline { get; set; }

    /// <summary>
    /// Thu ngoài
    /// </summary>
    public int? IsExternalPayment { get; set; }

    /// <summary>
    /// Hiển thị lên KIOSK
    /// </summary>
    public int? IsShowKiosk { get; set; }

    /// <summary>
    /// Tách số lượng khi kê
    /// </summary>
    public int? IsSplitQuantityList { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// Cho sửa đổi DV
    /// </summary>
    public int? IsEditService { get; set; }

    /// <summary>
    /// Lên TTBA
    /// </summary>
    public int? IsMedicalRecord { get; set; }

    /// <summary>
    /// Áp dụng TT35
    /// </summary>
    public int? IsTt35 { get; set; }

    /// <summary>
    /// Không được thực hiện SL nhiều cùng lúc
    /// </summary>
    public int? IsNotImplementQtyMultil { get; set; }

    public Guid? ConceptId { get; set; }

    public int? NumberTt37 { get; set; }

    public string? CodePrint { get; set; }

    public string? HealthInsurancePriceCode { get; set; }

    public int? IsInsurance { get; set; }

    public string? Note { get; set; }

    public int? IsRequestConsultation { get; set; }

    /// <summary>
    /// loại biểu mẫu
    /// </summary>
    public Guid? FormId { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

    /// <summary>
    /// tài khoản vật tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    /// <summary>
    /// tài khoản nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual ICollection<CdhaAttribute> CdhaAttributes { get; set; } = new List<CdhaAttribute>();

    public virtual ICollection<CdhatdcnOtherSourcePay> CdhatdcnOtherSourcePays { get; set; } = new List<CdhatdcnOtherSourcePay>();

    public virtual ICollection<CdhatdcnServiceList> CdhatdcnServiceLists { get; set; } = new List<CdhatdcnServiceList>();

    public virtual ICollection<CdhatdcnTabAccompanyingService> CdhatdcnTabAccompanyingServices { get; set; } = new List<CdhatdcnTabAccompanyingService>();

    public virtual ICollection<CdhatdcnTabCostGroup> CdhatdcnTabCostGroups { get; set; } = new List<CdhatdcnTabCostGroup>();

    public virtual ICollection<CdhatdcnTabHistoryChanged> CdhatdcnTabHistoryChangeds { get; set; } = new List<CdhatdcnTabHistoryChanged>();

    public virtual ICollection<CdhatdcnTabImplementationRoom> CdhatdcnTabImplementationRooms { get; set; } = new List<CdhatdcnTabImplementationRoom>();

    public virtual ICollection<CdhatdcnTabInsurancePaymentCondition> CdhatdcnTabInsurancePaymentConditions { get; set; } = new List<CdhatdcnTabInsurancePaymentCondition>();

    public virtual ICollection<CdhatdcnTabPriceOption> CdhatdcnTabPriceOptions { get; set; } = new List<CdhatdcnTabPriceOption>();

    public virtual ICollection<CdhatdcnresultTemplateCdhatdcnservice> CdhatdcnresultTemplateCdhatdcnservices { get; set; } = new List<CdhatdcnresultTemplateCdhatdcnservice>();

    public virtual CategoryAttribute? ClassificationSurgeryAttribute { get; set; }

    public virtual CategoryAttribute? ClsImplementUnitMedical { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryAttribute? Form { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1 { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLvl2 { get; set; } = null!;

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3 { get; set; }

    public virtual CategoryReport? Report { get; set; }

    public virtual CategorySpecialist? Specialist { get; set; }

    public virtual CategoryAttribute? TechServiceTranferUnitMedical { get; set; }

    public virtual CategoryUnit? UnitCal { get; set; }

    public virtual CategoryAttribute? UnitConnectAttribute { get; set; }
}
