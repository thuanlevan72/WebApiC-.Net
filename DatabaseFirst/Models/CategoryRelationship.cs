using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mối quan hệ
/// </summary>
public partial class CategoryRelationship
{
    public Guid RelationshipId { get; set; }

    /// <summary>
    /// mã mối quan hệ
    /// </summary>
    public string RelationshipCode { get; set; } = null!;

    /// <summary>
    /// tên mối quan hệ
    /// </summary>
    public string RelationshipName { get; set; } = null!;

    /// <summary>
    /// mã đồng bộ TCQG
    /// </summary>
    public string? VaccinationNationalSyncCode { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientRelation> PatientRelationRelationShip2s { get; set; } = new List<PatientRelation>();

    public virtual ICollection<PatientRelation> PatientRelationRelationShips { get; set; } = new List<PatientRelation>();
}
