using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Người bệnh tiếp đón
/// </summary>
public partial class CategoryPatientReception
{
    public Guid PatientReceptionId { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// mã tiếp đón, mã hồ sơ
    /// </summary>
    public string ReceptionCode { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// lý do tiếp đón
    /// </summary>
    public Guid? ReasonId { get; set; }

    /// <summary>
    /// 0 là huỷ tiếp đón, 1 là tiếp đón
    /// </summary>
    public int? IsStatus { get; set; }

    /// <summary>
    /// lý do
    /// </summary>
    public string? Reason { get; set; }

    public Guid? ProgramId { get; set; }

    public int? IsCovid { get; set; }

    public int? IsPriority { get; set; }

    public int? IsEmergency { get; set; }

    public Guid? CounterId { get; set; }

    public virtual ICollection<CategoryFinsishExamine> CategoryFinsishExamines { get; set; } = new List<CategoryFinsishExamine>();

    public virtual ICollection<CategoryInjectionAppointment> CategoryInjectionAppointments { get; set; } = new List<CategoryInjectionAppointment>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServices { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBeds { get; set; } = new List<CategoryRoomBed>();

    public virtual CategoryCounter? Counter { get; set; }

    public virtual ICollection<DocumentResultPdf> DocumentResultPdfs { get; set; } = new List<DocumentResultPdf>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual ICollection<DocumentTemplateResultLi> DocumentTemplateResultLis { get; set; } = new List<DocumentTemplateResultLi>();

    public virtual ICollection<DocumentTemplateResult> DocumentTemplateResults { get; set; } = new List<DocumentTemplateResult>();

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual ICollection<PatientAppointment> PatientAppointments { get; set; } = new List<PatientAppointment>();

    public virtual CategoryProgram? Program { get; set; }

    public virtual CategoryAttribute? ReasonNavigation { get; set; }

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();
}
