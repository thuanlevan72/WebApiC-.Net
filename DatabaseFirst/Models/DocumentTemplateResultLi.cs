using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu Kết quả phiếu in
/// </summary>
public partial class DocumentTemplateResultLi
{
    public Guid DocumentTemplateResultLisId { get; set; }

    public string Data { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? PatientReceptionId { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    /// <summary>
    /// 1. ngoại trú 2 nội trú
    /// </summary>
    public int? IsIpd { get; set; }

    public string? Pdf { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual CategoryPatientReception? PatientReception { get; set; }
}
