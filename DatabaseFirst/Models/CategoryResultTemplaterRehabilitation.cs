using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class CategoryResultTemplaterRehabilitation
{
    public Guid ResultTemplatedRehabilitationId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string ResultTemplatedRehabilitationCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string ResultTemplatedRehabilitationName { get; set; } = null!;

    /// <summary>
    /// phương pháp vô cảm
    /// </summary>
    public Guid? ResultTemplatedRehabilitationMethodAttributeId { get; set; }

    /// <summary>
    /// kết luận
    /// </summary>
    public string? ResultTemplatedRehabilitationResult { get; set; }

    /// <summary>
    /// chẩn đoán sau PTTT
    /// </summary>
    public string? ResultTemplatedRehabilitationLaterDiagnosis { get; set; }

    /// <summary>
    /// phương pháp PTTT
    /// </summary>
    public string? ResultTemplatedRehabilitationMethod { get; set; }

    /// <summary>
    /// Cách thức PTTT
    /// </summary>
    public string ResultTemplatedRehabilitationType { get; set; } = null!;

    public string? ResultTemplatedRehabilitationImage { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryAttribute? ResultTemplatedRehabilitationMethodAttribute { get; set; }
}
