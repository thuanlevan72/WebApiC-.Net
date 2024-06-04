using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class CategoryResultTemplateRehabilitation
{
    public Guid ResultTemplatedRehabilitationId { get; set; }

    public string ResultTemplatedRehabilitationCode { get; set; } = null!;

    public string ResultTemplatedRehabilitationName { get; set; } = null!;

    public Guid? ResultTemplatedRehabilitationMethodAttributeId { get; set; }

    public string? ResultTemplatedRehabilitationResult { get; set; }

    public string? ResultTemplatedRehabilitationLaterDiagnosis { get; set; }

    public string? ResultTemplatedRehabilitationMethod { get; set; }

    public string ResultTemplatedRehabilitationType { get; set; } = null!;

    public string? ResultTemplatedRehabilitationImage { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
