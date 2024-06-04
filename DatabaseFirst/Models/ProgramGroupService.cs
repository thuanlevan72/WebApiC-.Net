using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chương trình - nhóm dịch vụ
/// </summary>
public partial class ProgramGroupService
{
    public Guid ProgramGroupServiceId { get; set; }

    public Guid GroupServiceId { get; set; }

    public Guid ProgramId { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupService { get; set; } = null!;

    public virtual CategoryProgram Program { get; set; } = null!;
}
