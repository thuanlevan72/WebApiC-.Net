using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục dịch vụ trong bộ
/// </summary>
public partial class CategoryDesignationKitService
{
    public Guid DesignationKitServiceId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// phòng chỉ định
    /// </summary>
    public Guid RoomId { get; set; }

    /// <summary>
    /// chuẩn đoán
    /// </summary>
    public Guid DosageId { get; set; }

    public int IsNoCharge { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    /// <summary>
    /// tự trả
    /// </summary>
    public int? PayMoney { get; set; }

    public Guid? ProductId { get; set; }

    public virtual ICollection<DesignationKitDesignationKitServiceDetail> DesignationKitDesignationKitServiceDetails { get; set; } = new List<DesignationKitDesignationKitServiceDetail>();

    public virtual ICollection<DesignationKitDesignationKitService> DesignationKitDesignationKitServices { get; set; } = new List<DesignationKitDesignationKitService>();

    public virtual ICollection<DesignationKitServiceWarehouse> DesignationKitServiceWarehouses { get; set; } = new List<DesignationKitServiceWarehouse>();

    public virtual CategoryDosage Dosage { get; set; } = null!;

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;
}
