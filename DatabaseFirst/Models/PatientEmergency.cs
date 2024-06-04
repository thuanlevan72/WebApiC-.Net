using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Tiếp đón - cấp cứu
/// </summary>
public partial class PatientEmergency
{
    public Guid PatientEmergencyId { get; set; }

    public Guid? PatientId { get; set; }

    /// <summary>
    /// loại thương tích
    /// </summary>
    public Guid? EmergencyTypeId { get; set; }

    /// <summary>
    /// vị trí chấn thương
    /// </summary>
    public Guid? InjuryId { get; set; }

    public Guid? EmergencyTimeId { get; set; }

    /// <summary>
    /// không xd định danh tính
    /// </summary>
    public int? IsUnidentity { get; set; }

    /// <summary>
    /// không có người thân
    /// </summary>
    public int? IsNotFamily { get; set; }

    /// <summary>
    /// nguyên nhân tai nạn thương tích
    /// </summary>
    public Guid? CauseOfHospitalId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryEmergencyTime? EmergencyTime { get; set; }

    public virtual CategoryEmergencyType? EmergencyType { get; set; }

    public virtual CategoryPatient? Patient { get; set; }
}
