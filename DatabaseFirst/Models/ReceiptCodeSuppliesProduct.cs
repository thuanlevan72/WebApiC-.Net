using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu thu nhà cung cấp - hàng hóa
/// </summary>
public partial class ReceiptCodeSuppliesProduct
{
    public Guid ReceiptCodeSupplieProductId { get; set; }

    public Guid ReceiptCodeSuppliesId { get; set; }

    /// <summary>
    /// hàng hóa
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// số lượng
    /// </summary>
    public int Qty { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// giảm giá
    /// </summary>
    public double? Discount { get; set; }

    /// <summary>
    /// giá trước vat
    /// </summary>
    public double? BeforePriceVat { get; set; }

    public double? Vat { get; set; }

    /// <summary>
    /// don gia sau vat
    /// </summary>
    public double? AfterPriceVat { get; set; }

    /// <summary>
    /// đơn giá bh
    /// </summary>
    public double? PriceInsurance { get; set; }

    /// <summary>
    /// đơn giá bv
    /// </summary>
    public double? PriceSurance { get; set; }

    /// <summary>
    /// nhà sản xuất
    /// </summary>
    public Guid? PartnerId { get; set; }

    /// <summary>
    /// nước sản xuất
    /// </summary>
    public Guid? CountriesId { get; set; }

    /// <summary>
    /// phụ thu
    /// </summary>
    public double? Surcharge { get; set; }

    /// <summary>
    /// mã nhãn hiệu
    /// </summary>
    public string? LabelCode { get; set; }

    /// <summary>
    /// thặng dư bán lẻ
    /// </summary>
    public int? RetailSurplus { get; set; }

    public int? QtyRemain { get; set; }

    public Guid? ProductSuppliesProductEstimateId { get; set; }

    public virtual CategoryNational? Countries { get; set; }

    public virtual CategoryPartner? Partner { get; set; }

    public virtual CategoryProduct Product { get; set; } = null!;

    public virtual ProductSuppliesProductEstimate? ProductSuppliesProductEstimate { get; set; }

    public virtual ICollection<ProductSuppliesProductEstimate> ProductSuppliesProductEstimates { get; set; } = new List<ProductSuppliesProductEstimate>();

    public virtual ICollection<ReceiptCodeEstimateProduct> ReceiptCodeEstimateProducts { get; set; } = new List<ReceiptCodeEstimateProduct>();

    public virtual CategoryReceiptCodeSupply ReceiptCodeSupplies { get; set; } = null!;

    public virtual ICollection<ReceiptCodeSuppliesProductLot> ReceiptCodeSuppliesProductLots { get; set; } = new List<ReceiptCodeSuppliesProductLot>();
}
