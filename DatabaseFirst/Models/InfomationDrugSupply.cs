using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin đơn thuốc
/// </summary>
public partial class InfomationDrugSupply
{
    public Guid InfomationDrugId { get; set; }

    /// <summary>
    /// chỉ đinh thuốc
    /// </summary>
    public Guid? PatientDesignateServiceDrugId { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// trạng thái 0 tạo mới,2  đã duyệt, 3 đã phát(hoàn thành)
    /// </summary>
    public int IsStatus { get; set; }

    /// <summary>
    /// ngày tạo
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// ngày phát
    /// </summary>
    public DateTime? FinishedDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? PatientDesignateSuppliesServiceId { get; set; }

    public decimal? TotalPrice { get; set; }

    /// <summary>
    /// ngày duyệt
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    public string? Reason { get; set; }

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual PatientDesignateServiceDrug? PatientDesignateServiceDrug { get; set; }

    public virtual PatientDesignateServiceSupply? PatientDesignateSuppliesService { get; set; }
}
