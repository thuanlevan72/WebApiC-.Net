using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục số hiệu giường
/// </summary>
public partial class CategoryBedNumber
{
    public Guid BedNumberId { get; set; }

    /// <summary>
    /// số hiệu giường
    /// </summary>
    public string BedNumberCode { get; set; } = null!;

    /// <summary>
    /// khoa
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// phòng
    /// </summary>
    public Guid RoomId { get; set; }

    /// <summary>
    /// mã giường gửi bhyt
    /// </summary>
    public string? InsuranceBed { get; set; }

    /// <summary>
    /// loại giường
    /// </summary>
    public Guid? BedTypeId { get; set; }

    /// <summary>
    /// hồi sức tích cực
    /// </summary>
    public int? IsIntensiveCare { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryBedType? BedType { get; set; }

    public virtual ICollection<CategoryRoomBed> CategoryRoomBeds { get; set; } = new List<CategoryRoomBed>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<MedicalRecordRoomBed> MedicalRecordRoomBeds { get; set; } = new List<MedicalRecordRoomBed>();

    public virtual CategoryRoom Room { get; set; } = null!;
}
