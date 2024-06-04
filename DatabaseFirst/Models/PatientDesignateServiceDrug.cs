using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ thuốc
/// </summary>
public partial class PatientDesignateServiceDrug
{
    public Guid PatientDesignateMedicalServiceId { get; set; }

    /// <summary>
    /// kho
    /// </summary>
    public Guid? WarehourseId { get; set; }

    /// <summary>
    /// thuốc
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// liều dùng
    /// </summary>
    public Guid? DosageId { get; set; }

    /// <summary>
    /// cách dùng
    /// </summary>
    public string? Used { get; set; }

    /// <summary>
    /// thời điểm dùng
    /// </summary>
    public string? TimeOfUse { get; set; }

    /// <summary>
    /// lần/ngày
    /// </summary>
    public int? TimePerDay { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int? Qty { get; set; }

    /// <summary>
    /// Số lượng/ lần
    /// </summary>
    public int? QtyPerTime { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// số lượng hủy
    /// </summary>
    public int? QtyCancel { get; set; }

    /// <summary>
    /// lý do hủy
    /// </summary>
    public string? CancelOfReason { get; set; }

    public Guid? RouterId { get; set; }

    public int? IsActive { get; set; }

    public Guid? ParentId { get; set; }

    /// <summary>
    /// phân loại thuốc thuốc kê ngoài, thuốc tủ trực nhà thuốc
    /// </summary>
    public int? DrugType { get; set; }

    /// <summary>
    /// số lượng phát
    /// </summary>
    public int? QtyPrimary { get; set; }

    public int? DayNumber { get; set; }

    /// <summary>
    /// giờ bắt đầu
    /// </summary>
    public string? StartTime { get; set; }

    /// <summary>
    /// tốc đọ truyền
    /// </summary>
    public int? TranferRate { get; set; }

    /// <summary>
    /// đơn vị truyền 1: giọt/phut 2 ml/h
    /// </summary>
    public int? UnitTranferRate { get; set; }

    /// <summary>
    /// số giọt/ml
    /// </summary>
    public int? NumberOfDrop { get; set; }

    /// <summary>
    /// cách giờ
    /// </summary>
    public int? TimeAway { get; set; }

    /// <summary>
    /// thời gian dùng từ ngày
    /// </summary>
    public DateTime? TimeUseFrom { get; set; }

    /// <summary>
    /// thời gian dùng đến ngày
    /// </summary>
    public DateTime? TimeUseTo { get; set; }

    /// <summary>
    /// đợt dùng
    /// </summary>
    public string? Use { get; set; }

    /// <summary>
    /// ngày sử dụng thuốc
    /// </summary>
    public int? DrugUseDay { get; set; }

    /// <summary>
    /// sl sáng
    /// </summary>
    public int? QtyMorning { get; set; }

    /// <summary>
    /// sl trưa
    /// </summary>
    public int? QtyAfternoon { get; set; }

    /// <summary>
    /// sl chiều
    /// </summary>
    public int? QtyEvening { get; set; }

    /// <summary>
    /// sl tối
    /// </summary>
    public int? QtyNight { get; set; }

    /// <summary>
    /// thời gian chỉ đinh
    /// </summary>
    public DateTime? DesignateServiceDate { get; set; }

    /// <summary>
    /// thời gian thực hiện
    /// </summary>
    public DateTime? ImplementDate { get; set; }

    public int? IsCharge { get; set; }

    public int? IsPay { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public string? ReceiptSlipCode { get; set; }

    public int? IsType { get; set; }

    /// <summary>
    /// 0: ngoại trú 1  nội trú
    /// </summary>
    public int? IsIpd { get; set; }

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlips { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryDosage? Dosage { get; set; }

    public virtual ICollection<InfomationDrugSupply> InfomationDrugSupplies { get; set; } = new List<InfomationDrugSupply>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceDrug> PageTreatmentPatientDesignateServiceDrugs { get; set; } = new List<PageTreatmentPatientDesignateServiceDrug>();

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryRoute? Router { get; set; }

    public virtual CategoryWarehouse? Warehourse { get; set; }
}
