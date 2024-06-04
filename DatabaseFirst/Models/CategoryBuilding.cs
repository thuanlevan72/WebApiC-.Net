using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách tòa nhà
/// </summary>
public partial class CategoryBuilding
{
    public Guid BuildingId { get; set; }

    /// <summary>
    /// mã tòa nhà
    /// </summary>
    public string BuildingCode { get; set; } = null!;

    /// <summary>
    /// tên tòa nhà
    /// </summary>
    public string BuildingName { get; set; } = null!;

    /// <summary>
    /// mô tả
    /// </summary>
    public string BuildingDesc { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryArea> CategoryAreas { get; set; } = new List<CategoryArea>();

    public virtual ICollection<CategoryCounter> CategoryCounters { get; set; } = new List<CategoryCounter>();

    public virtual ICollection<CategoryPlaceOfSamplingSpecimen> CategoryPlaceOfSamplingSpecimen { get; set; } = new List<CategoryPlaceOfSamplingSpecimen>();

    public virtual ICollection<CategoryRoom> CategoryRooms { get; set; } = new List<CategoryRoom>();

    public virtual ICollection<DepartmentBuildingMoney> DepartmentBuildingMoneys { get; set; } = new List<DepartmentBuildingMoney>();

    public virtual ICollection<DepartmentBuilding> DepartmentBuildings { get; set; } = new List<DepartmentBuilding>();

    public virtual ICollection<EmployeeDepartmentBuilding> EmployeeDepartmentBuildings { get; set; } = new List<EmployeeDepartmentBuilding>();
}
