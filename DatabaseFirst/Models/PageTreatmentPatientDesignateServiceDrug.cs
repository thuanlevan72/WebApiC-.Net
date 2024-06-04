using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ điều trị - Chỉ định thuốc
/// </summary>
public partial class PageTreatmentPatientDesignateServiceDrug
{
    public Guid PageTreatmentPatientDesignateServiceDrugId { get; set; }

    public Guid? PageTreatmentMedicalRecordId { get; set; }

    public Guid PatientDesignateServiceDrugId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual PageTreatmentMedicalRecord? PageTreatmentMedicalRecord { get; set; }

    public virtual PatientDesignateServiceDrug PatientDesignateServiceDrug { get; set; } = null!;
}
