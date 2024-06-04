using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// danh mục vắc xin
/// </summary>
public partial class CategoryVaccine
{
    public Guid VaccineId { get; set; }

    /// <summary>
    /// mã vaccine
    /// </summary>
    public string VaccineCode { get; set; } = null!;

    /// <summary>
    /// tên vaccine
    /// </summary>
    public string VaccineName { get; set; } = null!;

    /// <summary>
    /// kháng nguyên
    /// </summary>
    public Guid? AntigenId { get; set; }

    /// <summary>
    /// mã tiêm chủng quốc gia
    /// </summary>
    public string? VaccinationManagementCode { get; set; }

    /// <summary>
    /// hàm lượng
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// nhóm dịch vụ cấp 1
    /// </summary>
    public Guid GroupServiceLvl1 { get; set; }

    /// <summary>
    /// số mũi cần tiêm
    /// </summary>
    public int? NumberOfInjectionsRequired { get; set; }

    /// <summary>
    /// liều lượng
    /// </summary>
    public string? Amount { get; set; }

    /// <summary>
    /// đơn vị tính
    /// </summary>
    public Guid? UnitId { get; set; }

    /// <summary>
    /// giá sau vat
    /// </summary>
    public double? PriceVat { get; set; }

    /// <summary>
    /// quy cách
    /// </summary>
    public string? Specifications { get; set; }

    /// <summary>
    /// đường dùng
    /// </summary>
    public Guid? RoutesId { get; set; }

    /// <summary>
    /// quốc gia
    /// </summary>
    public Guid? CountriesId { get; set; }

    /// <summary>
    /// nhà sản xuất
    /// </summary>
    public Guid? ProducterId { get; set; }

    /// <summary>
    /// giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// tên bệnh dự phòng
    /// </summary>
    public string? NameOfDiseasePrevention { get; set; }

    /// <summary>
    /// phân loại thuốc
    /// </summary>
    public Guid? DrugClassificationId { get; set; }

    public int IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public int? IsNoCharge { get; set; }

    public int? MinAgeOfUse { get; set; }

    public int? MaxAgeOfUse { get; set; }

    public Guid? ConceptId { get; set; }

    /// <summary>
    /// 1 bảo hiểm 0 không bảo hiểm
    /// </summary>
    public int? IsInsurance { get; set; }

    public string? AccountRevenue { get; set; }

    public string? AccountCostPrice { get; set; }

    public string? AccountCostMaterials { get; set; }

    public string? AccountIncomplete { get; set; }

    public string? AccountSupplies { get; set; }

    public double? Price { get; set; }

    public virtual CategoryAntigen? Antigen { get; set; }

    public virtual ICollection<CategoryInjectionAppointment> CategoryInjectionAppointments { get; set; } = new List<CategoryInjectionAppointment>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryNational? Countries { get; set; }

    public virtual CategoryDrugClassification? DrugClassification { get; set; }

    public virtual CategoryGroupServiceLevel1 GroupServiceLvl1Navigation { get; set; } = null!;

    public virtual CategoryPartner? Producter { get; set; }

    public virtual CategoryRoute? Routes { get; set; }

    public virtual CategoryUnit? Unit { get; set; }
}
