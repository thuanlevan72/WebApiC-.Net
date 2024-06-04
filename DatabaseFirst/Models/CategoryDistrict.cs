using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quận huyện
/// </summary>
public partial class CategoryDistrict
{
    public Guid DistrictId { get; set; }

    /// <summary>
    /// mã quận huyện
    /// </summary>
    public string DistrictCode { get; set; } = null!;

    /// <summary>
    /// tên quận huyện
    /// </summary>
    public string DistrictName { get; set; } = null!;

    /// <summary>
    /// từ viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// id quốc gia
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// id thành phố
    /// </summary>
    public Guid CityId { get; set; }

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

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryPatient> CategoryPatientDistrictTemps { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatient> CategoryPatientDistricts { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<CategoryWard> CategoryWards { get; set; } = new List<CategoryWard>();

    public virtual CategoryCity City { get; set; } = null!;

    public virtual CategoryNational? National { get; set; }
}
