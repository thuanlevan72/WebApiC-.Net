using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm bệnh chính
/// </summary>
public partial class CategoryMainDiseaseGroup
{
    public Guid MainDiseaseGroupId { get; set; }

    /// <summary>
    /// mã nhóm chính
    /// </summary>
    public string MainDiseaseGroupCode { get; set; } = null!;

    /// <summary>
    /// tên nhóm chính
    /// </summary>
    public string MainDiseaseGroupName { get; set; } = null!;

    /// <summary>
    /// chương bệnh
    /// </summary>
    public Guid DiseaseChapterId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual ICollection<CategoryDiseaseType> CategoryDiseaseTypes { get; set; } = new List<CategoryDiseaseType>();

    public virtual ICollection<CategorySubGroupFirstDisease> CategorySubGroupFirstDiseases { get; set; } = new List<CategorySubGroupFirstDisease>();

    public virtual ICollection<CategorySubGroupSecondDisease> CategorySubGroupSecondDiseases { get; set; } = new List<CategorySubGroupSecondDisease>();

    public virtual CategoryDiseaseChapter DiseaseChapter { get; set; } = null!;
}
