using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ địnhThông tin đơn thuốc
/// </summary>
public partial class DesignateServicePrescription
{
    public Guid DesignateServicePrescriptionId { get; set; }

    public Guid? BasicInformatonPatientId { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// lời dặn
    /// </summary>
    public Guid? AdviceId { get; set; }

    public int? NumberOfDay { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IsType { get; set; }

    /// <summary>
    /// lời dặn
    /// </summary>
    public string? Advice { get; set; }

    public int? Batch { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public virtual CategoryAdvice? AdviceNavigation { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformatonPatient { get; set; }

    public virtual ICollection<DesignateServicePrescriptionExamine> DesignateServicePrescriptionExamines { get; set; } = new List<DesignateServicePrescriptionExamine>();

    public virtual ICollection<DesignateServicePrescriptionIpd> DesignateServicePrescriptionIpds { get; set; } = new List<DesignateServicePrescriptionIpd>();

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();
}
