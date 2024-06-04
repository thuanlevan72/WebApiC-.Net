using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thành phố
/// </summary>
public partial class CategoryCity
{
    public Guid CityId { get; set; }

    /// <summary>
    /// id quốc gia
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// mã thành phố
    /// </summary>
    public string CityCode { get; set; } = null!;

    /// <summary>
    /// tên thành phố
    /// </summary>
    public string CityName { get; set; } = null!;

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// mã đồng bộ tiêm chủng quốc gia
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

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryDistrict> CategoryDistricts { get; set; } = new List<CategoryDistrict>();

    public virtual ICollection<CategoryHospital> CategoryHospitals { get; set; } = new List<CategoryHospital>();

    public virtual ICollection<CategoryPatient> CategoryPatientCities { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatient> CategoryPatientCityTemps { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<CategoryWard> CategoryWards { get; set; } = new List<CategoryWard>();

    public virtual CategoryNational? National { get; set; }
}
