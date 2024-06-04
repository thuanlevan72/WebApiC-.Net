using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chỉ định dịch vụ phục hồi chức năng
/// </summary>
public partial class PatientDesignateServiceRehabilitation
{
    public Guid PatientDesignateRehabilitationId { get; set; }

    /// <summary>
    /// phục hồi chức năng
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// Bác sĩ chỉ định
    /// </summary>
    public Guid? AccountCreated { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? CodePrint { get; set; }

    /// <summary>
    /// bác sĩ điều trị PHCN
    /// </summary>
    public Guid? AccountRehabilitation { get; set; }

    /// <summary>
    /// chẩn đoán vào viện
    /// </summary>
    public Guid? BasicInfomationPatientId { get; set; }

    /// <summary>
    /// chẩn đoán phcn
    /// </summary>
    public Guid? DiagnoseNameId { get; set; }

    /// <summary>
    /// chẩn đoán khác
    /// </summary>
    public Guid? DiagnoseNameAccompanyingId { get; set; }

    /// <summary>
    /// chẩn đoán chi tiết
    /// </summary>
    public string? PreliminaryDiagnosis { get; set; }

    /// <summary>
    /// đợt
    /// </summary>
    public int? Batch { get; set; }

    /// <summary>
    /// nhân viên phụ
    /// </summary>
    public Guid? AccountOther { get; set; }

    /// <summary>
    /// không phẫu thuật
    /// </summary>
    public int? IsRehabilitation { get; set; }

    public int? IsIpd { get; set; }

    public Guid? DepartmentId { get; set; }

    public virtual CategoryAccount? AccountCreatedNavigation { get; set; }

    public virtual CategoryAccount? AccountOtherNavigation { get; set; }

    public virtual CategoryAccount? AccountRehabilitationNavigation { get; set; }

    public virtual CategoryBasicInformationPatient? BasicInfomationPatient { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryDiseaseName? DiagnoseName { get; set; }

    public virtual CategoryDiseaseName? DiagnoseNameAccompanying { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
