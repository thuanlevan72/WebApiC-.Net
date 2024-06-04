using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin đơn thuốc khám bệnh
/// </summary>
public partial class DesignateServicePrescriptionExamine
{
    public Guid PrescriptionExamineId { get; set; }

    public Guid ProductId { get; set; }

    public int Qty { get; set; }

    public Guid? AccountId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid DesignateServicePrescriptionId { get; set; }

    public Guid? WarehouseId { get; set; }

    public int? PrescriptionType { get; set; }

    public int? QtyPrimary { get; set; }

    public int? IsPay { get; set; }

    public int? IsNocharge { get; set; }

    public Guid? DosageId { get; set; }

    public string? Use { get; set; }

    public int? NumberDay { get; set; }

    public int? TimeUse { get; set; }

    public int? TimePerDay { get; set; }

    public int? QtyPerTime { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual DesignateServicePrescription DesignateServicePrescription { get; set; } = null!;

    public virtual CategoryDosage? Dosage { get; set; }

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual CategoryWarehouse? Warehouse { get; set; }
}
