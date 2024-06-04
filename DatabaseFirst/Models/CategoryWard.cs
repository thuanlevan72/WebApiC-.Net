using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục xã phường
/// </summary>
public partial class CategoryWard
{
    public Guid WardId { get; set; }

    /// <summary>
    /// id quốc gia
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// id thành phố
    /// </summary>
    public Guid? CityId { get; set; }

    /// <summary>
    /// id quận huyện
    /// </summary>
    public Guid DistrictId { get; set; }

    /// <summary>
    /// mã xã/phường
    /// </summary>
    public string WardCode { get; set; } = null!;

    /// <summary>
    /// tên xã/phường
    /// </summary>
    public string WardName { get; set; } = null!;

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// mã đồng bộ TCQG
    /// </summary>
    public string? VaccinationNationalSyncCode { get; set; }

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<CategoryPatient> CategoryPatientWardTemps { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatient> CategoryPatientWards { get; set; } = new List<CategoryPatient>();

    public virtual CategoryCity? City { get; set; }

    public virtual CategoryDistrict District { get; set; } = null!;

    public virtual CategoryNational? National { get; set; }
}
