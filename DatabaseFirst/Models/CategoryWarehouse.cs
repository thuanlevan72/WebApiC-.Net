using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin kho
/// </summary>
public partial class CategoryWarehouse
{
    public Guid WarehouseId { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    public string? GppCode { get; set; }

    public string? GppAccount { get; set; }

    public string? GppPassword { get; set; }

    public int IsNotUsed { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IsInsurance { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCost { get; set; }

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

    public int? IsNoTax { get; set; }

    public virtual ICollection<CategoryAffiliatedWarehouse> CategoryAffiliatedWarehouseAfiliateds { get; set; } = new List<CategoryAffiliatedWarehouse>();

    public virtual ICollection<CategoryAffiliatedWarehouse> CategoryAffiliatedWarehouseWarehouses { get; set; } = new List<CategoryAffiliatedWarehouse>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlipExportWarehouses { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlipOnlineWarehouses { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryInventory> CategoryInventories { get; set; } = new List<CategoryInventory>();

    public virtual ICollection<CategoryPrescriptionOrder> CategoryPrescriptionOrders { get; set; } = new List<CategoryPrescriptionOrder>();

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimateWarehouseExportNavigations { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimateWarehouseImportNavigations { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplyWarehouseExports { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplyWarehouseImports { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodeWarehouseFromNavigations { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodeWarehouseToNavigations { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryRetailSurplu> CategoryRetailSurplus { get; set; } = new List<CategoryRetailSurplu>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual CategoryDepartment? Department { get; set; }

    public virtual ICollection<DesignateServicePrescriptionExamine> DesignateServicePrescriptionExamines { get; set; } = new List<DesignateServicePrescriptionExamine>();

    public virtual ICollection<DesignationKitServiceWarehouse> DesignationKitServiceWarehouses { get; set; } = new List<DesignationKitServiceWarehouse>();

    public virtual ICollection<PatientDesignateServiceChemistry> PatientDesignateServiceChemistries { get; set; } = new List<PatientDesignateServiceChemistry>();

    public virtual ICollection<PatientDesignateServiceDrug> PatientDesignateServiceDrugs { get; set; } = new List<PatientDesignateServiceDrug>();

    public virtual ICollection<PatientDesignateServiceSupply> PatientDesignateServiceSupplies { get; set; } = new List<PatientDesignateServiceSupply>();

    public virtual ICollection<PatientDesignateServiceVaccine> PatientDesignateServiceVaccines { get; set; } = new List<PatientDesignateServiceVaccine>();

    public virtual ICollection<ProductSuppliesProductEstimate> ProductSuppliesProductEstimateWarehouseExportNavigations { get; set; } = new List<ProductSuppliesProductEstimate>();

    public virtual ICollection<ProductSuppliesProductEstimate> ProductSuppliesProductEstimateWarehouseImportNavigations { get; set; } = new List<ProductSuppliesProductEstimate>();

    public virtual ICollection<WarehouseAccount> WarehouseAccounts { get; set; } = new List<WarehouseAccount>();

    public virtual ICollection<WarehouseMechanismBrowerPay> WarehouseMechanismBrowerPays { get; set; } = new List<WarehouseMechanismBrowerPay>();

    public virtual ICollection<WarehouseMechanismEstimationCompensation> WarehouseMechanismEstimationCompensations { get; set; } = new List<WarehouseMechanismEstimationCompensation>();

    public virtual ICollection<WarehouseReserveBook> WarehouseReserveBooks { get; set; } = new List<WarehouseReserveBook>();

    public virtual ICollection<WarehouseWareHouseType> WarehouseWareHouseTypes { get; set; } = new List<WarehouseWareHouseType>();

    public virtual ICollection<WarehouseWarehousePropertite> WarehouseWarehousePropertites { get; set; } = new List<WarehouseWarehousePropertite>();
}
