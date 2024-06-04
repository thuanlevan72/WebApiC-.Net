using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Lịch sử biên bản hội chẩn
/// </summary>
public partial class ConferenceMinutesHistory
{
    public Guid ConferenceMinutesHistoryId { get; set; }

    /// <summary>
    /// Mô tả thêm của tên biên bản hội chẩn
    /// </summary>
    public string SubName { get; set; } = null!;

    /// <summary>
    /// Thời gian kết thúc hội chẩn
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Thời gian kết thúc hội chẩn
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Chủ tọa
    /// </summary>
    public string? Preside { get; set; }

    /// <summary>
    /// Thư ký
    /// </summary>
    public string? Secretary { get; set; }

    /// <summary>
    /// Thành viên tham gia
    /// </summary>
    public string? Participants { get; set; }

    /// <summary>
    /// Tóm tắt quá trình diễn biến bệnh, quá trình điều trị và chăm sóc người bệnh
    /// </summary>
    public string? DiseaseProgressionSummary { get; set; }

    /// <summary>
    /// Kết luận
    /// </summary>
    public string? Conclude { get; set; }

    /// <summary>
    /// Hướng điều trị
    /// </summary>
    public string? TreatmentDirection { get; set; }

    public Guid DocumentTemplateResultId { get; set; }

    public Guid BasicInformationPatientId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CategoryBasicInformationPatient BasicInformationPatient { get; set; } = null!;

    public virtual DocumentTemplateResult DocumentTemplateResult { get; set; } = null!;
}
