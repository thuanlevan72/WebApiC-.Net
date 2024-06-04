using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// quy trình xét nghiệm - dịch vụ
/// </summary>
public partial class TestingProcedureLaboratory
{
    public Guid TestingProcedureLaboratoryId { get; set; }

    public Guid TestingProcedureId { get; set; }

    public Guid LaboratoryId { get; set; }

    public virtual CategoryLaboratoryService Laboratory { get; set; } = null!;

    public virtual CategoryTestingProcedure TestingProcedure { get; set; } = null!;
}
