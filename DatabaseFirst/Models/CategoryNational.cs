using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quốc gia
/// </summary>
public partial class CategoryNational
{
    public Guid NationalId { get; set; }

    /// <summary>
    /// mã quốc gia
    /// </summary>
    public string NationalCode { get; set; } = null!;

    /// <summary>
    /// tên quốc gia
    /// </summary>
    public string NationalName { get; set; } = null!;

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? NationalNameEn { get; set; }

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryCity> CategoryCities { get; set; } = new List<CategoryCity>();

    public virtual ICollection<CategoryDistrict> CategoryDistricts { get; set; } = new List<CategoryDistrict>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPrescriptionMedicine> CategoryPrescriptionMedicines { get; set; } = new List<CategoryPrescriptionMedicine>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual ICollection<CategoryWard> CategoryWards { get; set; } = new List<CategoryWard>();

    public virtual ICollection<ReceiptCodeSuppliesProduct> ReceiptCodeSuppliesProducts { get; set; } = new List<ReceiptCodeSuppliesProduct>();
}
