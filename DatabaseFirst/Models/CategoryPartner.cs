using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục đối tác
/// </summary>
public partial class CategoryPartner
{
    public Guid PartnerId { get; set; }

    /// <summary>
    /// mã đối tác
    /// </summary>
    public string PartnerCode { get; set; } = null!;

    /// <summary>
    /// tên đối tác
    /// </summary>
    public string PartnerName { get; set; } = null!;

    /// <summary>
    /// mã số thuế
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// số tài khoản
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// người đại diện
    /// </summary>
    public string? Representative { get; set; }

    /// <summary>
    /// hạn mức quỹ
    /// </summary>
    public decimal? FundLimit { get; set; }

    /// <summary>
    /// tiền đã sử dụng
    /// </summary>
    public decimal? MoneyUsed { get; set; }

    /// <summary>
    /// chức vụ người đại diện
    /// </summary>
    public string? RepresentativePosition { get; set; }

    /// <summary>
    /// số điện thoại người đơn vị
    /// </summary>
    public string? RepresentativePhone { get; set; }

    /// <summary>
    /// tên người đầu mối
    /// </summary>
    public string? NameContact { get; set; }

    /// <summary>
    /// email người đầu mối
    /// </summary>
    public string? EmailContact { get; set; }

    /// <summary>
    /// số điện thoại người đầu mối
    /// </summary>
    public string? PhoneContact { get; set; }

    /// <summary>
    /// tên ngân hàng
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Người chi cộng tác
    /// </summary>
    public string? NameCollaborate { get; set; }

    /// <summary>
    /// SĐT người chi cộng tác
    /// </summary>
    public string? PhoneCollaborate { get; set; }

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// địa chỉ
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// không gửi tên đơn vi
    /// </summary>
    public int? IsNotSendUnit { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public string? AccountBankName { get; set; }

    public virtual ICollection<CategoryBidDetail> CategoryBidDetailProducters { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryBidDetail> CategoryBidDetailSuppliers { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryChemistry> CategoryChemistryProducers { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryChemistry> CategoryChemistrySuppliers { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDrug> CategoryDrugProducers { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugSuppliers { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryPaymentMethod> CategoryPaymentMethods { get; set; } = new List<CategoryPaymentMethod>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategorySupply> CategorySupplyProducters { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategorySupply> CategorySupplySuppliers { get; set; } = new List<CategorySupply>();

    public virtual ICollection<CategoryVaccine> CategoryVaccines { get; set; } = new List<CategoryVaccine>();

    public virtual ICollection<PartnerChildPartner> PartnerChildPartners { get; set; } = new List<PartnerChildPartner>();

    public virtual ICollection<PartnerGroupService> PartnerGroupServices { get; set; } = new List<PartnerGroupService>();

    public virtual ICollection<PartnerHistoyPartner> PartnerHistoyPartners { get; set; } = new List<PartnerHistoyPartner>();

    public virtual ICollection<PartnerTypeAtrribute> PartnerTypeAtrributes { get; set; } = new List<PartnerTypeAtrribute>();

    public virtual ICollection<PartnerTypeServiceAttribute> PartnerTypeServiceAttributes { get; set; } = new List<PartnerTypeServiceAttribute>();

    public virtual ICollection<ReceiptCodeSuppliesProduct> ReceiptCodeSuppliesProducts { get; set; } = new List<ReceiptCodeSuppliesProduct>();
}
