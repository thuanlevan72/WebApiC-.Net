using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục khoa
/// </summary>
public partial class CategoryDepartment
{
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// mã khoa
    /// </summary>
    public string? DepartmentCode { get; set; }

    /// <summary>
    /// tên khoa
    /// </summary>
    public string? DepartmentName { get; set; }

    /// <summary>
    /// logo
    /// </summary>
    public string? DepartmentLogo { get; set; }

    /// <summary>
    /// tên viết tắt
    /// </summary>
    public string? Abbreviations { get; set; }

    /// <summary>
    /// mã bh
    /// </summary>
    public string? InsuranceCode { get; set; }

    /// <summary>
    /// loại bệnh án
    /// </summary>
    public Guid? TypeOfMedicalRecordId { get; set; }

    /// <summary>
    /// tên bh
    /// </summary>
    public string? InsuranceName { get; set; }

    /// <summary>
    /// giường thực tế
    /// </summary>
    public string? BedActual { get; set; }

    /// <summary>
    /// giường kế hoạch
    /// </summary>
    public string? BedPlan { get; set; }

    /// <summary>
    /// trần bảo hiểm
    /// </summary>
    public decimal? CeillingInsurance { get; set; }

    /// <summary>
    /// ngưỡng tạm ứng điều  trị
    /// </summary>
    public decimal? TreatmentAdvanceThreshold { get; set; }

    /// <summary>
    /// mô tả
    /// </summary>
    public string? DepartmentDesc { get; set; }

    /// <summary>
    /// duyệt phiếu trả
    /// </summary>
    public Guid? ApprovePaymentSlip { get; set; }

    /// <summary>
    /// Số lượng phòng mổ kế hoạch
    /// </summary>
    public int? NumberPlannedOperatingRooms { get; set; }

    /// <summary>
    /// thanh toán sau
    /// </summary>
    public int? IsLaterPay { get; set; }

    /// <summary>
    /// Tự động duyệt mượn NB
    /// </summary>
    public int? IsAutoApprove { get; set; }

    /// <summary>
    /// Chuyển khoa PTTT
    /// </summary>
    public int? IsDepartmentRedirect { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// tài khoản doanh thu
    /// </summary>
    public string? AccountRevenue { get; set; }

    /// <summary>
    /// tài khoản giá vốn
    /// </summary>
    public string? AccountCostPrice { get; set; }

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

    public virtual CategoryAttribute? ApprovePaymentSlipNavigation { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryBedNumber> CategoryBedNumbers { get; set; } = new List<CategoryBedNumber>();

    public virtual ICollection<CategoryBidService> CategoryBidServices { get; set; } = new List<CategoryBidService>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlips { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryCounter> CategoryCounters { get; set; } = new List<CategoryCounter>();

    public virtual ICollection<CategoryExamineCode> CategoryExamineCodes { get; set; } = new List<CategoryExamineCode>();

    public virtual ICollection<CategoryKiosk> CategoryKiosks { get; set; } = new List<CategoryKiosk>();

    public virtual ICollection<CategoryPlaceOfSamplingSpecimen> CategoryPlaceOfSamplingSpecimen { get; set; } = new List<CategoryPlaceOfSamplingSpecimen>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplies { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodes { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryRoom> CategoryRooms { get; set; } = new List<CategoryRoom>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouseDepartments { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouseDesignatedDepartments { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySettingBedChoose> CategorySettingBedChooses { get; set; } = new List<CategorySettingBedChoose>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<CategorySpeakerCalling> CategorySpeakerCallings { get; set; } = new List<CategorySpeakerCalling>();

    public virtual ICollection<CategoryTabImplementationRoom> CategoryTabImplementationRooms { get; set; } = new List<CategoryTabImplementationRoom>();

    public virtual ICollection<CategoryTabPriceOption> CategoryTabPriceOptions { get; set; } = new List<CategoryTabPriceOption>();

    public virtual ICollection<CategoryWarehouse> CategoryWarehouses { get; set; } = new List<CategoryWarehouse>();

    public virtual ICollection<DepartmentBorrow> DepartmentBorrowDepartBorrows { get; set; } = new List<DepartmentBorrow>();

    public virtual ICollection<DepartmentBorrow> DepartmentBorrowDepartments { get; set; } = new List<DepartmentBorrow>();

    public virtual ICollection<DepartmentBuildingMoney> DepartmentBuildingMoneys { get; set; } = new List<DepartmentBuildingMoney>();

    public virtual ICollection<DepartmentBuilding> DepartmentBuildings { get; set; } = new List<DepartmentBuilding>();

    public virtual ICollection<DepartmentFacultyNature> DepartmentFacultyNatures { get; set; } = new List<DepartmentFacultyNature>();

    public virtual ICollection<DesignationKitDesignatedFaculty> DesignationKitDesignatedFaculties { get; set; } = new List<DesignationKitDesignatedFaculty>();

    public virtual ICollection<DirectDepartment> DirectDepartmentDeparmentDirections { get; set; } = new List<DirectDepartment>();

    public virtual ICollection<DirectDepartment> DirectDepartmentDepartmentLeaves { get; set; } = new List<DirectDepartment>();

    public virtual ICollection<DrugDepartment> DrugDepartments { get; set; } = new List<DrugDepartment>();

    public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = new List<EmployeeDepartment>();

    public virtual ICollection<Hospitalize> Hospitalizes { get; set; } = new List<Hospitalize>();

    public virtual ICollection<MedicalExaminationServiceDepartmentAssign> MedicalExaminationServiceDepartmentAssigns { get; set; } = new List<MedicalExaminationServiceDepartmentAssign>();

    public virtual ICollection<PackageServiceDepartment> PackageServiceDepartments { get; set; } = new List<PackageServiceDepartment>();

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecords { get; set; } = new List<PageTreatmentMedicalRecord>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<RegisterAppoiment> RegisterAppoiments { get; set; } = new List<RegisterAppoiment>();

    public virtual ICollection<SurvivalIndexDepartment> SurvivalIndexDepartments { get; set; } = new List<SurvivalIndexDepartment>();

    public virtual ICollection<TemplateOfDevelopmentsDepartment> TemplateOfDevelopmentsDepartments { get; set; } = new List<TemplateOfDevelopmentsDepartment>();

    public virtual CategoryTypeOfMedicalRecord? TypeOfMedicalRecord { get; set; }
}
