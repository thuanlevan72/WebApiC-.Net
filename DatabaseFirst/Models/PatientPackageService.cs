using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân -Gói dịch vụ
/// </summary>
public partial class PatientPackageService
{
    public Guid PatientPackageServiceId { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// gói dịch vụ
    /// </summary>
    public Guid PackageServiceId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IsStatus { get; set; }

    public virtual ICollection<OrderPackageServiceUsed> OrderPackageServiceUseds { get; set; } = new List<OrderPackageServiceUsed>();

    public virtual CategoryPackageService PackageService { get; set; } = null!;

    public virtual ICollection<PackageServiceUsedPayment> PackageServiceUsedPayments { get; set; } = new List<PackageServiceUsedPayment>();

    public virtual CategoryPatient Patient { get; set; } = null!;
}
