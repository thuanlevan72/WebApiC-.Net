using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục vật tư
/// </summary>
public partial class CategorySupply
{
    public Guid SuppliesId { get; set; }

    /// <summary>
    /// mã vật tư
    /// </summary>
    public string SuppliesCode { get; set; } = null!;

    /// <summary>
    /// tên vật tư
    /// </summary>
    public string SuppliesName { get; set; } = null!;

    /// <summary>
    /// nhóm vật tư
    /// </summary>
    public Guid? GroupMaterialId { get; set; }

    /// <summary>
    /// Mã ký hiệu - Tên thương mại
    /// </summary>
    public string? SymbolCode { get; set; }

    /// <summary>
    /// Đơn vị sơ cấp
    /// </summary>
    public Guid? UnitLvl1 { get; set; }

    /// <summary>
    /// Đơn vị thứ cấp
    /// </summary>
    public Guid? UnitLvl2 { get; set; }

    /// <summary>
    /// Hệ số định mức
    /// </summary>
    public int? RatingCoefficient { get; set; }

    public string? TechnicalSpecifications { get; set; }

    /// <summary>
    /// Quy cách
    /// </summary>
    public string? Specifications { get; set; }

    /// <summary>
    /// Nước sản xuất
    /// </summary>
    public Guid? CountriesSuppliesId { get; set; }

    /// <summary>
    /// Nhà sản xuất
    /// </summary>
    public Guid? ProducterId { get; set; }

    /// <summary>
    /// Nhà cung cấp
    /// </summary>
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Giá nhập
    /// </summary>
    public double? PriceImport { get; set; }

    /// <summary>
    /// Giá không bảo hiểm
    /// </summary>
    public double? PriceNonInsurance { get; set; }

    /// <summary>
    /// Giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// Phụ thu
    /// </summary>
    public double? Surcharge { get; set; }

    /// <summary>
    /// Trần bảo hiểm
    /// </summary>
    public double? InsuranceCeiling { get; set; }

    /// <summary>
    /// Tỷ lệ BH thanh toán
    /// </summary>
    public int? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// Tỷ lệ thanh toán dịch vụ
    /// </summary>
    public int? PaymentServiceRatio { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 1
    /// </summary>
    public Guid? GroupServiceLvl1 { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 2
    /// </summary>
    public Guid? GroupServiceLvl2 { get; set; }

    /// <summary>
    /// Nhóm dịch vụ cấp 1
    /// </summary>
    public Guid? GroupServiceLvl3 { get; set; }

    /// <summary>
    /// mã tương đương
    /// </summary>
    public string? EquivalentCode { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// quyết định thầu
    /// </summary>
    public string? BidDecision { get; set; }

    /// <summary>
    /// Số ngày cảnh báo HSD
    /// </summary>
    public int? NumberDayWarningExpired { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public Guid? ReceiptCode { get; set; }

    /// <summary>
    /// Vật tư bộ
    /// </summary>
    public int? IsKitSupplies { get; set; }

    /// <summary>
    /// Vật tư theo kích cỡ
    /// </summary>
    public int? IsSuppliesBySize { get; set; }

    /// <summary>
    /// Stent phủ thuốc
    /// </summary>
    public int? IsStent { get; set; }

    /// <summary>
    /// Kỹ thuật cao
    /// </summary>
    public int? IsHightech { get; set; }

    /// <summary>
    /// Không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    /// <summary>
    /// Vật tư tái sử dụng
    /// </summary>
    public int? IsSuppliesReuse { get; set; }

    /// <summary>
    /// Vật tư chạy máy
    /// </summary>
    public int? IsSuppliesMachine { get; set; }

    /// <summary>
    /// Thuộc phẫu thuật
    /// </summary>
    public int? IsSurgery { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    /// <summary>
    /// 1: bảo hiểm 0 : không bảo hiểm
    /// </summary>
    public int? IsInsurance { get; set; }

    /// <summary>
    /// mã hiệu vật tư
    /// </summary>
    public string? MaterialCode { get; set; }

    public int? IsRequestConsultation { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

    /// <summary>
    /// tài khoản vật tư
    /// </summary>
    public string? AccountSupplies { get; set; }

    /// <summary>
    /// tài khoản chi phí nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    /// <summary>
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    public int? IsYhct { get; set; }

    /// <summary>
    /// giá thuế
    /// </summary>
    public double? PriceTax { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryCountriesSupply? CountriesSupplies { get; set; }

    public virtual ICollection<DryingCostSupply> DryingCostSupplies { get; set; } = new List<DryingCostSupply>();

    public virtual CategoryGroupMaterial? GroupMaterial { get; set; }

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1Navigation { get; set; }

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2Navigation { get; set; }

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual CategoryPartner? Producter { get; set; }

    public virtual CategoryReceiptCode? ReceiptCodeNavigation { get; set; }

    public virtual CategoryPartner? Supplier { get; set; }

    public virtual ICollection<SuppliesCostGroup> SuppliesCostGroups { get; set; } = new List<SuppliesCostGroup>();

    public virtual ICollection<SuppliesKitSupply> SuppliesKitSupplies { get; set; } = new List<SuppliesKitSupply>();

    public virtual ICollection<SuppliesOtherPaymentSource> SuppliesOtherPaymentSources { get; set; } = new List<SuppliesOtherPaymentSource>();

    public virtual ICollection<SuppliesPurposeUse> SuppliesPurposeUses { get; set; } = new List<SuppliesPurposeUse>();

    public virtual ICollection<SuppliesSupplieBySize> SuppliesSupplieBySizes { get; set; } = new List<SuppliesSupplieBySize>();

    public virtual CategoryUnit? UnitLvl1Navigation { get; set; }

    public virtual CategoryUnit? UnitLvl2Navigation { get; set; }
}
