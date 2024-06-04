using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin gói dịch vụ
/// </summary>
public partial class CategoryPackageService
{
    public Guid PackageServiceId { get; set; }

    public string PackageCode { get; set; } = null!;

    public string PackageName { get; set; } = null!;

    public decimal? PackageTotal { get; set; }

    public int IsActive { get; set; }

    public int? IsRetrictDepartment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryServiceOfPackage> CategoryServiceOfPackages { get; set; } = new List<CategoryServiceOfPackage>();

    public virtual ICollection<PackageServiceConcept> PackageServiceConcepts { get; set; } = new List<PackageServiceConcept>();

    public virtual ICollection<PackageServiceDepartment> PackageServiceDepartments { get; set; } = new List<PackageServiceDepartment>();

    public virtual ICollection<PackageServiceServiceOfPackage> PackageServiceServiceOfPackages { get; set; } = new List<PackageServiceServiceOfPackage>();

    public virtual ICollection<PackageServiceUsedPayment> PackageServiceUsedPayments { get; set; } = new List<PackageServiceUsedPayment>();

    public virtual ICollection<PageTreamentPatientDesignateService> PageTreamentPatientDesignateServices { get; set; } = new List<PageTreamentPatientDesignateService>();

    public virtual ICollection<PatientPackageService> PatientPackageServices { get; set; } = new List<PatientPackageService>();

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();
}
