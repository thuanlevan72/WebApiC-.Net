using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục Tai nạn thương tích
/// </summary>
public partial class CategoryCauseOfHospital
{
    public Guid CauseOfHospitalId { get; set; }

    /// <summary>
    /// mã nguyên nhân nhập viện
    /// </summary>
    public string CauseOfHospitalCode { get; set; } = null!;

    /// <summary>
    /// tên nguyên nhân nhập viện
    /// </summary>
    public string CauseOfHospitalName { get; set; } = null!;

    /// <summary>
    /// mã đẩy bhyt
    /// </summary>
    public string InsurancePushCode { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
