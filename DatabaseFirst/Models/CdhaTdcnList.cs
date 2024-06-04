using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chẩn đoán hình ảnh, thăm dò chức năng
/// </summary>
public partial class CdhaTdcnList
{
    public Guid CdhaTdcnListId { get; set; }

    /// <summary>
    /// dịch vụ chỉ định
    /// </summary>
    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// mã bệnh nhân
    /// </summary>
    public Guid PatientId { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int IsStatus { get; set; }

    public int IsActice { get; set; }

    /// <summary>
    /// đã thanh toán
    /// </summary>
    public int? IsPayment { get; set; }

    /// <summary>
    /// đã gửi pacs
    /// </summary>
    public int? IsPacs { get; set; }

    /// <summary>
    /// thời gian tiếp nhận
    /// </summary>
    public DateTime? TimeReception { get; set; }

    /// <summary>
    /// thời gian có kết quả
    /// </summary>
    public DateTime? TimeResult { get; set; }

    /// <summary>
    /// người tạo
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// người thực hiện
    /// </summary>
    public Guid? AccountImplement { get; set; }

    /// <summary>
    /// người tiếp nhận
    /// </summary>
    public Guid? AccountReception { get; set; }

    /// <summary>
    /// điều dưỡng
    /// </summary>
    public Guid? Nurse { get; set; }

    /// <summary>
    /// người đọc kết quả
    /// </summary>
    public Guid? AccountReadResult { get; set; }

    /// <summary>
    /// kết quả
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// kết luận
    /// </summary>
    public string? Conclude { get; set; }

    /// <summary>
    /// cách thức can thiệp
    /// </summary>
    public string? MethodOfIntervention { get; set; }

    /// <summary>
    /// phương thức can thiệp
    /// </summary>
    public string? InterventionMethod { get; set; }

    /// <summary>
    /// đề nghị
    /// </summary>
    public string? Suggestion { get; set; }

    /// <summary>
    /// số phiếu
    /// </summary>
    public int CdhaTdcnnListCode { get; set; }

    /// <summary>
    /// số kết nối
    /// </summary>
    public int CdhaTdcnnListNumberConnect { get; set; }

    public virtual ICollection<CdhatdcnlistChangeService> CdhatdcnlistChangeServices { get; set; } = new List<CdhatdcnlistChangeService>();

    public virtual CategoryPatient Patient { get; set; } = null!;
}
