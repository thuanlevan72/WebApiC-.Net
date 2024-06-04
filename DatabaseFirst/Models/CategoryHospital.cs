using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục bệnh viện
/// </summary>
public partial class CategoryHospital
{
    public Guid HospitalId { get; set; }

    /// <summary>
    /// mã bệnh viện
    /// </summary>
    public string HospitalCode { get; set; } = null!;

    /// <summary>
    /// tên bệnh viện
    /// </summary>
    public string HospitalName { get; set; } = null!;

    /// <summary>
    /// tuyến bệnh viện
    /// </summary>
    public Guid HospitalLineAttributeId { get; set; }

    /// <summary>
    /// hạng bệnh viện
    /// </summary>
    public Guid HospitalClassAttributeId { get; set; }

    /// <summary>
    /// thành phố
    /// </summary>
    public Guid? CityId { get; set; }

    /// <summary>
    /// địa chỉ bệnh viện
    /// </summary>
    public string HospitalAddress { get; set; } = null!;

    /// <summary>
    /// ghi chú
    /// </summary>
    public string Note { get; set; } = null!;

    /// <summary>
    /// logo
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// Ảnh bản quyền thương hiệu
    /// </summary>
    public string? LogoBranch { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CategoryBedService> CategoryBedServiceClsImplementUnitMedicals { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBedService> CategoryBedServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryHospitalDischargeInfomation> CategoryHospitalDischargeInfomations { get; set; } = new List<CategoryHospitalDischargeInfomation>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServiceClsImplementUnitMedicals { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServiceClsImplementUnitMedicals { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryMedicalExaminationService> CategoryMedicalExaminationServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategoryMedicalExaminationService>();

    public virtual ICollection<CategoryOutpatientDoctor> CategoryOutpatientDoctors { get; set; } = new List<CategoryOutpatientDoctor>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServiceClsImplementUnitMedicals { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceClsImplementUnitMedicals { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceClsImplementUnitMedicals { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceTechServiceTranferUnitMedicals { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual CategoryCity? City { get; set; }

    public virtual ICollection<DirectHospitalize> DirectHospitalizeHospital3Navigations { get; set; } = new List<DirectHospitalize>();

    public virtual ICollection<DirectHospitalize> DirectHospitalizeHospitalId2Navigations { get; set; } = new List<DirectHospitalize>();

    public virtual ICollection<DirectHospitalize> DirectHospitalizeHospitals { get; set; } = new List<DirectHospitalize>();

    public virtual CategoryAttribute HospitalClassAttribute { get; set; } = null!;

    public virtual CategoryAttribute HospitalLineAttribute { get; set; } = null!;

    public virtual ICollection<PatientInsurance> PatientInsuranceRegisterPlaces { get; set; } = new List<PatientInsurance>();

    public virtual ICollection<PatientInsurance> PatientInsuranceTranferPlaceNavigations { get; set; } = new List<PatientInsurance>();
}
