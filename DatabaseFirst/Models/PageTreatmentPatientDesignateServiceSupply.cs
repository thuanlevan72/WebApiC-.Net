using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tờ điều trị - Chỉ định vât tư
/// </summary>
public partial class PageTreatmentPatientDesignateServiceSupply
{
    public Guid PageTreatmentPatientDesignateServiceSuppliesId { get; set; }

    public Guid? PageTreatmentMedicalRecordId { get; set; }

    public Guid PatientDesignateServiceSuppliesId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual PageTreatmentMedicalRecord? PageTreatmentMedicalRecord { get; set; }

    public virtual PatientDesignateServiceSupply PatientDesignateServiceSupplies { get; set; } = null!;
}
