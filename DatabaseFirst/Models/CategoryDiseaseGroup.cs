using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhóm bệnh tật
/// </summary>
public partial class CategoryDiseaseGroup
{
    public Guid DiseaseGroupId { get; set; }

    /// <summary>
    /// mã nhóm
    /// </summary>
    public string DiseaseGroupCode { get; set; } = null!;

    /// <summary>
    /// tên nhóm
    /// </summary>
    public string DiseaseGroupName { get; set; } = null!;

    /// <summary>
    /// chương bệnh
    /// </summary>
    public Guid DiseaseChapterId { get; set; }

    /// <summary>
    /// stt
    /// </summary>
    public int DiseaseIndex { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// 0: icd 10, 1 icd 9
    /// </summary>
    public int? IsTypeIcd { get; set; }

    public virtual ICollection<CategoryDiseaseName> CategoryDiseaseNames { get; set; } = new List<CategoryDiseaseName>();

    public virtual CategoryDiseaseChapter DiseaseChapter { get; set; } = null!;
}
