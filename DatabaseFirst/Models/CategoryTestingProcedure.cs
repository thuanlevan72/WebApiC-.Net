using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quy trình xét nghiệm
/// </summary>
public partial class CategoryTestingProcedure
{
    public Guid TestingProcedureId { get; set; }

    /// <summary>
    /// mã xét nghiệm
    /// </summary>
    public string TestingProcedureCode { get; set; } = null!;

    /// <summary>
    /// tên xét nghiệm
    /// </summary>
    public string TestingProcedureName { get; set; } = null!;

    public int? IsIso { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<TestingProcedureLaboratory> TestingProcedureLaboratories { get; set; } = new List<TestingProcedureLaboratory>();

    public virtual ICollection<TestingProcedureMachine> TestingProcedureMachines { get; set; } = new List<TestingProcedureMachine>();
}
