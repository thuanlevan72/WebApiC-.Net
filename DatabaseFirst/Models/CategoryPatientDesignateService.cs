using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Chỉ định dich vụ
/// </summary>
public partial class CategoryPatientDesignateService
{
    public Guid PatientDesignateServiceId { get; set; }

    public Guid? ConceptId { get; set; }

    public Guid? PatientReceptionId { get; set; }

    /// <summary>
    /// Loai hình thanh toán
    /// </summary>
    public Guid? PaymentMethodId { get; set; }

    /// <summary>
    /// đơn giá bệnh viện
    /// </summary>
    public double? Price { get; set; }

    /// <summary>
    /// Người chỉ định
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// thời gian chỉ định
    /// </summary>
    public DateTime? DesignateServiceDate { get; set; }

    public DateTime? ImplementDate { get; set; }

    public int? IsNoCharge { get; set; }

    public int? IsPay { get; set; }

    public int? IsStatus { get; set; }

    public int? IsTt35 { get; set; }

    public string? Note { get; set; }

    public Guid? ProductId { get; set; }

    /// <summary>
    /// phòng thực hiện dịch vu
    /// </summary>
    public Guid? RoomId { get; set; }

    public int? Qty { get; set; }

    /// <summary>
    /// phòng chỉ định
    /// </summary>
    public Guid? RoomDesignateId { get; set; }

    /// <summary>
    /// số khám tên phòng + stt trong ngày
    /// </summary>
    public int? ExamineNumber { get; set; }

    public int PatientDesginateServiceCode { get; set; }

    public int? IsCheckin { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// đơn giá bảo hiểm
    /// </summary>
    public double? PriceInsurance { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// id gói chỉ định
    /// </summary>
    public Guid? DesignationKitId { get; set; }

    /// <summary>
    /// người thực hiện
    /// </summary>
    public Guid? AccountExamine { get; set; }

    /// <summary>
    /// 0: khám ban đầu 1 là khám chuyên khoa
    /// </summary>
    public int? IsSpecialist { get; set; }

    /// <summary>
    /// lý do hoàn
    /// </summary>
    public string? ReasonReturn { get; set; }

    /// <summary>
    /// 0: ngoại trú, 1: nội trú
    /// </summary>
    public int? IsIpd { get; set; }

    /// <summary>
    /// 0 = chưa tạo phiếu lĩnh, 1 = đã tao phiếu lĩnh
    /// </summary>
    public int? IsReceiptCode { get; set; }

    /// <summary>
    /// thời gian có kết quả
    /// </summary>
    public DateTime? TimeResult { get; set; }

    /// <summary>
    /// số lần
    /// </summary>
    public int? TimeNumber { get; set; }

    public double? Rate { get; set; }

    public double? PaymentServiceRatio { get; set; }

    public double? PaymentInsuranceRatio { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryAccount? AccountExamineNavigation { get; set; }

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();

    public virtual ICollection<CategoryScreeningExamination> CategoryScreeningExaminations { get; set; } = new List<CategoryScreeningExamination>();

    public virtual ICollection<CategoryServiceOfPackage> CategoryServiceOfPackages { get; set; } = new List<CategoryServiceOfPackage>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual CategoryDesignationKit? DesignationKit { get; set; }

    public virtual ICollection<DirectMedicalExamie> DirectMedicalExamieDirectPatientDesignateServices { get; set; } = new List<DirectMedicalExamie>();

    public virtual ICollection<DirectMedicalExamie> DirectMedicalExamiePatientDesignateServices { get; set; } = new List<DirectMedicalExamie>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhas { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual ICollection<DocumentTemplateResultLi> DocumentTemplateResultLis { get; set; } = new List<DocumentTemplateResultLi>();

    public virtual ICollection<DocumentTemplateResult> DocumentTemplateResults { get; set; } = new List<DocumentTemplateResult>();

    public virtual ICollection<PageTreamentPatientDesignateService> PageTreamentPatientDesignateServices { get; set; } = new List<PageTreamentPatientDesignateService>();

    public virtual ICollection<PatientAppointment> PatientAppointments { get; set; } = new List<PatientAppointment>();

    public virtual ICollection<PatientDesignateServiceBasicInformationPatient> PatientDesignateServiceBasicInformationPatients { get; set; } = new List<PatientDesignateServiceBasicInformationPatient>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceChemistry> PatientDesignateServiceChemistries { get; set; } = new List<PatientDesignateServiceChemistry>();

    public virtual ICollection<PatientDesignateServiceDetailSurgicalProceduce> PatientDesignateServiceDetailSurgicalProceduces { get; set; } = new List<PatientDesignateServiceDetailSurgicalProceduce>();

    public virtual ICollection<PatientDesignateServiceDinner> PatientDesignateServiceDinners { get; set; } = new List<PatientDesignateServiceDinner>();

    public virtual ICollection<PatientDesignateServiceDiseaseExplanationMicrobiology> PatientDesignateServiceDiseaseExplanationMicrobiologies { get; set; } = new List<PatientDesignateServiceDiseaseExplanationMicrobiology>();

    public virtual ICollection<PatientDesignateServiceDrug> PatientDesignateServiceDrugs { get; set; } = new List<PatientDesignateServiceDrug>();

    public virtual ICollection<PatientDesignateServiceLaboratory> PatientDesignateServiceLaboratories { get; set; } = new List<PatientDesignateServiceLaboratory>();

    public virtual ICollection<PatientDesignateServiceMoney> PatientDesignateServiceMoneys { get; set; } = new List<PatientDesignateServiceMoney>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceSupply> PatientDesignateServiceSupplies { get; set; } = new List<PatientDesignateServiceSupply>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientDesignateServiceVaccine> PatientDesignateServiceVaccines { get; set; } = new List<PatientDesignateServiceVaccine>();

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryPaymentMethod? PaymentMethod { get; set; }

    public virtual CategoryProduct? Product { get; set; }

    public virtual ICollection<ReceiptCodeDesignateServiceDiscount> ReceiptCodeDesignateServiceDiscounts { get; set; } = new List<ReceiptCodeDesignateServiceDiscount>();

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();

    public virtual CategoryRoom? Room { get; set; }

    public virtual CategoryRoom? RoomDesignate { get; set; }
}
