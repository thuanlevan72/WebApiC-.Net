using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đơn thuốc
/// </summary>
public partial class CategoryPrescriptionOrder
{
    public Guid PrescriptionOrderId { get; set; }

    /// <summary>
    /// kho bán
    /// </summary>
    public Guid? WarehouseId { get; set; }

    /// <summary>
    /// tổng tiền
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// giảm giá
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// trạng thái đơn hàng
    /// </summary>
    public int StatusOrder { get; set; }

    /// <summary>
    /// trạng thái thanh toán
    /// </summary>
    public int StatusPayment { get; set; }

    /// <summary>
    /// mã phiếu ngày hiện tại + stt theo format yyyyMMdd0000Index
    /// </summary>
    public string OrderCode { get; set; } = null!;

    /// <summary>
    /// người phát
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// trạng thái hoàn
    /// </summary>
    public int IsRefund { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// thành tiền
    /// </summary>
    public decimal? SubTotal { get; set; }

    public Guid? PatientPrescriptionId { get; set; }

    public virtual CategoryPatientPrescription? PatientPrescription { get; set; }

    public virtual CategoryWarehouse? Warehouse { get; set; }
}
