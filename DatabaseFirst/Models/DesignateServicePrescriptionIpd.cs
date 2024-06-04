using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Nội trú - Chi tiết dơn thuốc
/// </summary>
public partial class DesignateServicePrescriptionIpd
{
    public Guid DesignateServicePrescriptionIpdId { get; set; }

    public Guid DesignateServicePrescriptionId { get; set; }

    public Guid IpdId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual DesignateServicePrescription DesignateServicePrescription { get; set; } = null!;

    public virtual BasicInformationPatientIpd Ipd { get; set; } = null!;
}
