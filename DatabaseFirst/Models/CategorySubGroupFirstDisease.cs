using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm bệnh phụ 1
/// </summary>
public partial class CategorySubGroupFirstDisease
{
    public Guid SubGroupFirstDiseaseId { get; set; }

    public string SubGroupFirstDiseaseCode { get; set; } = null!;

    public string SubGroupFirstDiseaseName { get; set; } = null!;

    public Guid DiseaseChapterId { get; set; }

    public Guid MainDiseaseGroupId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual ICollection<CategoryDiseaseType> CategoryDiseaseTypes { get; set; } = new List<CategoryDiseaseType>();

    public virtual ICollection<CategorySubGroupSecondDisease> CategorySubGroupSecondDiseases { get; set; } = new List<CategorySubGroupSecondDisease>();

    public virtual CategoryDiseaseChapter DiseaseChapter { get; set; } = null!;

    public virtual CategoryMainDiseaseGroup MainDiseaseGroup { get; set; } = null!;
}
