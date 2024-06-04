using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập kho chỉ định
/// </summary>
public partial class CategorySetUpDesignatedWarehouse
{
    public Guid SetUpDesignatedWareHouseId { get; set; }

    /// <summary>
    /// Kho
    /// </summary>
    public Guid WarehouseId { get; set; }

    /// <summary>
    /// loại dv
    /// </summary>
    public Guid ConceptId { get; set; }

    /// <summary>
    /// khoa nb
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// khoa chỉ định
    /// </summary>
    public Guid? DesignatedDepartmentId { get; set; }

    /// <summary>
    /// đối tượng
    /// </summary>
    public Guid? ObjectId { get; set; }

    /// <summary>
    /// loại đối tượng
    /// </summary>
    public Guid? ObjectTypeId { get; set; }

    /// <summary>
    /// cận lâm sàng
    /// </summary>
    public int? IsSubclinical { get; set; }

    /// <summary>
    /// cấp cứu
    /// </summary>
    public int? IsEmergency { get; set; }

    /// <summary>
    /// phòng
    /// </summary>
    public Guid? RoomId { get; set; }

    /// <summary>
    /// chức vụ
    /// </summary>
    public Guid? PositionId { get; set; }

    /// <summary>
    /// tài khoản
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// mức độ ưu tiên
    /// </summary>
    public int? PiorityLvl { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    /// <summary>
    /// nội trú
    /// </summary>
    public int? Ipd { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryDepartment? DesignatedDepartment { get; set; }

    public virtual CategoryAttribute? Object { get; set; }

    public virtual CategoryObjectType? ObjectType { get; set; }

    public virtual CategoryPosition? Position { get; set; }

    public virtual CategoryRoom? Room { get; set; }

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
