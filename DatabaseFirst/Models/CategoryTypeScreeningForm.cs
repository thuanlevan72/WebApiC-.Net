using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Loại phiếu sàng lọc
/// </summary>
public partial class CategoryTypeScreeningForm
{
    public Guid TypeScreeningFormId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string TypeScreeningFormCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string TypeScreeningFormName { get; set; } = null!;

    /// <summary>
    /// id  báo cáo
    /// </summary>
    public Guid? ReportId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryQuestionScreeningForm> CategoryQuestionScreeningForms { get; set; } = new List<CategoryQuestionScreeningForm>();

    public virtual CategoryAttribute? Report { get; set; }
}
