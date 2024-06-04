using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin Tờ điều trị
/// </summary>
public partial class PageTreatmentMedicalRecord
{
    public Guid MedicalRecordPageTreatmentId { get; set; }

    /// <summary>
    /// ngày y lệnh
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// ngày khám
    /// </summary>
    public DateTime TreatmentDate { get; set; }

    /// <summary>
    /// chẩn đoán bệnh
    /// </summary>
    public Guid? DiagnoseId { get; set; }

    /// <summary>
    /// chẩn đoán chi tiết
    /// </summary>
    public string? DiagnoseDetail { get; set; }

    /// <summary>
    /// thông tin bổ sung
    /// </summary>
    public string? AdditionalInformation { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// bác sĩ trực
    /// </summary>
    public Guid? TreatmentDoctor { get; set; }

    /// <summary>
    /// bác sĩ online
    /// </summary>
    public Guid? OnlineDoctor { get; set; }

    /// <summary>
    /// chế độ ăn
    /// </summary>
    public string? Diet { get; set; }

    /// <summary>
    /// giai đoạn bệnh
    /// </summary>
    public string? DiseaseStage { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// diễn biến bệnh
    /// </summary>
    public Guid? TemplateOfDevelopmentsId { get; set; }

    public string? DiagnoseText { get; set; }

    /// <summary>
    /// chế độ chăm sóc
    /// </summary>
    public Guid? CareStage { get; set; }

    public virtual CategoryCareMode? CareStageNavigation { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryDiseaseName? Diagnose { get; set; }

    public virtual CategoryAccount? OnlineDoctorNavigation { get; set; }

    public virtual ICollection<PageTreamentDiagnoseCompanying> PageTreamentDiagnoseCompanyings { get; set; } = new List<PageTreamentDiagnoseCompanying>();

    public virtual ICollection<PageTreamentPatientDesignateService> PageTreamentPatientDesignateServices { get; set; } = new List<PageTreamentPatientDesignateService>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceChemistry> PageTreatmentPatientDesignateServiceChemistries { get; set; } = new List<PageTreatmentPatientDesignateServiceChemistry>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceDinner> PageTreatmentPatientDesignateServiceDinners { get; set; } = new List<PageTreatmentPatientDesignateServiceDinner>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceDrug> PageTreatmentPatientDesignateServiceDrugs { get; set; } = new List<PageTreatmentPatientDesignateServiceDrug>();

    public virtual ICollection<PageTreatmentPatientDesignateServiceSupply> PageTreatmentPatientDesignateServiceSupplies { get; set; } = new List<PageTreatmentPatientDesignateServiceSupply>();

    public virtual CategoryTemplateOfDevelopment? TemplateOfDevelopments { get; set; }

    public virtual CategoryAccount? TreatmentDoctorNavigation { get; set; }
}
