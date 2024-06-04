using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục dân tộc
/// </summary>
public partial class CategoryEthnic
{
    public Guid EthnicId { get; set; }

    /// <summary>
    /// mã dân tộc
    /// </summary>
    public string EthnicCode { get; set; } = null!;

    /// <summary>
    /// tên dân tộc
    /// </summary>
    public string EthnicName { get; set; } = null!;

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

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();
}
