using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chương bệnh
/// </summary>
public partial class CategoryDiseaseChapter
{
    public Guid DiseaseChapterId { get; set; }

    /// <summary>
    /// số thứ tự
    /// </summary>
    public int DiseaseChapterNumber { get; set; }

    /// <summary>
    /// mã chương bệnh
    /// </summary>
    public string DiseaseChapterCode { get; set; } = null!;

    /// <summary>
    /// tên chương bệnh
    /// </summary>
    public string DiseaseChapterName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// 0: icd 10, 1 icd 9
    /// </summary>
    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseGroup> CategoryDiseaseGroups { get; set; } = new List<CategoryDiseaseGroup>();

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual ICollection<CategoryDiseaseType> CategoryDiseaseTypes { get; set; } = new List<CategoryDiseaseType>();

    public virtual ICollection<CategoryMainDiseaseGroup> CategoryMainDiseaseGroups { get; set; } = new List<CategoryMainDiseaseGroup>();

    public virtual ICollection<CategorySubGroupFirstDisease> CategorySubGroupFirstDiseases { get; set; } = new List<CategorySubGroupFirstDisease>();

    public virtual ICollection<CategorySubGroupSecondDisease> CategorySubGroupSecondDiseases { get; set; } = new List<CategorySubGroupSecondDisease>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();
}
