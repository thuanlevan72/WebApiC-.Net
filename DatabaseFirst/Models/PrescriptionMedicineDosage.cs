using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thuốc kê ngoài - liều dùng
/// </summary>
public partial class PrescriptionMedicineDosage
{
    public Guid PrescriptionMedicineDosageId { get; set; }

    public Guid PrescriptionMedicineId { get; set; }

    public Guid DosageId { get; set; }

    public virtual CategoryDosage Dosage { get; set; } = null!;

    public virtual CategoryPrescriptionMedicine PrescriptionMedicine { get; set; } = null!;
}
