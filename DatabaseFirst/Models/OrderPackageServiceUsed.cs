using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chi tiêt người bệnh sử dụng
/// </summary>
public partial class OrderPackageServiceUsed
{
    public Guid OrderPackageServiceUsedId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int? Qty { get; set; }

    /// <summary>
    /// số lượng đã sử dụng
    /// </summary>
    public int? QtyUsed { get; set; }

    /// <summary>
    /// số lượng còn lại
    /// </summary>
    public int? QtyRemain { get; set; }

    /// <summary>
    /// số lượng trả về
    /// </summary>
    public int? QtyReturn { get; set; }

    /// <summary>
    /// phần trăm giảm giá
    /// </summary>
    public int? DiscountPercent { get; set; }

    /// <summary>
    /// dịch vụ giảm giá
    /// </summary>
    public decimal? ServiceDiscount { get; set; }

    /// <summary>
    /// gói giảm giá
    /// </summary>
    public decimal? PackageDiscount { get; set; }

    /// <summary>
    /// voucher giảm giá
    /// </summary>
    public decimal? VoucherDiscount { get; set; }

    /// <summary>
    /// ko tính tiền
    /// </summary>
    public int? IsNoCharge { get; set; }

    public int? IsPackageDiscount { get; set; }

    /// <summary>
    /// trạng thái
    /// </summary>
    public int? IsStatus { get; set; }

    /// <summary>
    /// hủy
    /// </summary>
    public int? IsCancel { get; set; }

    /// <summary>
    /// kết thúc
    /// </summary>
    public int? IsFinish { get; set; }

    public Guid? PatientPackageServiceId { get; set; }

    public Guid? ProductId { get; set; }

    public virtual PatientPackageService? PatientPackageService { get; set; }

    public virtual CategoryProduct? Product { get; set; }
}
