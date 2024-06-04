using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục câu hỏi sàng lọc
/// </summary>
public partial class CategoryQuestionScreeningForm
{
    public Guid QuestionScreeningFormId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string QuestionScreeningFormCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string QuestionScreeningFormName { get; set; } = null!;

    /// <summary>
    /// phiếu câu hỏi
    /// </summary>
    public Guid TypeScreeningFormId { get; set; }

    /// <summary>
    /// stt
    /// </summary>
    public int QuestionNumber { get; set; }

    /// <summary>
    /// 1:có 2 có ghi chú
    /// </summary>
    public int QuestionType { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// 0: Thông tin người bệnh, 1: Khám sàng lọc, 2: Kết luận
    /// </summary>
    public int? QuestionIndex { get; set; }

    public virtual CategoryTypeScreeningForm TypeScreeningForm { get; set; } = null!;
}
