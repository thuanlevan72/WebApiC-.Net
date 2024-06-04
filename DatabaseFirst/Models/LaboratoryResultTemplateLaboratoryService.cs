using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// mẫu kết quả khám - dịch vụ
/// </summary>
public partial class LaboratoryResultTemplateLaboratoryService
{
    public Guid LaboratoryResultTeamplateLaboratoryId { get; set; }

    public Guid LaboratoryResultTeamplateId { get; set; }

    public Guid LaboratoryServiceId { get; set; }

    public virtual CategoryLaboratoryResultTemplate LaboratoryResultTeamplate { get; set; } = null!;

    public virtual CategoryLaboratoryService LaboratoryService { get; set; } = null!;
}
