using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách thuốc - Dơn thuốc
/// </summary>
public partial class CategoryPrescriptionService
{
    public Guid PerscriptionServiceId { get; set; }

    /// <summary>
    /// thông tin khách hàng
    /// </summary>
    public Guid PatientPrescriptionId { get; set; }

    public Guid DrugId { get; set; }

    public int Qty { get; set; }

    public decimal Price { get; set; }

    public decimal? Discount { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryDrug Drug { get; set; } = null!;

    public virtual CategoryPatientPrescription PatientPrescription { get; set; } = null!;
}
