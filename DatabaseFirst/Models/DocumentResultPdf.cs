using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kết quả xét nghiệm pdf
/// </summary>
public partial class DocumentResultPdf
{
    public Guid DocumentResultPdfId { get; set; }

    public Guid PatientReceptionId { get; set; }

    public string PdfData { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual CategoryPatientReception PatientReception { get; set; } = null!;
}
