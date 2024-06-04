using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập điều kiện chuyển khoa ra viện
/// </summary>
public partial class CategorySettingConditionDirectDepartment
{
    public Guid SettingConditionDirectDepartmentId { get; set; }

    /// <summary>
    /// chuyển khoa tới thường
    /// </summary>
    public int? DirectToNormalDepartment { get; set; }

    /// <summary>
    /// chuyển khoa tới phẫu thuật
    /// </summary>
    public int? DirectToSurgeryDepartment { get; set; }

    /// <summary>
    /// chuyển khoa từ khoa phẫu thuật
    /// </summary>
    public int? DirectFromSurgeryDepartment { get; set; }

    /// <summary>
    /// ra viện từ khoa thường
    /// </summary>
    public int? DischargeFromNormalDepartment { get; set; }

    /// <summary>
    /// ra viện từ khoa phẫu thuật
    /// </summary>
    public int? DischargeFromSurgeryDepartment { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// tên thiết lập
    /// </summary>
    public Guid SettingConditionDirectDepartmentName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public virtual CategoryAttribute SettingConditionDirectDepartmentNameNavigation { get; set; } = null!;
}
