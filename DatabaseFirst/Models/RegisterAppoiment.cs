using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đăng kí lịch khám
/// </summary>
public partial class RegisterAppoiment
{
    public Guid RegisterAppointmentId { get; set; }

    public string FullName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Phone { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    public Guid? AccountId { get; set; }

    public DateTime TimeAppointment { get; set; }

    public string Note { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryDepartment? Department { get; set; }
}
