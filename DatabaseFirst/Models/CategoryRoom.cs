using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục phòng
/// </summary>
public partial class CategoryRoom
{
    public Guid RoomId { get; set; }

    /// <summary>
    /// mã phòng
    /// </summary>
    public string? RoomCode { get; set; }

    /// <summary>
    /// tên phòng
    /// </summary>
    public string? RoomName { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// chuyên khoa
    /// </summary>
    public Guid? SpecialistId { get; set; }

    /// <summary>
    /// nhà
    /// </summary>
    public Guid? BuildingId { get; set; }

    /// <summary>
    /// địa chỉ
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// thời gian trung bình
    /// </summary>
    public int? TimeAvg { get; set; }

    /// <summary>
    /// khu vực
    /// </summary>
    public Guid? AreaId { get; set; }

    /// <summary>
    /// nội trú
    /// </summary>
    public int? IsIpd { get; set; }

    /// <summary>
    /// ngoại trú
    /// </summary>
    public int? IsOpd { get; set; }

    /// <summary>
    /// mặc định
    /// </summary>
    public int? IsDefault { get; set; }

    /// <summary>
    /// check in qms
    /// </summary>
    public int? IsQmsCheckin { get; set; }

    /// <summary>
    /// ngoại viện
    /// </summary>
    public int? IsExternalHospital { get; set; }

    /// <summary>
    /// đặt khám online
    /// </summary>
    public int? IsOnline { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CategoryArea? Area { get; set; }

    public virtual CategoryBuilding? Building { get; set; }

    public virtual ICollection<Category10daySurgeryPackage> Category10daySurgeryPackages { get; set; } = new List<Category10daySurgeryPackage>();

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();

    public virtual ICollection<CategoryBedNumber> CategoryBedNumbers { get; set; } = new List<CategoryBedNumber>();

    public virtual ICollection<CategoryDesignationKitService> CategoryDesignationKitServices { get; set; } = new List<CategoryDesignationKitService>();

    public virtual ICollection<CategoryHospitalDischargeInfomation> CategoryHospitalDischargeInfomations { get; set; } = new List<CategoryHospitalDischargeInfomation>();

    public virtual ICollection<CategoryKioskClinicDoctor> CategoryKioskClinicDoctors { get; set; } = new List<CategoryKioskClinicDoctor>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServiceRoomDesignates { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServiceRooms { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryPlaceOfSamplingSpecimen> CategoryPlaceOfSamplingSpecimen { get; set; } = new List<CategoryPlaceOfSamplingSpecimen>();

    public virtual ICollection<CategoryRoomBed> CategoryRoomBeds { get; set; } = new List<CategoryRoomBed>();

    public virtual ICollection<CategoryServiceOfPackage> CategoryServiceOfPackages { get; set; } = new List<CategoryServiceOfPackage>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CdhatdcnlistChangeService> CdhatdcnlistChangeServices { get; set; } = new List<CdhatdcnlistChangeService>();

    public virtual CategoryDepartment? Department { get; set; }

    public virtual ICollection<DirectMedicalExamie> DirectMedicalExamieRoomDirects { get; set; } = new List<DirectMedicalExamie>();

    public virtual ICollection<DirectMedicalExamie> DirectMedicalExamieRooms { get; set; } = new List<DirectMedicalExamie>();

    public virtual ICollection<EmployeeDepartmentRoom> EmployeeDepartmentRooms { get; set; } = new List<EmployeeDepartmentRoom>();

    public virtual ICollection<Hospitalize> Hospitalizes { get; set; } = new List<Hospitalize>();

    public virtual ICollection<MedicalRecordRoomBed> MedicalRecordRoomBeds { get; set; } = new List<MedicalRecordRoomBed>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<ReceiptCodeRoom> ReceiptCodeRooms { get; set; } = new List<ReceiptCodeRoom>();

    public virtual ICollection<ResultAppoimentBasicInformationPatient> ResultAppoimentBasicInformationPatients { get; set; } = new List<ResultAppoimentBasicInformationPatient>();

    public virtual ICollection<RoomTypeRooom> RoomTypeRoooms { get; set; } = new List<RoomTypeRooom>();

    public virtual CategorySpecialist? Specialist { get; set; }

    public virtual ICollection<TabImplementationRoomsRoom> TabImplementationRoomsRooms { get; set; } = new List<TabImplementationRoomsRoom>();

    public virtual ICollection<TemplateOfDevelopmentsRoom> TemplateOfDevelopmentsRooms { get; set; } = new List<TemplateOfDevelopmentsRoom>();
}
