using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ vật tư
/// </summary>
public partial class PatientDesignateServiceSupply
{
    public Guid PatientDesignateSuppliesServiceId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? SizeId { get; set; }

    public int? IsNoCharge { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IsPayment { get; set; }

    public char? Note { get; set; }

    public int? Qty { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// phân biệt vật tư bảo hiểm hoặc vật tư nhà thuốc
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// so luong phat
    /// </summary>
    public int? QtyPrimary { get; set; }

    public int? IsIpd { get; set; }

    /// <summary>
    /// phân biệt vật tư ở nhà thuốc, CDHA, ...
    /// </summary>
    public int? SuppliesType { get; set; }

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlips { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual ICollection<InfomationDrugSupply> InfomationDrugSupplies { get; set; } = new List<InfomationDrugSupply>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceSupply> PageTreatmentPatientDesignateServiceSupplies { get; set; } = new List<PageTreatmentPatientDesignateServiceSupply>();

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();

    public virtual CategoryAttribute? Size { get; set; }

    public virtual CategoryWarehouse? Warehouse { get; set; }
}
