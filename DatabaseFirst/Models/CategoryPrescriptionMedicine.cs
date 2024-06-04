using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thuốc kê ngoài
/// </summary>
public partial class CategoryPrescriptionMedicine
{
    public Guid PrescriptionMedicineId { get; set; }

    /// <summary>
    /// mã thuốc
    /// </summary>
    public string PrescriptionMedicineCode { get; set; } = null!;

    /// <summary>
    /// tên thuốc
    /// </summary>
    public string PrescriptionMedicineName { get; set; } = null!;

    /// <summary>
    /// id hoạt chất
    /// </summary>
    public Guid? ActiveElementId { get; set; }

    /// <summary>
    /// đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// đơn vị sử dụng
    /// </summary>
    public Guid UnitUsed { get; set; }

    /// <summary>
    /// hàm lượng
    /// </summary>
    public string Content { get; set; } = null!;

    /// <summary>
    /// quy cách
    /// </summary>
    public string Specifications { get; set; } = null!;

    /// <summary>
    /// nước sản xuất
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// phân loại thuốc
    /// </summary>
    public Guid? DrugClassificationId { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public string? AccountRevenue { get; set; }

    public string? AccountCostPrice { get; set; }

    public string? AccountCostMaterials { get; set; }

    public string? AccountIncomplete { get; set; }

    public string? AccountSupplies { get; set; }

    public virtual CategoryActiveElement? ActiveElement { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryDrugClassification? DrugClassification { get; set; }

    public virtual CategoryNational? National { get; set; }

    public virtual ICollection<PrescriptionMedicineDosage> PrescriptionMedicineDosages { get; set; } = new List<PrescriptionMedicineDosage>();

    public virtual CategoryUnit? Unit { get; set; }

    public virtual CategoryUnit UnitUsedNavigation { get; set; } = null!;
}
