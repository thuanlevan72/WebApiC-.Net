using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ chỉ định - hóa chất
/// </summary>
public partial class PageTreatmentPatientDesignateServiceChemistry
{
    public Guid PageTreatmentPatientDesignateServiceChemistryId { get; set; }

    public Guid PageTreatmentMedicalRecordId { get; set; }

    public Guid PatientDesignateServiceChemistryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual PageTreatmentMedicalRecord PageTreatmentMedicalRecord { get; set; } = null!;

    public virtual PatientDesignateServiceChemistry PatientDesignateServiceChemistry { get; set; } = null!;
}
