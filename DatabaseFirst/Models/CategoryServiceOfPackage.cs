using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ trong gói
/// </summary>
public partial class CategoryServiceOfPackage
{
    public Guid ServiceOfPackageId { get; set; }

    public int Qty { get; set; }

    public int QtyDefault { get; set; }

    public decimal Price { get; set; }

    public Guid RoomId { get; set; }

    public Guid? DosageId { get; set; }

    public int? IsNoCharge { get; set; }

    public int? IsPay { get; set; }

    public int IsExemptions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? PackageServiceId { get; set; }

    /// <summary>
    /// 1
    /// </summary>
    public int? IsActive { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    public virtual CategoryDosage? Dosage { get; set; }

    public virtual CategoryPackageService? PackageService { get; set; }

    public virtual ICollection<PackageServiceServiceOfPackage> PackageServiceServiceOfPackages { get; set; } = new List<PackageServiceServiceOfPackage>();

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual CategoryProduct? Product { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;
}
