using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nguồn người bệnh
/// </summary>
public partial class CategoryPatientSource
{
    public Guid PatientSourceId { get; set; }

    /// <summary>
    /// Mã nguồn người bệnh
    /// </summary>
    public string PatientSourceCode { get; set; } = null!;

    /// <summary>
    /// Tên nguồn người bệnh
    /// </summary>
    public string PatientSourceName { get; set; } = null!;

    /// <summary>
    /// người giới thiệu
    /// </summary>
    public int IsPresenter { get; set; }

    public int IsLaterPay { get; set; }

    /// <summary>
    /// id nhóm nguồn người bệnh
    /// </summary>
    public Guid? GroupPatientSourceId { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryGroupCustomerCare> CategoryGroupCustomerCares { get; set; } = new List<CategoryGroupCustomerCare>();

    public virtual ICollection<CategoryPresenter> CategoryPresenters { get; set; } = new List<CategoryPresenter>();

    public virtual CategoryAttribute? GroupPatientSource { get; set; }

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual ICollection<PresenterPatientSource> PresenterPatientSources { get; set; } = new List<PresenterPatientSource>();
}
