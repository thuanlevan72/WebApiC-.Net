using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đối tượng hưởng bảo hiểm
/// </summary>
public partial class CategorySubjectOfInsurance
{
    public Guid SubjectOfInsuranceId { get; set; }

    /// <summary>
    /// tên 3 ký tự đầu của thẻ bh
    /// </summary>
    public string SubjectOfInsuranceName { get; set; } = null!;

    /// <summary>
    /// số % hưởng bh
    /// </summary>
    public int PercentInsurance { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<PatientInsurance> PatientInsurances { get; set; } = new List<PatientInsurance>();
}
