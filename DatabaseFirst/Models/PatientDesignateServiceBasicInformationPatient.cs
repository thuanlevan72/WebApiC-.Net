using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dịch vụ thông tin cơ bản
/// </summary>
public partial class PatientDesignateServiceBasicInformationPatient
{
    public Guid PatientDesignateBasicPatientId { get; set; }

    public Guid BasicInformationPatientId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public virtual CategoryBasicInformationPatient BasicInformationPatient { get; set; } = null!;

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
