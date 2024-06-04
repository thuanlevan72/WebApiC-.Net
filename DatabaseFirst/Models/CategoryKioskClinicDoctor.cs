using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phòng khám và bác sĩ 
/// </summary>
public partial class CategoryKioskClinicDoctor
{
    public Guid KioskClinicDoctorId { get; set; }

    public Guid RoomId { get; set; }

    public Guid EmployeeId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAccount Employee { get; set; } = null!;

    public virtual ICollection<KioskKioskClinicDoctor> KioskKioskClinicDoctors { get; set; } = new List<KioskKioskClinicDoctor>();

    public virtual CategoryRoom Room { get; set; } = null!;
}
