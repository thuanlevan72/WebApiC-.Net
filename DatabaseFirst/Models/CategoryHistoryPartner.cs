using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục lịch sử đối tác
/// </summary>
public partial class CategoryHistoryPartner
{
    public Guid HistoryPartnerId { get; set; }

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
    public string PhoneContact { get; set; } = null!;

    /// <summary>
    /// tên ngân hàng
    /// </summary>
    public string BankName { get; set; } = null!;

    /// <summary>
    /// Người chi cộng tác
    /// </summary>
    public string NameCollaborate { get; set; } = null!;

    /// <summary>
    /// SĐT người chi cộng tác
    /// </summary>
    public string PhoneCollaborate { get; set; } = null!;

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public DateTime ToDate { get; set; }

    /// <summary>
    /// địa chỉ
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// không gửi tên đơn vi
    /// </summary>
    public int IsNotSendUnit { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public string? AccountBankName { get; set; }

    public virtual ICollection<HistoryPartnerGroupService> HistoryPartnerGroupServices { get; set; } = new List<HistoryPartnerGroupService>();

    public virtual ICollection<HistoryPartnerTypeAtrribute> HistoryPartnerTypeAtrributes { get; set; } = new List<HistoryPartnerTypeAtrribute>();

    public virtual ICollection<HistoryPartnerTypeServiceAttribute> HistoryPartnerTypeServiceAttributes { get; set; } = new List<HistoryPartnerTypeServiceAttribute>();

    public virtual ICollection<PartnerHistoyPartner> PartnerHistoyPartners { get; set; } = new List<PartnerHistoyPartner>();
}
