using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chi nhánh
/// </summary>
public partial class CategoryBranch
{
    public Guid BranchId { get; set; }

    /// <summary>
    /// mã chi nhánh
    /// </summary>
    public string BranchCode { get; set; } = null!;

    /// <summary>
    /// tên chi nhánh
    /// </summary>
    public string BranchName { get; set; } = null!;

    /// <summary>
    /// id đơn vị y tế
    /// </summary>
    public Guid MedicalUnitId { get; set; }

    /// <summary>
    /// đơn vị chủ quản
    /// </summary>
    public int IsMain { get; set; }

    /// <summary>
    /// Sinh dải mã người bệnh riêng
    /// </summary>
    public int IsPatientPrivateCode { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryMedicalUnit MedicalUnit { get; set; } = null!;
}
