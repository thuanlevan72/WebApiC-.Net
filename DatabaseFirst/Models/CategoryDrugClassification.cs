using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phân loại thuốc
/// </summary>
public partial class CategoryDrugClassification
{
    public Guid DrugClassificationId { get; set; }

    /// <summary>
    /// mã phân loại thuốc
    /// </summary>
    public string DrugClassificationCode { get; set; } = null!;

    /// <summary>
    /// tên phân loại thuốc
    /// </summary>
    public string DrugClassificationName { get; set; } = null!;

    /// <summary>
    /// loại đơn thuốc
    /// </summary>
    public Guid? PrescriptionTypeAttributeId { get; set; }

    /// <summary>
    /// yêu cầu đợt dùng
    /// </summary>
    public int IsUsedRequest { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicines { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryRetailSurplu> CategoryRetailSurplus { get; set; } = new List<CategoryRetailSurplu>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual CategoryAttribute? PrescriptionTypeAttribute { get; set; }

    public virtual ICollection<ReceiptCodeDrugClassification> ReceiptCodeDrugClassifications { get; set; } = new List<ReceiptCodeDrugClassification>();

    public virtual ICollection<ReceiptListDrugClassification> ReceiptListDrugClassifications { get; set; } = new List<ReceiptListDrugClassification>();
}
