using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiếu nhập nhà cung cấp
/// </summary>
public partial class CategoryReceiptCodeSupply
{
    public Guid ReceiptCodeSuppliesId { get; set; }

    /// <summary>
    /// nhà cung cấp
    /// </summary>
    public Guid? SuppliesId { get; set; }

    /// <summary>
    /// kho nhập
    /// </summary>
    public Guid? WarehouseImportId { get; set; }

    /// <summary>
    /// nguồn kho
    /// </summary>
    public Guid? WarehouseSourceId { get; set; }

    /// <summary>
    /// quyết định thầu
    /// </summary>
    public Guid? BidServiceId { get; set; }

    /// <summary>
    /// hình thức nhập
    /// </summary>
    public Guid? ReceiptMethodId { get; set; }

    /// <summary>
    /// số hóa đơn
    /// </summary>
    public string? BillNumber { get; set; }

    /// <summary>
    /// ngày hóa đơn
    /// </summary>
    public DateTime? BillDate { get; set; }

    /// <summary>
    /// ký hiệu
    /// </summary>
    public string? BillSymbol { get; set; }

    /// <summary>
    /// số hợp đồng
    /// </summary>
    public string? ContactNumber { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// 0 tạo mới 1 chờ duyệt 2 duyệt
    /// </summary>
    public int IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int IsActive { get; set; }

    /// <summary>
    /// csyt chuyển tới
    /// </summary>
    public Guid? Hospital { get; set; }

    /// <summary>
    /// số phiếu : yyMM + index  2311+ index
    /// </summary>
    public string? ReceiptCodeSuppliesCode { get; set; }

    /// <summary>
    /// người tạo phiếu
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// khoa tạo phiếu
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// ngày duyệt phiếu
    /// </summary>
    public DateTime? ApproveDate { get; set; }

    /// <summary>
    /// kho xuat
    /// </summary>
    public Guid? WarehouseExportId { get; set; }

    /// <summary>
    /// lý do
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// 1 nhập nhà cung cấp 2 phiếu thu khác
    /// </summary>
    public int? SuppliesType { get; set; }

    public DateTime? FinishDate { get; set; }

    public Guid? ApprovedAccount { get; set; }

    public Guid? PatientDesignateServiceDrugId { get; set; }

    public Guid? PatientDesignateServiceSuppliesId { get; set; }

    public Guid? PatientDesignateServiceChemistryId { get; set; }

    public string? ReceiptCodeSuppliesImportCode { get; set; }

    public Guid? PatientDesignateServiceVaccineId { get; set; }

    public double? PriceTax { get; set; }

    public double? Total { get; set; }

    public virtual CategoryAccount? ApprovedAccountNavigation { get; set; }

    public virtual CategoryBidService? BidService { get; set; }

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimates { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodes { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryWarehouseList> CategoryWarehouseLists { get; set; } = new List<CategoryWarehouseList>();

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual PatientDesignateServiceChemistry? PatientDesignateServiceChemistry { get; set; }

    public virtual PatientDesignateServiceDrug? PatientDesignateServiceDrug { get; set; }

    public virtual PatientDesignateServiceSupply? PatientDesignateServiceSupplies { get; set; }

    public virtual PatientDesignateServiceVaccine? PatientDesignateServiceVaccine { get; set; }

    public virtual ICollection<ReceiptCodeSuppliesProduct> ReceiptCodeSuppliesProducts { get; set; } = new List<ReceiptCodeSuppliesProduct>();

    public virtual CategoryInputOrOutputType? ReceiptMethod { get; set; }

    public virtual CategoryPartner? Supplies { get; set; }

    public virtual CategoryWarehouse? WarehouseExport { get; set; }

    public virtual CategoryWarehouse? WarehouseImport { get; set; }

    public virtual CategoryWarehouseSource? WarehouseSource { get; set; }
}
