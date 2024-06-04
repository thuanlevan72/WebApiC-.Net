using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Template thuốc
/// </summary>
public partial class DocumentTemplateResultMedical
{
    public Guid DocumentTemplateResultMedicalId { get; set; }

    public Guid DocumentTemplateResultId { get; set; }

    public string Title { get; set; } = null!;

    public virtual DocumentTemplateResult DocumentTemplateResult { get; set; } = null!;
}
