using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nghề nghiệp
/// </summary>
public partial class CategoryJob
{
    public Guid JobId { get; set; }

    /// <summary>
    /// mã nghề nghiệp
    /// </summary>
    public string JobCode { get; set; } = null!;

    /// <summary>
    /// tên nghề nghiệp
    /// </summary>
    public string JobName { get; set; } = null!;

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

    public virtual ICollection<CategoryInsuranceCard> CategoryInsuranceCards { get; set; } = new List<CategoryInsuranceCard>();

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<DirectHospitalize> DirectHospitalizes { get; set; } = new List<DirectHospitalize>();
}
