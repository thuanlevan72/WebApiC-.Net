using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chương trình
/// </summary>
public partial class CategoryProgram
{
    public Guid ProgramId { get; set; }

    /// <summary>
    /// mã chương trình
    /// </summary>
    public string ProgramCode { get; set; } = null!;

    /// <summary>
    /// tên chương trình
    /// </summary>
    public string ProgramName { get; set; } = null!;

    /// <summary>
    /// giá trị
    /// </summary>
    public int ProgramValue { get; set; }

    /// <summary>
    /// mô tả
    /// </summary>
    public string ProgramDesc { get; set; } = null!;

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public DateTime? ToDate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// Hình thức miễn giảm
    /// </summary>
    public Guid? ExamptionFormAttributeId { get; set; }

    /// <summary>
    /// Cách thức miễn giảm
    /// </summary>
    public Guid? ExamptionMethodAttributeId { get; set; }

    /// <summary>
    /// Phân loại chương trình
    /// </summary>
    public Guid? ProgramTypeAttributeId { get; set; }

    /// <summary>
    /// Loại áp dụng
    /// </summary>
    public Guid? ServiceTypeAttributeId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int? Qty { get; set; }

    /// <summary>
    /// số lượng còn lại
    /// </summary>
    public int? QtyRemain { get; set; }

    /// <summary>
    /// số lượng đã sử dụng
    /// </summary>
    public int? QtyUse { get; set; }

    public virtual ICollection<CategoryGroupCustomerCare> CategoryGroupCustomerCares { get; set; } = new List<CategoryGroupCustomerCare>();

    public virtual ICollection<CategoryPatientReception> CategoryPatientReceptions { get; set; } = new List<CategoryPatientReception>();

    public virtual ICollection<CategoryVoucher> CategoryVouchers { get; set; } = new List<CategoryVoucher>();

    public virtual CategoryAttribute? ExamptionFormAttribute { get; set; }

    public virtual CategoryAttribute? ExamptionMethodAttribute { get; set; }

    public virtual ICollection<ProgramGroupService> ProgramGroupServices { get; set; } = new List<ProgramGroupService>();

    public virtual ICollection<ProgramService> ProgramServices { get; set; } = new List<ProgramService>();

    public virtual CategoryAttribute? ProgramTypeAttribute { get; set; }

    public virtual CategoryAttribute? ServiceTypeAttribute { get; set; }
}
