using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// mẫu diễn biến - bác sĩ
/// </summary>
public partial class TemplateOfDevelopmentsAccount
{
    public Guid TemplateOfDevelopmentAccountId { get; set; }

    public Guid TemplateOfDevelopmentId { get; set; }

    public Guid AccountId { get; set; }

    public virtual CategoryAccount Account { get; set; } = null!;

    public virtual CategoryTemplateOfDevelopment TemplateOfDevelopment { get; set; } = null!;
}
