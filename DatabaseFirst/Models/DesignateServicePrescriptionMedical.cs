using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ địng thuốc kê ngoài
/// </summary>
public partial class DesignateServicePrescriptionMedical
{
    public Guid DesignateServicePrescriptionMedicalId { get; set; }

    public string Title { get; set; } = null!;

    public string Data { get; set; } = null!;

    public int IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
