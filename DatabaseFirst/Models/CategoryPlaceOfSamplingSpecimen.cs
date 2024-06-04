using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nơi lấy mẫu bệnh phẩm
/// </summary>
public partial class CategoryPlaceOfSamplingSpecimen
{
    public Guid PlaceOfSamplingSpecimemsId { get; set; }

    /// <summary>
    /// khoa chỉ định
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// nhà chỉ định
    /// </summary>
    public Guid BuildingId { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp1
    /// </summary>
    public Guid? GroupServiceLvl1 { get; set; }

    public Guid? Roomid { get; set; }

    /// <summary>
    /// sl hàng đợi
    /// </summary>
    public int? QueueQty { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsActive { get; set; }

    public virtual CategoryBuilding Building { get; set; } = null!;

    public virtual ICollection<CategoryPlaceOfSamplingAttribute> CategoryPlaceOfSamplingAttributes { get; set; } = new List<CategoryPlaceOfSamplingAttribute>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1Navigation { get; set; }

    public virtual ICollection<PlaceOfSamplingServiceGroupLvl2> PlaceOfSamplingServiceGroupLvl2s { get; set; } = new List<PlaceOfSamplingServiceGroupLvl2>();

    public virtual CategoryRoom? Room { get; set; }
}
