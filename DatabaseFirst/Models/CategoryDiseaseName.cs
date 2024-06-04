using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tên bệnh
/// </summary>
public partial class CategoryDiseaseName
{
    public Guid DiseaseNameId { get; set; }

    public string? DiseaseNameCode { get; set; }

    public string? DiseaseName { get; set; }

    public Guid? MainDiseaseGroupId { get; set; }

    public Guid? DiseaseChapterId { get; set; }

    public Guid? SubGroupFirstDiseaseId { get; set; }

    public Guid? SubGroupSecondDiseaseId { get; set; }

    public Guid? DiseaseTypeId { get; set; }

    public string? GroupCodeBcByt { get; set; }

    public string? GroupDetail { get; set; }

    public string? InsuranceCodeDisease { get; set; }

    public Guid? DiseaseGroupId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsTypeIcd { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryHospitalDischargeInfomation> CategoryHospitalDischargeInfomations { get; set; } = new List<CategoryHospitalDischargeInfomation>();

    public virtual ICollection<CategorySummary15DayDiagnose> CategorySummary15DayDiagnoses { get; set; } = new List<CategorySummary15DayDiagnose>();

    public virtual ICollection<CategorySummary15Day> CategorySummary15Days { get; set; } = new List<CategorySummary15Day>();

    public virtual CategoryDiseaseChapter? DiseaseChapter { get; set; }

    public virtual CategoryDiseaseGroup? DiseaseGroup { get; set; }

    public virtual CategoryDiseaseType? DiseaseType { get; set; }

    public virtual ICollection<HospitalDischargeInfomationCompanying> HospitalDischargeInfomationCompanyings { get; set; } = new List<HospitalDischargeInfomationCompanying>();

    public virtual CategoryMainDiseaseGroup? MainDiseaseGroup { get; set; }

    public virtual ICollection<PageTreamentDiagnoseCompanying> PageTreamentDiagnoseCompanyings { get; set; } = new List<PageTreamentDiagnoseCompanying>();

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecords { get; set; } = new List<PageTreatmentMedicalRecord>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitationDiagnoseNameAccompanyings { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitationDiagnoseNames { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduceDiagnosisAfterSurgeryIcds { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceducePreoperativeDiagnoses { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientDiagnoseCompanying> PatientDiagnoseCompanyings { get; set; } = new List<PatientDiagnoseCompanying>();

    public virtual ICollection<PatientDiagnose> PatientDiagnoseDiagnoseNameAccompanyings { get; set; } = new List<PatientDiagnose>();

    public virtual ICollection<PatientDiagnose> PatientDiagnoseDiagnoseNames { get; set; } = new List<PatientDiagnose>();

    public virtual ICollection<PatientDiagonosePreliminary> PatientDiagonosePreliminaries { get; set; } = new List<PatientDiagonosePreliminary>();

    public virtual ICollection<ReportDrugInteractionsDiseaseName> ReportDrugInteractionsDiseaseNames { get; set; } = new List<ReportDrugInteractionsDiseaseName>();

    public virtual CategorySubGroupFirstDisease? SubGroupFirstDisease { get; set; }

    public virtual CategorySubGroupSecondDisease? SubGroupSecondDisease { get; set; }
}
