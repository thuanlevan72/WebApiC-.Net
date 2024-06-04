using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loa gọi số
/// </summary>
public partial class CategorySpeakerCalling
{
    public Guid SpeakerCallingId { get; set; }

    /// <summary>
    /// mã loa gọi số
    /// </summary>
    public string SpeakerCallingCode { get; set; } = null!;

    /// <summary>
    /// tên loa gọi số
    /// </summary>
    public string SpeakerCallingName { get; set; } = null!;

    /// <summary>
    /// loại tiếp đón
    /// </summary>
    public Guid? ReceptionType { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// hình thức phát loa
    /// </summary>
    public Guid? SpeakerCallingType { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryCounter> CategoryCounters { get; set; } = new List<CategoryCounter>();

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryAttribute? ReceptionTypeNavigation { get; set; }

    public virtual CategoryAttribute? SpeakerCallingTypeNavigation { get; set; }
}
