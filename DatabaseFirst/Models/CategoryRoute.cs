using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đường dùng
/// </summary>
public partial class CategoryRoute
{
    public Guid RoutesId { get; set; }

    /// <summary>
    /// mã đường dùng
    /// </summary>
    public string RoutesCode { get; set; } = null!;

    /// <summary>
    /// tên đường dùng
    /// </summary>
    public string RoutesName { get; set; } = null!;

    /// <summary>
    /// thứ tự hiển thị
    /// </summary>
    public int? DisplayOrder { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryDoctorDosage> CategoryDoctorDosages { get; set; } = new List<CategoryDoctorDosage>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual ICollection<PatientDesignateServiceDrug> PatientDesignateServiceDrugs { get; set; } = new List<PatientDesignateServiceDrug>();
}
