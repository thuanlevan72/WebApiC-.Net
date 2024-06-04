using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin cơ bản bệnh nhân
/// </summary>
public partial class CategoryBasicInformationPatient
{
    public Guid BasicInformationPatientId { get; set; }

    public Guid? PatientDiagnoseId { get; set; }

    public Guid? PatientHistoryId { get; set; }

    public Guid? PatientSearchId { get; set; }

    public string? Reason { get; set; }

    public Guid? RoomId { get; set; }

    /// <summary>
    /// hướng điều trị
    /// </summary>
    public int? TreatmentDirect { get; set; }

    /// <summary>
    /// kết quả
    /// </summary>
    public int? Result { get; set; }

    public Guid? PatientId { get; set; }

    public Guid? PatientDesignateServiceId { get; set; }

    /// <summary>
    /// 1 : đang khám, 2 đang thực hiện dịch vụ
    /// </summary>
    public int? IsStatus { get; set; }

    /// <summary>
    /// kết quả chuyên khoa
    /// </summary>
    public string? ResultSpecialist { get; set; }

    /// <summary>
    /// ngày tạo
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Ngày kết thúc khám
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// tài khoản kết thúc khám
    /// </summary>
    public Guid? AccountId { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryLongTermTreatment> CategoryLongTermTreatments { get; set; } = new List<CategoryLongTermTreatment>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<ConferenceMinutesHistory> ConferenceMinutesHistories { get; set; } = new List<ConferenceMinutesHistory>();

    public virtual ICollection<DesignateServicePrescription> DesignateServicePrescriptions { get; set; } = new List<DesignateServicePrescription>();

    public virtual ICollection<DirectHospitalize> DirectHospitalizes { get; set; } = new List<DirectHospitalize>();

    public virtual ICollection<DirectMedicalExamie> DirectMedicalExamies { get; set; } = new List<DirectMedicalExamie>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual ICollection<DocumentTemplateResultLi> DocumentTemplateResultLis { get; set; } = new List<DocumentTemplateResultLi>();

    public virtual ICollection<DocumentTemplateResult> DocumentTemplateResults { get; set; } = new List<DocumentTemplateResult>();

    public virtual ICollection<Hospitalize> Hospitalizes { get; set; } = new List<Hospitalize>();

    public virtual CategoryPatient? Patient { get; set; }

    public virtual CategoryPatientDesignateService? PatientDesignateService { get; set; }

    public virtual ICollection<PatientDesignateServiceBasicInformationPatient> PatientDesignateServiceBasicInformationPatients { get; set; } = new List<PatientDesignateServiceBasicInformationPatient>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual PatientDiagnose? PatientDiagnose { get; set; }

    public virtual PatientHistory? PatientHistory { get; set; }

    public virtual PatientSearch? PatientSearch { get; set; }

    public virtual ICollection<ResultAppoimentBasicInformationPatient> ResultAppoimentBasicInformationPatients { get; set; } = new List<ResultAppoimentBasicInformationPatient>();

    public virtual ICollection<ResultHomeBasicInformationPatient> ResultHomeBasicInformationPatients { get; set; } = new List<ResultHomeBasicInformationPatient>();

    public virtual CategoryRoom? Room { get; set; }
}
