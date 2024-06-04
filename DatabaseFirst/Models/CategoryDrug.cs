using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thuốc
/// </summary>
public partial class CategoryDrug
{
    public Guid DrugId { get; set; }

    /// <summary>
    /// mã thuốc
    /// </summary>
    public string DrugCode { get; set; } = null!;

    /// <summary>
    /// tên thuốc
    /// </summary>
    public string DrugName { get; set; } = null!;

    /// <summary>
    /// id hoạt chất
    /// </summary>
    public Guid ActiveElementId { get; set; }

    /// <summary>
    /// hàm lượng
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// nhóm thuốc
    /// </summary>
    public Guid? DrugGroupId { get; set; }

    /// <summary>
    /// phân nhóm thuốc
    /// </summary>
    public Guid? DrugGroupingId { get; set; }

    /// <summary>
    /// phân loại thuốc
    /// </summary>
    public Guid? DrugClassificationId { get; set; }

    /// <summary>
    /// đơn vị sơ cấp
    /// </summary>
    public Guid? UnitLvl1 { get; set; }

    /// <summary>
    /// đơn vị thứ cấp
    /// </summary>
    public Guid? UnitLvl2 { get; set; }

    /// <summary>
    /// hệ số định mức
    /// </summary>
    public int? RatingCoefficient { get; set; }

    /// <summary>
    /// đơn vị sủ dụng
    /// </summary>
    public Guid? UnitUsed { get; set; }

    /// <summary>
    /// dung tích
    /// </summary>
    public int? Capacity { get; set; }

    /// <summary>
    /// quy cách
    /// </summary>
    public string? Specifications { get; set; }

    /// <summary>
    /// id nước sản xuất
    /// </summary>
    public Guid? NationalId { get; set; }

    /// <summary>
    /// nhà sản xuất
    /// </summary>
    public Guid? ProducerId { get; set; }

    /// <summary>
    /// nhà cung cấp
    /// </summary>
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Giá sau VAT/ 1 ĐVT sơ cấp
    /// </summary>
    public double? PriceVat { get; set; }

    /// <summary>
    /// Tỷ lệ BH thanh toán
    /// </summary>
    public int? PaymentInsuranceRatio { get; set; }

