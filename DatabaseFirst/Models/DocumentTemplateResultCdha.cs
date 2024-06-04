using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết quả cdha
/// </summary>
public partial class DocumentTemplateResultCdha
{
    public Guid DocumentTemplateResultCdhaId { get; set; }

    public string? Data { get; set; }

    public Guid? BasicInformationPatientId { get; set; }

    public Guid? PatientReceptionId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public int IsIpd { get; set; }

    public Guid? Pdf { get; set; }

    public Guid? TemplateCdhaLvl1 { get; set; }

    public Guid? TemplateCdhaLvl2 { get; set; }

    public Guid? TemplateCdhaLvl3 { get; set; }

    public Guid PatientId { get; set; }

    public Guid? AccountRead { get; set; }

    public Guid? AccountApprove { get; set; }

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DatePicture { get; set; }

    public virtual CategoryAccount? AccountApproveNavigation { get; set; }

    public virtual CategoryAccount? AccountReadNavigation { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInformationPatient { get; set; }

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryTemplateCdhalvl1? TemplateCdhaLvl1Navigation { get; set; }

    public virtual CategoryTemplateCdhalvl2? TemplateCdhaLvl2Navigation { get; set; }

    public virtual CategoryTemplateCdhalvl3? TemplateCdhaLvl3Navigation { get; set; }
}
