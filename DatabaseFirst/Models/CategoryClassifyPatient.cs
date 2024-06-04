using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phân loại bệnh nhân
/// </summary>
public partial class CategoryClassifyPatient
{
    public Guid ClassifyPatientId { get; set; }

    /// <summary>
    /// mã phân loại người bệnh
    /// </summary>
    public string ClassifyPatientCode { get; set; } = null!;

    /// <summary>
    /// tên phân loại người bệnh
    /// </summary>
    public string ClassifyPatientName { get; set; } = null!;

    /// <summary>
    /// mô tả
    /// </summary>
    public string? ClassifyPatientDesc { get; set; }

    /// <summary>
    /// màu nền
    /// </summary>
    public string? ClassifyPatientBg { get; set; }

    /// <summary>
    /// màu chữ
    /// </summary>
    public string? ClassifyPatientTextColor { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();
}