    /// <summary>
    /// Tỷ lệ thanh toán dịch vụ
    /// </summary>
    public int? PaymentServiceRatio { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 2
    /// </summary>
    public Guid? GroupServiceLvl2 { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 3
    /// </summary>
    public Guid? GroupServiceLvl3 { get; set; }

    /// <summary>
    /// tên tương đương
    /// </summary>
    public string? EquivalentName { get; set; }

    /// <summary>
    /// số visa
    /// </summary>
    public string? VisaNumber { get; set; }

    /// <summary>
    /// mã liên thông dược quốcgia
    /// </summary>
    public string? NationalPhamarcyConnection { get; set; }

    /// <summary>
    /// đường dùng
    /// </summary>
    public Guid? RoutesId { get; set; }

    /// <summary>
    /// hướng dẫn sử dụng
    /// </summary>
    public string? UseGuidle { get; set; }

    /// <summary>
    /// mã atc
    /// </summary>
    public string? AtcCode { get; set; }

    /// <summary>
    /// nhóm thầu
    /// </summary>
    public Guid? GroupBidAttributeId { get; set; }

    /// <summary>
    /// gói thầu
    /// </summary>
    public Guid? PackageBidAttributeId { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public Guid? ReceiptId { get; set; }

    /// <summary>
    /// số ngày  cảnh báo hsd
    /// </summary>
    public int? NumberDayWarningExpired { get; set; }

    /// <summary>
    /// Loại làm tròn
    /// </summary>
    public Guid? RoundingTypeAttributeId { get; set; }

    /// <summary>
    /// phương pháp chế biến
    /// </summary>
    public Guid? ProcessingMethodId { get; set; }

    /// <summary>
    /// Dạng bào chế
    /// </summary>
    public string? DosageForms { get; set; }

    /// <summary>
    /// cho phép kê sl lẻ
    /// </summary>
    public int? IsAllowOddQtyListing { get; set; }

    /// <summary>
    /// theo dõi ngày sử dụng
    /// </summary>
    public int? IsFolowUseDay { get; set; }

    /// <summary>
    /// không tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    /// <summary>
    /// thuốc dấu sao
    /// </summary>
    public int? IsStarMedicine { get; set; }

    public int? IsTt30 { get; set; }

    /// <summary>
    /// thuộc phẫu thuật
    /// </summary>
    public int? IsSurgery { get; set; }

    public int? IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public string? BidDecision { get; set; }

    public int? IsInsurance { get; set; }

    public string? NumberRegister { get; set; }

    public string? ActiveElementRegister { get; set; }

    public Guid? CountryDrugId { get; set; }

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
    /// tài khoản dở dang
    /// </summary>
    public string? AccountIncomplete { get; set; }

    /// <summary>
    /// tài khoản chi phí nguyên vật liệu
    /// </summary>
    public string? AccountCostMaterials { get; set; }

    public int? IsYhct { get; set; }

    public virtual CategoryActiveElement ActiveElement { get; set; } = null!;

    public virtual ICollection<CategoryPrescriptionService> CategoryPrescriptionServices { get; set; } = new List<CategoryPrescriptionService>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryCountryDrug? CountryDrug { get; set; }

    public virtual ICollection<DoctorDosageDrug> DoctorDosageDrugs { get; set; } = new List<DoctorDosageDrug>();

    public virtual CategoryAttribute? DrugClassification { get; set; }

    public virtual ICollection<DrugCostGroup> DrugCostGroups { get; set; } = new List<DrugCostGroup>();

    public virtual ICollection<DrugDepartment> DrugDepartments { get; set; } = new List<DrugDepartment>();

    public virtual CategoryGroupDrug? DrugGroup { get; set; }

    public virtual CategoryDrugGrouping? DrugGrouping { get; set; }

    public virtual ICollection<DrugOtherSourcesPay> DrugOtherSourcesPays { get; set; } = new List<DrugOtherSourcesPay>();

    public virtual ICollection<DrugPurposeUsed> DrugPurposeUseds { get; set; } = new List<DrugPurposeUsed>();

    public virtual ICollection<DrugTabDosage> DrugTabDosages { get; set; } = new List<DrugTabDosage>();

    public virtual CategoryAttribute? GroupBidAttribute { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryGroupServiceLevel2? GroupServiceLvl2Navigation { get; set; }

    public virtual CategoryGroupServiceLevel3? GroupServiceLvl3Navigation { get; set; }

    public virtual CategoryNational? National { get; set; }

    public virtual CategoryPackageService? PackageBidAttribute { get; set; }

    public virtual CategoryAttribute? ProcessingMethod { get; set; }

    public virtual CategoryPartner? Producer { get; set; }

    public virtual CategoryReceiptCode? Receipt { get; set; }

    public virtual ICollection<ReceiptCodeDrug> ReceiptCodeDrugs { get; set; } = new List<ReceiptCodeDrug>();

    public virtual ICollection<ReportDrugInteractionsAtc1code> ReportDrugInteractionsAtc1codes { get; set; } = new List<ReportDrugInteractionsAtc1code>();

    public virtual ICollection<ReportDrugInteractionsAtc2code> ReportDrugInteractionsAtc2codes { get; set; } = new List<ReportDrugInteractionsAtc2code>();

    public virtual ICollection<ReportDrugInteractionsDrug1> ReportDrugInteractionsDrug1s { get; set; } = new List<ReportDrugInteractionsDrug1>();

    public virtual ICollection<ReportDrugInteractionsDrug2> ReportDrugInteractionsDrug2s { get; set; } = new List<ReportDrugInteractionsDrug2>();

    public virtual CategoryAttribute? RoundingTypeAttribute { get; set; }

    public virtual CategoryRoute? Routes { get; set; }

    public virtual CategoryPartner? Supplier { get; set; }

    public virtual CategoryUnit? UnitLvl1Navigation { get; set; }

    public virtual CategoryUnit? UnitLvl2Navigation { get; set; }

    public virtual CategoryUnit? UnitUsedNavigation { get; set; }
}
