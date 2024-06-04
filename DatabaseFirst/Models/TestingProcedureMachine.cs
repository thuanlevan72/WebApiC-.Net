using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quy trình xét nghiệm - Mã máy
/// </summary>
public partial class TestingProcedureMachine
{
    public Guid TestingProcedureMachineId { get; set; }

    public Guid TestingProcedureId { get; set; }

    public Guid MachineId { get; set; }

    public virtual CategoryMachine Machine { get; set; } = null!;

    public virtual CategoryTestingProcedure TestingProcedure { get; set; } = null!;
}
