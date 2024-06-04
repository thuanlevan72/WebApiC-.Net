using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ điều trị - chỉ định dịch vụ
/// </summary>
public partial class PageTreamentPatientDesignateService
{
    public Guid PageTreatmentPatientDesignateServiceId { get; set; }

    public Guid MedicalTreatmentPageTreatmentId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public Guid? PackageServiceId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual PageTreatmentMedicalRecord MedicalTreatmentPageTreatment { get; set; } = null!;

    public virtual CategoryPackageService? PackageService { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
