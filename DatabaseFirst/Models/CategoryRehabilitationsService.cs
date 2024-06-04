using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phục hồi chức năng
/// </summary>
public partial class CategoryRehabilitationsService
{
    public Guid RehabilitationServiceId { get; set; }

    /// <summary>
    /// mã dịch vụ phục hồi chức năng
    /// </summary>
    public string RehabilitationServiceCode { get; set; } = null!;

    /// <summary>
    /// tên dịch vụ phục hồi chức năng
    /// </summary>
    public string RehabilitationServiceName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// giá không bảo hiểm
    /// </summary>
    public double PriceNonInsurance { get; set; }

    /// <summary>
    /// giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

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
    public double PaymentServiceRatio { get; set; }

    /// <summary>
    /// Tên báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

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
    /// CSKCB chuyển giao DVKT
    /// </summary>
    public Guid? TechServiceTranferUnitMedicalId { get; set; }

    /// <summary>
    /// CSKCB thực hiện CLS
    /// </summary>
    public Guid? ClsImplementUnitMedicalId { get; set; }

    /// <summary>
    /// mã số quyết định
    /// </summary>
    public string? DecisionCode { get; set; }

    /// <summary>
    /// ngày quyết định
    /// </summary>
    public DateTime? DecisionDate { get; set; }

    /// <summary>
    /// đơn vị kết nối
    /// </summary>
    public Guid? UnitConnectId { get; set; }

    /// <summary>
    /// phân tuyến PTTT
    /// </summary>
    public Guid? SurgicalProceduresDivisionId { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    /// <summary>
    /// Hạn chế khoa chỉ định
    /// </summary>
    public int? IsRetrictDepartment { get; set; }

    /// <summary>
    /// Thanh toán sau
    /// </summary>
    public int? IsLaterPay { get; set; }

    /// <summary>
    /// Dùng cho Covid
    /// </summary>
    public int? IsUseCovid { get; set; }

    /// <summary>
    /// DV theo yêu cầu
    /// </summary>
    public int? IsRequestService { get; set; }

    /// <summary>
    /// Đặt khám online
    /// </summary>
    public int? IsBookOnline { get; set; }

    /// <summary>
    /// Thu ngoài
    /// </summary>
    public int? IsExternalPay { get; set; }

    public int? IsKiosk { get; set; }

    /// <summary>
    /// Tách số lượng khi kê
    /// </summary>
    public int? IsListQtySplit { get; set; }

    /// <summary>
    /// Cho sửa đổi DV
    /// </summary>
    public int? IsEditService { get; set; }

    /// <summary>
    /// Không được thực hiện SL nhiều cùng lúc
    /// </summary>
    public int? IsNotImplemnetQtyMutil { get; set; }

    public int? IsECrCl { get; set; }

    public int? IsEGfr { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsTt35 { get; set; }

    public int? IsSplitVoteIndicationDupplicate { get; set; }

    public Guid? ConceptId { get; set; }

    public Guid? SpecialistId { get; set; }

    public int? NumberTt37 { get; set; }

    public string? HealthInsurancePriceCode { get; set; }

    public int? IsInsurance { get; set; }

    public string? CodePrint { get; set; }

    public string? Note { get; set; }

    public int? IsRequestConsultation { get; set; }

    public Guid? ClassificationRehabilitationServiceId { get; set; }

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
    /// tài khoản vât tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    /// <summary>
    /// tài khoản chi phí nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryAttribute? ClassificationRehabilitationService { get; set; }

    public virtual CategoryHospital? ClsImplementUnitMedical { get; set; }

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryAttribute? Form { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLvl2Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual ICollection<RehabilitationOtherSourcePay> RehabilitationOtherSourcePays { get; set; } = new List<RehabilitationOtherSourcePay>();

    public virtual ICollection<RehabilitationServiceServiceList> RehabilitationServiceServiceLists { get; set; } = new List<RehabilitationServiceServiceList>();

    public virtual ICollection<RehabilitationServiceTabCostGroup> RehabilitationServiceTabCostGroups { get; set; } = new List<RehabilitationServiceTabCostGroup>();

    public virtual ICollection<RehabilitationServiceTabImplementationRoom> RehabilitationServiceTabImplementationRooms { get; set; } = new List<RehabilitationServiceTabImplementationRoom>();

    public virtual ICollection<RehabilitationServiceTabInsurancePaymentConditon> RehabilitationServiceTabInsurancePaymentConditons { get; set; } = new List<RehabilitationServiceTabInsurancePaymentConditon>();

    public virtual ICollection<RehabilitationsServiceTabPriceOption> RehabilitationsServiceTabPriceOptions { get; set; } = new List<RehabilitationsServiceTabPriceOption>();

    public virtual ICollection<RehabilitationsServicesTabHistoryChanged> RehabilitationsServicesTabHistoryChangeds { get; set; } = new List<RehabilitationsServicesTabHistoryChanged>();

    public virtual CategoryReport? Report { get; set; }

    public virtual CategorySpecialist? Specialist { get; set; }

    public virtual CategoryAttribute? SurgicalProceduresDivision { get; set; }

    public virtual CategoryHospital? TechServiceTranferUnitMedical { get; set; }

    public virtual CategoryUnit? Unit { get; set; }

    public virtual CategoryAttribute? UnitConnect { get; set; }
}
