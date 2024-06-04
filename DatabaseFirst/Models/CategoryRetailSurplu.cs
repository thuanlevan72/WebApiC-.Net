using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thặng dư bán lẻ
/// </summary>
public partial class CategoryRetailSurplu
{
    public Guid RetailSurplusId { get; set; }

    /// <summary>
    /// Thặng số bán lẻ(%)
    /// </summary>
    public int RetailSurplusPercent { get; set; }

    /// <summary>
    /// id kho
    /// </summary>
    public Guid WarehouseId { get; set; }

    /// <summary>
    /// Giá nhập sau VAT nhỏ nhất
    /// </summary>
    public decimal? VatMin { get; set; }

    /// <summary>
    /// Giá nhập sau VAT lớn nhất
    /// </summary>
    public decimal? VatMax { get; set; }

    /// <summary>
    /// id phân loại thuốc
    /// </summary>
    public Guid? DrugClassificationId { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 1
    /// </summary>
    public Guid? GroupServiceLvl1 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 2
    /// </summary>
    public Guid? GroupServiceLvl2 { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangeBy { get; set; }

    public virtual CategoryDrugClassification? DrugClassification { get; set; }

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1Navigation { get; set; }

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2Navigation { get; set; }

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
