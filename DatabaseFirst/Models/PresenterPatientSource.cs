using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Người giới thiệu - nguồn người bệnh
/// </summary>
public partial class PresenterPatientSource
{
    public Guid PresenterPatientSourceId { get; set; }

    public Guid PrensenterId { get; set; }

    public Guid PatientSourceId { get; set; }

    public virtual CategoryPatientSource PatientSource { get; set; } = null!;

    public virtual CategoryPresenter Prensenter { get; set; } = null!;
}
