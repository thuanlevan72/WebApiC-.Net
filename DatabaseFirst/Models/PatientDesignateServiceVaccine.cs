using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ vaccine
/// </summary>
public partial class PatientDesignateServiceVaccine
{
    public Guid PatientDesignateVaccineId { get; set; }

    public Guid WarehourseId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// liều dùng
    /// </summary>
    public Guid? DosageId { get; set; }

    /// <summary>
    /// cách sử dụng
    /// </summary>
    public string Used { get; set; } = null!;

    /// <summary>
    /// số lượng
    /// </summary>
    public int Qty { get; set; }

    /// <summary>
    /// kiểu vaccine
    /// </summary>
    public int VaccineType { get; set; }

    /// <summary>
    /// số lượng phát
    /// </summary>
    public int QtyPrimary { get; set; }

    /// <summary>
    /// ngày chỉ định
    /// </summary>
    public DateTime DesignateServiceDate { get; set; }

    /// <summary>
    /// ngày thực hiện
    /// </summary>
    public DateTime? ImplementDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    public Guid? PatientId { get; set; }

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual CategoryAccount CreatedByNavigation { get; set; } = null!;

    public virtual CategoryDosage? Dosage { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryWarehouse Warehourse { get; set; } = null!;
}
