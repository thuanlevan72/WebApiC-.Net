using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ điều trị  - suất ăn
/// </summary>
public partial class PageTreatmentPatientDesignateServiceDinner
{
    public Guid PageTreatmentPatientDesignateServiceDinnerId { get; set; }

    public Guid PageTreatmentMedicalRecordId { get; set; }

    public Guid PatientDesignateServiceDinnerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual PageTreatmentMedicalRecord PageTreatmentMedicalRecord { get; set; } = null!;

    public virtual PatientDesignateServiceDinner PatientDesignateServiceDinner { get; set; } = null!;
}
