using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục bác sĩ ngoại viện
/// </summary>
public partial class CategoryOutpatientDoctor
{
    public Guid OutpatientDoctorId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string OutpatientDoctorCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string OutpatientDoctorName { get; set; } = null!;

    /// <summary>
    /// đơn vị công tác
    /// </summary>
    public Guid HospitalId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual CategoryHospital Hospital { get; set; } = null!;
}
