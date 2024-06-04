using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// nhóm bệnh phụ 2
/// </summary>
public partial class CategorySubGroupSecondDisease
{
    public Guid SubGroupSecondDiseaseId { get; set; }

    public string SubGroupSecondDiseaseCode { get; set; } = null!;

    public string SubGroupSecondDiseaseName { get; set; } = null!;

    public Guid DiseaseChapterId { get; set; }

    public Guid SubGroupFirstDiseaseId { get; set; }

    public Guid MainDiseaseGroupId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual ICollection<CategoryDiseaseType> CategoryDiseaseTypes { get; set; } = new List<CategoryDiseaseType>();

    public virtual CategoryDiseaseChapter DiseaseChapter { get; set; } = null!;

    public virtual CategoryMainDiseaseGroup MainDiseaseGroup { get; set; } = null!;

    public virtual CategorySubGroupFirstDisease SubGroupFirstDisease { get; set; } = null!;
}
