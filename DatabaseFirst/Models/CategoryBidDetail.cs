using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chi tiết thầu
/// </summary>
public partial class CategoryBidDetail
{
    public Guid BidDetailsId { get; set; }

    /// <summary>
    /// quyết định thầu
    /// </summary>
    public Guid BidServiceId { get; set; }

    /// <summary>
    /// mã hàng hóa trúng thầu
    /// </summary>
    public string WonBidProductCode { get; set; } = null!;

    /// <summary>
    /// Tên hàng hóa trúng thầu
    /// </summary>
    public string WobBidProductName { get; set; } = null!;

    /// <summary>
    /// mã hàng hóa đấu thầu
    /// </summary>
    public string BidProductCode { get; set; } = null!;

    /// <summary>
    /// số lượng thầu
    /// </summary>
    public int BidQty { get; set; }

    /// <summary>
    /// số lượng được phép mua
    /// </summary>
    public int BidBuyQty { get; set; }

    public decimal PriceVat { get; set; }

    /// <summary>
    /// đơn giá không bh
    /// </summary>
    public decimal? PriceNotInsurance { get; set; }

    /// <summary>
    /// Đơn giá bh
    /// </summary>
    public decimal PriceInsurance { get; set; }

    /// <summary>
    /// quy cách
    /// </summary>
    public string Specifications { get; set; } = null!;

    /// <summary>
    /// nhà cung cấp
    /// </summary>
    public Guid SupplierId { get; set; }

    /// <summary>
    /// nhóm chi phí
    /// </summary>
    public Guid CostGroupId { get; set; }

    /// <summary>
    /// tỷ lệ thanh toán bh
    /// </summary>
    public int InsurancePayRate { get; set; }

    /// <summary>
    /// ngưỡng thầu
    /// </summary>
    public string BidThreshold { get; set; } = null!;

    /// <summary>
    /// xuất xứ
    /// </summary>
    public Guid Origin { get; set; }

    /// <summary>
    /// số hợp đồng
    /// </summary>
    public string ContactNumber { get; set; } = null!;

    public Guid? UnitId { get; set; }

    /// <summary>
    /// mã ánh xạ
    /// </summary>
    public string MappingCode { get; set; } = null!;

    /// <summary>
    /// mã hiệu
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// nhóm vật tư
    /// </summary>
    public Guid? SupplieGroupId { get; set; }

    /// <summary>
    /// số lượng hàng hóa đã nhập
    /// </summary>
    public int? QtyImport { get; set; }

    /// <summary>
    /// Số lượng hàng đã trả lại NCC
    /// </summary>
    public int? QtyReturnSupplierId { get; set; }

    /// <summary>
    /// Số lượng hàng hóa còn lại
    /// </summary>
    public int? QtyRemain { get; set; }

    /// <summary>
    /// Mã ATC
    /// </summary>
    public string? AtcCode { get; set; }

    /// <summary>
    /// Phương pháp chế biến
    /// </summary>
    public Guid? ProcessingMethod { get; set; }

    /// <summary>
    /// Phương pháp chế biến Dạng bào chế
    /// </summary>
    public string? DosageForms { get; set; }

    public string Note { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// Nhà sản xuất
    /// </summary>
    public Guid? ProducterId { get; set; }

    public virtual ICollection<BidDetailBaseDeclaration> BidDetailBaseDeclarations { get; set; } = new List<BidDetailBaseDeclaration>();

    public virtual ICollection<BidDetailDiscountDeclaration> BidDetailDiscountDeclarations { get; set; } = new List<BidDetailDiscountDeclaration>();

    public virtual ICollection<BidDetailsProduct> BidDetailsProducts { get; set; } = new List<BidDetailsProduct>();

    public virtual CategoryBidService BidService { get; set; } = null!;

    public virtual CategoryCostGroup CostGroup { get; set; } = null!;

    public virtual CategoryOrigin OriginNavigation { get; set; } = null!;

    public virtual CategoryAttribute? ProcessingMethodNavigation { get; set; }

    public virtual CategoryPartner? Producter { get; set; }

    public virtual CategoryPartner Supplier { get; set; } = null!;

    public virtual CategoryUnit? Unit { get; set; }
}
