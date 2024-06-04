using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục hóa chất
/// </summary>
public partial class CategoryChemistry
{
    public Guid ChemistriesId { get; set; }

    /// <summary>
    /// mã hóa chất
    /// </summary>
    public string ChemistriesCode { get; set; } = null!;

    /// <summary>
    /// Tên hóa chất
    /// </summary>
    public string ChemistriesName { get; set; } = null!;

    /// <summary>
    /// id nhóm hóa chất
    /// </summary>
    public Guid? GroupChemistriesId { get; set; }

    /// <summary>
    /// id đơn vị
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// id nước sản xuất
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// id nhà sản xuất
    /// </summary>
    public Guid? ProducerId { get; set; }

    /// <summary>
    /// id nhà cung cấp
    /// </summary>
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// quy cách
    /// </summary>
    public string? Specifications { get; set; }

    /// <summary>
    /// giá nhập
    /// </summary>
    public decimal? ImportPrice { get; set; }

    /// <summary>
    /// giá trần
    /// </summary>
    public decimal? CeilingPrice { get; set; }

    /// <summary>
    /// trần bảo hiểm
    /// </summary>
    public decimal? InsuranceCeilingPrice { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán bảo hiểm
    /// </summary>
    public int? InsurancePaymentRatio { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán dịch vụ
    /// </summary>
    public int ServicePaymentRatio { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 2
    /// </summary>
    public Guid GroupServiceLvl2 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 3
    /// </summary>
    public Guid? GroupServiceLvl3 { get; set; }

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// quyết định thầu
    /// </summary>
    public string? BidDecision { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// số ngày cảnh báo hsd
    /// </summary>
    public int? NumberDayWarningExpired { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public Guid? ReceiptCodeId { get; set; }

    /// <summary>
    /// không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public int? IsInsurance { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

    /// <summary>
    /// tài khoản chi phí nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    /// <summary>
    /// tài khoản vật tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    public int? IsYhct { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual ICollection<ChemistryOtherSourcesPayAttribute> ChemistryOtherSourcesPayAttributes { get; set; } = new List<ChemistryOtherSourcesPayAttribute>();

    public virtual ICollection<ChemistryPurposeCodeAttribute> ChemistryPurposeCodeAttributes { get; set; } = new List<ChemistryPurposeCodeAttribute>();

    public virtual ICollection<ChemistyCostGroup> ChemistyCostGroups { get; set; } = new List<ChemistyCostGroup>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryGroupChemistry? GroupChemistries { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2 GroupServiceLvl2Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual CategoryNational? National { get; set; }

    public virtual CategoryPartner? Producer { get; set; }

    public virtual CategoryReceiptCode? ReceiptCode { get; set; }

    public virtual CategoryPartner? Supplier { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
