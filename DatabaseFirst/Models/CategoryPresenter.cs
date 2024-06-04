using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Người giới thiệu
/// </summary>
public partial class CategoryPresenter
{
    public Guid PresenterId { get; set; }

    /// <summary>
    /// mã người giới thiệu
    /// </summary>
    public string PresenterCode { get; set; } = null!;

    public string PresenterName { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? PatientSourceId { get; set; }

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual CategoryPatientSource? PatientSource { get; set; }

    public virtual ICollection<PresenterPatientSource> PresenterPatientSources { get; set; } = new List<PresenterPatientSource>();
}
