using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu lĩnh 
/// </summary>
public partial class CategoryReceipt
{
    public Guid ReceiptId { get; set; }

    /// <summary>
    /// loại hàng hóa
    /// </summary>
    public Guid ConceptId { get; set; }

    /// <summary>
    /// loại lĩnh 1: lĩnh nội trú 2 lĩnh tủ trực
    /// </summary>
    public int ReceiptType { get; set; }

    /// <summary>
    /// từ kho
    /// </summary>
    public Guid? WarehouseFrom { get; set; }

    /// <summary>
    /// đến kho
    /// </summary>
    public Guid WarehouseTo { get; set; }

    /// <summary>
    /// Khoa chỉ định
    /// </summary>
    public Guid DepartmentId { get; set; }

    public Guid? RoomId { get; set; }

    /// <summary>
    /// mã bệnh án
    /// </summary>
    public Guid? SetupMedicalRecordId { get; set; }

    /// <summary>
    /// buồng phẫu thuật chọn loại phòng= loại giường
    /// </summary>
    public Guid? RoomSugeryId { get; set; }

    /// <summary>
    /// phân loại thuốc
    /// </summary>
    public Guid? DrugClassificationId { get; set; }

    /// <summary>
    /// tên thuốc
    /// </summary>
    public Guid? DrugId { get; set; }

    /// <summary>
    /// duyệt
    /// </summary>
    public int? IsApprove { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ReceiptCode { get; set; }
}
