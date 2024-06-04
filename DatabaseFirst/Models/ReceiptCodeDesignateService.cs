using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu thu - dịch vụ chỉ định
/// </summary>
public partial class ReceiptCodeDesignateService
{
    public Guid ReceiptCodeDesignateServiceId { get; set; }

    public Guid? PatientReceptionId { get; set; }

    /// <summary>
    /// id phiếu thu
    /// </summary>
    public Guid ReceiptCodeId { get; set; }

    /// <summary>
    /// chỉ định dịch vụ
    /// </summary>
    public Guid? DesignateServiceId { get; set; }

    /// <summary>
    /// trạng thái 0 Mới tiếp đón 1 đang điều trị
    /// </summary>
    public int? IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid? PackageServiceId { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// chỉ định dịch vụ thuốc
    /// </summary>
    public Guid? DesignateServicePrescriptionId { get; set; }

    public Guid? PatientDesignateSuppliesServiceId { get; set; }

    public virtual CategoryPatientDesignateService? DesignateService { get; set; }

    public virtual DesignateServicePrescription? DesignateServicePrescription { get; set; }

    public virtual CategoryPackageService? PackageService { get; set; }

    public virtual PatientDesignateServiceSupply? PatientDesignateSuppliesService { get; set; }

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryPatientReceiptCode ReceiptCode { get; set; } = null!;

    public virtual ICollection<ReceiptCodeDesignateServiceDiscount> ReceiptCodeDesignateServiceDiscounts { get; set; } = new List<ReceiptCodeDesignateServiceDiscount>();
}
