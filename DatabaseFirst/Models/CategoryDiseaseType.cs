using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Loại bệnh
/// </summary>
public partial class CategoryDiseaseType
{
    public Guid DiseaseTypeId { get; set; }

    public string DiseaseTypeCode { get; set; } = null!;

    public string DiseaseTypeName { get; set; } = null!;

    public Guid DiseaseChapterId { get; set; }

    public Guid MainDiseaseGroupId { get; set; }

    public Guid? SubGroupFirstDiseaseId { get; set; }

    public Guid? SubGroupSecondDiseaseId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// 0 : icd 10, 1 là icd 9
    /// </summary>
    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual CategoryDiseaseChapter DiseaseChapter { get; set; } = null!;

    public virtual CategoryMainDiseaseGroup MainDiseaseGroup { get; set; } = null!;

    public virtual ICollection<PatientDiagnose> PatientDiagnoses { get; set; } = new List<PatientDiagnose>();

    public virtual CategorySubGroupFirstDisease? SubGroupFirstDisease { get; set; }

    public virtual CategorySubGroupSecondDisease? SubGroupSecondDisease { get; set; }
}
