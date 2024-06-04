using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chỉ định dịch vụ hóa chất
/// </summary>
public partial class PatientDesignateServiceChemistry
{
    public Guid PatientDesignateServiceChemistryId { get; set; }

    /// <summary>
    /// chỉ định dịch vụ
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// kho
    /// </summary>
    public Guid WarehouseId { get; set; }

    /// <summary>
    /// số lượng kê
    /// </summary>
    public int Qty { get; set; }

    /// <summary>
    /// số lượng phát
    /// </summary>
    public int? QtyPrimary { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// không tính tiền
    /// </summary>
    public int IsNoCharge { get; set; }

    /// <summary>
    /// tự trả
    /// </summary>
    public int IsPayment { get; set; }

    /// <summary>
    /// thời gian thực hiện
    /// </summary>
    public DateTime TimeImplement { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public Guid? ReceiptCodeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? ParentId { get; set; }

    public int? Type { get; set; }

    public int? IsIpd { get; set; }

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceChemistry> PageTreatmentPatientDesignateServiceChemistries { get; set; } = new List<PageTreatmentPatientDesignateServiceChemistry>();

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryReceiptCode? ReceiptCode { get; set; }

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
