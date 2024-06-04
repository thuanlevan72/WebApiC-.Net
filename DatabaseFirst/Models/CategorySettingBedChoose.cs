using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập chọn giường
/// </summary>
public partial class CategorySettingBedChoose
{
    public Guid SettingBedChooseId { get; set; }

    /// <summary>
    /// dịch vụ giường
    /// </summary>
    public Guid BedServiceId { get; set; }

    /// <summary>
    /// khoa chỉ định
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// dịch vụ cấp 1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// trường hợp áp dụng 1:trước phẫu thuật 2 sau phẫu thuật 3 không phẫu thuật
    /// </summary>
    public int ApplyCase { get; set; }

    /// <summary>
    /// số ngày sau mổ
    /// </summary>
    public int? AfterDayOperationRooms { get; set; }

    /// <summary>
    /// hồi sức tích cực
    /// </summary>
    public int IsIntensiveCare { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual ICollection<SettingBedChooseClassifySurgery> SettingBedChooseClassifySurgeries { get; set; } = new List<SettingBedChooseClassifySurgery>();
}
