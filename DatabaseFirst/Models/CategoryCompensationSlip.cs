using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phiễu lĩnh bù tủ trực
/// </summary>
public partial class CategoryCompensationSlip
{
    public Guid CompensationSlipId { get; set; }

    /// <summary>
    /// loại dịch vụ
    /// </summary>
    public Guid ConceptId { get; set; }

    /// <summary>
    /// khoa chỉ định
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// kho tủ trực
    /// </summary>
    public Guid? OnlineWarehouseId { get; set; }

    /// <summary>
    /// kho xuất
    /// </summary>
    public Guid? ExportWarehouseId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? PatientDesignateMedicalServiceId { get; set; }

    public string CompensationSlipCode { get; set; } = null!;

    public int? IsStatus { get; set; }

    public DateTime? ApproveDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public Guid? ApprovedAccount { get; set; }

    public Guid? PatientDesignateSuppliesServiceId { get; set; }

    public virtual CategoryAccount? ApprovedAccountNavigation { get; set; }

    public virtual ICollection<CategoryWarehouseList> CategoryWarehouseLists { get; set; } = new List<CategoryWarehouseList>();

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryAccount? CreatedByNavigation { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryWarehouse? ExportWarehouse { get; set; }

    public virtual CategoryWarehouse? OnlineWarehouse { get; set; }

    public virtual PatientDesignateServiceDrug? PatientDesignateMedicalService { get; set; }

    public virtual PatientDesignateServiceSupply? PatientDesignateSuppliesService { get; set; }
}
