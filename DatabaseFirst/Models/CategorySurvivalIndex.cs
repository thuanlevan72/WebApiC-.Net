using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục chỉ số sống
/// </summary>
public partial class CategorySurvivalIndex
{
    public Guid SurvivalIndexId { get; set; }

    /// <summary>
    /// mã chỉ số sống
    /// </summary>
    public string SurvivalIndexCode { get; set; } = null!;

    /// <summary>
    /// tên chỉ số sống
    /// </summary>
    public string SurvivalIndexName { get; set; } = null!;

    /// <summary>
    /// đơn vị
    /// </summary>
    public string Unit { get; set; } = null!;

    /// <summary>
    /// giá trị tối thiểu
    /// </summary>
    public double? MinValue { get; set; }

    /// <summary>
    /// giá trị tối đa
    /// </summary>
    public double? MaxValue { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<SurvivalIndexDepartment> SurvivalIndexDepartments { get; set; } = new List<SurvivalIndexDepartment>();

    public virtual ICollection<VitalSignsPidSurvivalIndex> VitalSignsPidSurvivalIndices { get; set; } = new List<VitalSignsPidSurvivalIndex>();
}
