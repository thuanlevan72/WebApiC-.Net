using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách mã phiếu lĩnh
/// </summary>
public partial class CategoryReceiptCode
{
    public Guid ReceiptCodeId { get; set; }

    /// <summary>
    /// mã phiếu lĩnh
    /// </summary>
    public string ReceiptCodeCd { get; set; } = null!;

    /// <summary>
    /// tên phiếu lĩnh
    /// </summary>
    public char ReceptCodeName { get; set; }

    /// <summary>
    /// loại phiếu
    /// </summary>
    public Guid? ReceiptCodeType { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// loại hàng hóa
    /// </summary>
    public Guid? ConceptId { get; set; }

    /// <summary>
    /// đến  kho
    /// </summary>
    public Guid? WarehouseTo { get; set; }

    /// <summary>
    /// từ kho
    /// </summary>
    public Guid? WarehouseFrom { get; set; }

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// đến ngày
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// mã bệnh án
    /// </summary>
    public Guid? MedicalRecordTypeId { get; set; }

    /// <summary>
    /// 1: phiếu lĩnh, 2: phiếu trả
    /// </summary>
    public int? IsStatus { get; set; }

    public Guid? ReceiptCodeSuppliesId { get; set; }

    public virtual ICollection<CategoryChemistry> CategoryChemistries { get; set; } = new List<CategoryChemistry>();

    public virtual ICollection<CategoryDrug> CategoryDrugs { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategorySupply> CategorySupplies { get; set; } = new List<CategorySupply>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryTypeOfMedicalRecord? MedicalRecordType { get; set; }

    public virtual ICollection<PatientDesignateServiceChemistry> PatientDesignateServiceChemistries { get; set; } = new List<PatientDesignateServiceChemistry>();

    public virtual ICollection<PatientDesignateServiceDinner> PatientDesignateServiceDinnerReceiptCode2s { get; set; } = new List<PatientDesignateServiceDinner>();

    public virtual ICollection<PatientDesignateServiceDinner> PatientDesignateServiceDinnerReceiptCodes { get; set; } = new List<PatientDesignateServiceDinner>();

    public virtual ICollection<ReceiptCodeDrugClassification> ReceiptCodeDrugClassifications { get; set; } = new List<ReceiptCodeDrugClassification>();

    public virtual ICollection<ReceiptCodeDrug> ReceiptCodeDrugs { get; set; } = new List<ReceiptCodeDrug>();

    public virtual ICollection<ReceiptCodeRoom> ReceiptCodeRooms { get; set; } = new List<ReceiptCodeRoom>();

    public virtual CategoryReceiptCodeSupply? ReceiptCodeSupplies { get; set; }

    public virtual CategoryAttribute? ReceiptCodeTypeNavigation { get; set; }

    public virtual CategoryWarehouse? WarehouseFromNavigation { get; set; }

    public virtual CategoryWarehouse? WarehouseToNavigation { get; set; }
}
