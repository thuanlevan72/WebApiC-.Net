using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục người đại diện
/// </summary>
public partial class CategoryRepresentative
{
    public Guid RepresentativeId { get; set; }

    /// <summary>
    /// mã người đại diện
    /// </summary>
    public string RepresentativeCode { get; set; } = null!;

    /// <summary>
    /// tên người đại diện
    /// </summary>
    public string RepresentativeName { get; set; } = null!;

    /// <summary>
    /// số điện thoại
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// ngày sinh
    /// </summary>
    public string? Dob { get; set; }

    /// <summary>
    /// số tài khoản
    /// </summary>
    public string? AccountNum { get; set; }

    /// <summary>
    /// mã só thuế
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// địa chỉ
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// cơ quan đơn vị
    /// </summary>
    public Guid? AgencyUnitId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAgenciesUnit? AgencyUnit { get; set; }
}
