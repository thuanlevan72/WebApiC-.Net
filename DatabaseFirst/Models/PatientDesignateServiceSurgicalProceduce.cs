using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chỉ định dịch vụ phẫu thuật thủ thuật
/// </summary>
public partial class PatientDesignateServiceSurgicalProceduce
{
    public Guid PatientDesignateSurgicalProceducesId { get; set; }

    /// <summary>
    /// phẫu thuật thủ thuật
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// buồng phẫu thuật
    /// </summary>
    public Guid? SurgicalChamberId { get; set; }

    /// <summary>
    /// thời gian pttt
    /// </summary>
    public Guid? SurgicalTime { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int? SurgicalStatus { get; set; }

    /// <summary>
    /// gói phẫu thuật
    /// </summary>
    public Guid? SurgicalPackage { get; set; }

    /// <summary>
    /// thời gian bắt đầu
    /// </summary>
    public DateTime? SurgicalStartDate { get; set; }

    /// <summary>
    /// thời gian kết thúc
    /// </summary>
    public DateTime? SurgicalEndDate { get; set; }

    /// <summary>
    /// phương pháp gây mê
    /// </summary>
    public Guid? AnesthesiaMethod { get; set; }

    /// <summary>
    /// mẫu kết quả
    /// </summary>
    public Guid? SurgicalTemplateResultId { get; set; }

    /// <summary>
    /// chẩn đoán trước phẫu thuật
    /// </summary>
    public Guid? PreoperativeDiagnosisId { get; set; }

    /// <summary>
    /// chuẩn đoán sau pttt icd 10
    /// </summary>
    public Guid? DiagnosisAfterSurgeryIcdId { get; set; }

    /// <summary>
    /// mã phiếu pttt
    /// </summary>
    public Guid? SurgicalCode { get; set; }

    /// <summary>
    /// phương pháp pttt
    /// </summary>
    public string? SurgicalMethod { get; set; }

    /// <summary>
    /// kết luận
    /// </summary>
    public string? Conclude { get; set; }

    /// <summary>
    /// lược đồ
    /// </summary>
    public string? SurgicalDiagram { get; set; }

    /// <summary>
    /// cách thức pttt
    /// </summary>
    public string? MethodOfSurgical { get; set; }

    /// <summary>
    /// không phẫu thuật
    /// </summary>
    public int? IsNotSurgical { get; set; }

    /// <summary>
    /// loại pttt
    /// </summary>
    public Guid? SurgicalType { get; set; }

    /// <summary>
    /// chẩn đoán sauphẫu thuật
    /// </summary>
    public string? DiagnosisAfterSurgeryId { get; set; }

    public Guid? AccountCreated { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? PatientId { get; set; }

    public string? CodePrint { get; set; }

    /// <summary>
    /// Phân loại PTTT
    /// </summary>
    public Guid? ClassificationSurgicalProceduresId { get; set; }

    public string? Data { get; set; }

    public Guid? DepartmentId { get; set; }

    public virtual CategoryEmotionlessMethod? AnesthesiaMethodNavigation { get; set; }

    public virtual CategoryAttribute? ClassificationSurgicalProcedures { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryDiseaseName? DiagnosisAfterSurgeryIcd { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual ICollection<PatientDesignateServiceDetailSurgicalProceduce> PatientDesignateServiceDetailSurgicalProceduces { get; set; } = new List<PatientDesignateServiceDetailSurgicalProceduce>();

    public virtual CategoryDiseaseName? PreoperativeDiagnosis { get; set; }

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplements { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual CategoryRoom? SurgicalChamber { get; set; }

    public virtual Category10daySurgeryPackage? SurgicalPackageNavigation { get; set; }

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplements { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual CategoryResultTemplateSurgery? SurgicalTemplateResult { get; set; }

    public virtual CategoryAttribute? SurgicalTimeNavigation { get; set; }

    public virtual CategoryAttribute? SurgicalTypeNavigation { get; set; }
}
