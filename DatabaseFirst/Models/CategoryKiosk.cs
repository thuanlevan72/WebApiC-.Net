using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục kiosk
/// </summary>
public partial class CategoryKiosk
{
    public Guid KioskId { get; set; }

    public string DiviceName { get; set; } = null!;

    public string MacAddress { get; set; } = null!;

    public Guid QmsTypeId { get; set; }

    public Guid QmsTemplateId { get; set; }

    public Guid DepartmentId { get; set; }

    public string? VideoUrl { get; set; }

    public TimeOnly? MorningFrom { get; set; }

    public TimeOnly? MorningTo { get; set; }

    public DateTimeOffset? AfternoonFrom { get; set; }

    public TimeOnly? AfternoonTo { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? CounterId { get; set; }

    public Guid? EmployeeNurseId { get; set; }

    public virtual CategoryCounter? Counter { get; set; }

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<KioskKioskClinicDoctor> KioskKioskClinicDoctors { get; set; } = new List<KioskKioskClinicDoctor>();

    public virtual ICollection<KioskScreenKiosk> KioskScreenKiosks { get; set; } = new List<KioskScreenKiosk>();

    public virtual CategoryTemplateQm QmsTemplate { get; set; } = null!;

    public virtual CategoryAttribute QmsType { get; set; } = null!;
}
