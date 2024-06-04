using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại giường
/// </summary>
public partial class CategoryBedType
{
    public Guid BedTypeId { get; set; }

    /// <summary>
    /// mã loại giường
    /// </summary>
    public string BedTypeCode { get; set; } = null!;

    /// <summary>
    /// tên loại giường
    /// </summary>
    public string BedTypeName { get; set; } = null!;

    /// <summary>
    /// tỉ lệ thanh toán dịch vụ
    /// </summary>
    public int ServicePaymentRatio { get; set; }

    /// <summary>
    /// tỉ lệ thanh toán bảo hiểm
    /// </summary>
    public int? InsurancePaymentRatio { get; set; }

    public int? IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBedNumber> CategoryBedNumbers { get; set; } = new List<CategoryBedNumber>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBeds { get; set; } = new List<CategoryRoomBed>();
}
