using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu Kết quả phiếu in
/// </summary>
public partial class DocumentTemplateResult
{
    public Guid DocumentTemplateResultId { get; set; }

    public string Data { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? ReportType { get; set; }

    public Guid? ReportTypeId { get; set; }

    public int? DrugType { get; set; }

    public Guid? PatientReceptionId { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    /// <summary>
    /// 1. ngoại trú 2 nội trú
    /// </summary>
    public int? IsIpd { get; set; }

    public string? NumberReceiptCode { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual ICollection<ConferenceMinutesHistory> ConferenceMinutesHistories { get; set; } = new List<ConferenceMinutesHistory>();

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual ICollection<DocumentTemplateResultMedical> DocumentTemplateResultMedicals { get; set; } = new List<DocumentTemplateResultMedical>();

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryAttribute? ReportTypeNavigation { get; set; }
}
