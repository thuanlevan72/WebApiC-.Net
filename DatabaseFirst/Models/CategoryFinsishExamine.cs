using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đóng hồ sơ
/// </summary>
public partial class CategoryFinsishExamine
{
    public Guid FinishExamineId { get; set; }

    /// <summary>
    /// bác sĩ kết luận
    /// </summary>
    public Guid AccountResult { get; set; }

    /// <summary>
    /// người phiên dịch
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// thời gian kết thúc
    /// </summary>
    public DateTime TimeFinish { get; set; }

    /// <summary>
    /// mã bệnh án dài hạn
    /// </summary>
    public Guid SetUpMedicalRecordId { get; set; }

    /// <summary>
    /// tiếp đón
    /// </summary>
    public Guid PatientReceptionId { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime DeletedAt { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryAccount AccountResultNavigation { get; set; } = null!;

    public virtual CategoryPatientReception PatientReception { get; set; } = null!;
}
