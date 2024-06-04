using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục ngoài điều trị
/// </summary>
public partial class CategoryOutsiteOfTreatmentService
{
    public Guid OutsiteOfTreatmentServiceId { get; set; }

    /// <summary>
    /// mã dịch vụ ngoài điều trị
    /// </summary>
    public string OutsiteOfTreatmentServiceCode { get; set; } = null!;

    /// <summary>
    /// Tên ngoài điều trị
    /// </summary>
    public string OutsiteOfTreatmentServiceName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string EquivalentCode { get; set; } = null!;

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string EquivalentName { get; set; } = null!;

    /// <summary>
    /// giá không bảo hiểm
    /// </summary>
    public decimal PriceNonInsurance { get; set; }

    /// <summary>
    /// giá bảo hiểm
    /// </summary>
    public decimal? PriceInsurance { get; set; }

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string Abbreviations { get; set; } = null!;

    /// <summary>
    /// phụ thu
    /// </summary>
    public decimal? Surcharge { get; set; }

    /// <summary>
    /// Tỷ lệ BH thanh toán
    /// </summary>
    public int? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// Tỷ lệ thanh toán DV
    /// </summary>
    public int PaymentServiceRatio { get; set; }

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
    public int ExpiredWarningNumberDay { get; set; }

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

    public Guid? GasTypeId { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int IsNoCharge { get; set; }

    /// <summary>
    /// Hạn chế khoa chỉ định
    /// </summary>
    public int IsRetrictDepartment { get; set; }

    /// <summary>
    /// DV theo yêu cầu
    /// </summary>
    public int IsRequestService { get; set; }

    /// <summary>
    /// Hiển thị lên KIOSK
    /// </summary>
    public int IsKiosk { get; set; }

    public int IsECrCl { get; set; }

    public int IsEGfr { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int IsExternalPayment { get; set; }

    public virtual CategoryHospital? ClsImplementUnitMedical { get; set; }

    public virtual CategoryAttribute? GasType { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLvl2Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual ICollection<OutsiteOfTreatmentServiceImplementationRoom> OutsiteOfTreatmentServiceImplementationRooms { get; set; } = new List<OutsiteOfTreatmentServiceImplementationRoom>();

    public virtual ICollection<OutsiteOfTreatmentServiceInsurancePaymentCondition> OutsiteOfTreatmentServiceInsurancePaymentConditions { get; set; } = new List<OutsiteOfTreatmentServiceInsurancePaymentCondition>();

    public virtual ICollection<OutsiteOfTreatmentServiceOtherSourcePay> OutsiteOfTreatmentServiceOtherSourcePays { get; set; } = new List<OutsiteOfTreatmentServiceOtherSourcePay>();

    public virtual ICollection<OutsiteOfTreatmentServiceServiceList> OutsiteOfTreatmentServiceServiceLists { get; set; } = new List<OutsiteOfTreatmentServiceServiceList>();

    public virtual ICollection<OutsiteOfTreatmentServiceTabCostGroup> OutsiteOfTreatmentServiceTabCostGroups { get; set; } = new List<OutsiteOfTreatmentServiceTabCostGroup>();

    public virtual ICollection<OutsiteOfTreatmentServiceTabOptionPrice> OutsiteOfTreatmentServiceTabOptionPrices { get; set; } = new List<OutsiteOfTreatmentServiceTabOptionPrice>();

    public virtual CategoryHospital? TechServiceTranferUnitMedical { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
