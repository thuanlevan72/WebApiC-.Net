using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tài khoản
/// </summary>
public partial class CategoryAccount
{
    public Guid AccountId { get; set; }

    /// <summary>
    /// mã nhân viên
    /// </summary>
    public string? AccountCode { get; set; }

    /// <summary>
    /// ảnh đại diện
    /// </summary>
    public string? Avatar { get; set; }

    public Guid? EmployeeId { get; set; }

    /// <summary>
    /// tên đơn vị công tác
    /// </summary>
    public string? WorkName { get; set; }

    /// <summary>
    /// địa chỉ công tác
    /// </summary>
    public string? WorkAddress { get; set; }

    /// <summary>
    /// thời gian đăng xuất
    /// </summary>
    public int? LogoutTime { get; set; }

    /// <summary>
    /// số lần đăng nhập
    /// </summary>
    public int? LoginTime { get; set; }

    /// <summary>
    /// đăng nhập lần cuối
    /// </summary>
    public DateTime? LoginLast { get; set; }

    /// <summary>
    /// khóa
    /// </summary>
    public int? IsBlock { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// Tên đăng nhập
    /// </summary>
    public string AccountName { get; set; } = null!;

    /// <summary>
    /// mật khẩu
    /// </summary>
    public string? Password { get; set; }

    public virtual ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryBasicInformationPatient> CategoryBasicInformationPatients { get; set; } = new List<CategoryBasicInformationPatient>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlipApprovedAccountNavigations { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryCompensationSlip> CategoryCompensationSlipCreatedByNavigations { get; set; } = new List<CategoryCompensationSlip>();

    public virtual ICollection<CategoryDoctorDosage> CategoryDoctorDosages { get; set; } = new List<CategoryDoctorDosage>();

    public virtual ICollection<CategoryFinsishExamine> CategoryFinsishExamineAccountResultNavigations { get; set; } = new List<CategoryFinsishExamine>();

    public virtual ICollection<CategoryFinsishExamine> CategoryFinsishExamineAccounts { get; set; } = new List<CategoryFinsishExamine>();

    public virtual ICollection<CategoryHospitalDischargeInfomation> CategoryHospitalDischargeInfomations { get; set; } = new List<CategoryHospitalDischargeInfomation>();

    public virtual ICollection<CategoryKioskClinicDoctor> CategoryKioskClinicDoctors { get; set; } = new List<CategoryKioskClinicDoctor>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServiceAccountExamineNavigations { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServiceAccounts { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<CategoryPatientReceiptCode> CategoryPatientReceiptCodeAccountRequestNavigations { get; set; } = new List<CategoryPatientReceiptCode>();

    public virtual ICollection<CategoryPatientReceiptCode> CategoryPatientReceiptCodeAccounts { get; set; } = new List<CategoryPatientReceiptCode>();

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimateApprovedAccountNavigations { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimateCreatedByNavigations { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplyApprovedAccountNavigations { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategoryReceiptCodeSupply> CategoryReceiptCodeSupplyCreatedByNavigations { get; set; } = new List<CategoryReceiptCodeSupply>();

    public virtual ICollection<CategoryRefund> CategoryRefunds { get; set; } = new List<CategoryRefund>();

    public virtual ICollection<CategoryScreeningExamination> CategoryScreeningExaminations { get; set; } = new List<CategoryScreeningExamination>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<DesignateServicePrescriptionExamine> DesignateServicePrescriptionExamines { get; set; } = new List<DesignateServicePrescriptionExamine>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhaAccountApproveNavigations { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual ICollection<DocumentTemplateResultCdha> DocumentTemplateResultCdhaAccountReadNavigations { get; set; } = new List<DocumentTemplateResultCdha>();

    public virtual ICollection<DocumentTemplateResultLi> DocumentTemplateResultLis { get; set; } = new List<DocumentTemplateResultLi>();

    public virtual ICollection<DocumentTemplateResult> DocumentTemplateResults { get; set; } = new List<DocumentTemplateResult>();

    public virtual CategoryEmployee? Employee { get; set; }

    public virtual ICollection<InfomationDrugSupply> InfomationDrugSupplies { get; set; } = new List<InfomationDrugSupply>();

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecordOnlineDoctorNavigations { get; set; } = new List<PageTreatmentMedicalRecord>();

    public virtual ICollection<PageTreatmentMedicalRecord> PageTreatmentMedicalRecordTreatmentDoctorNavigations { get; set; } = new List<PageTreatmentMedicalRecord>();

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaAccountCreatedNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaAccountEpresentativeNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaAccountImplementNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaAccountReadNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaAccountReceptionNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhaNurseNavigations { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceDrug> PatientDesignateServiceDrugs { get; set; } = new List<PatientDesignateServiceDrug>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitationAccountCreatedNavigations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitationAccountOtherNavigations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceRehabilitation> PatientDesignateServiceRehabilitationAccountRehabilitationNavigations { get; set; } = new List<PatientDesignateServiceRehabilitation>();

    public virtual ICollection<PatientDesignateServiceSupply> PatientDesignateServiceSupplies { get; set; } = new List<PatientDesignateServiceSupply>();

    public virtual ICollection<PatientDesignateServiceVaccine> PatientDesignateServiceVaccines { get; set; } = new List<PatientDesignateServiceVaccine>();

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual ICollection<RegisterAppoiment> RegisterAppoiments { get; set; } = new List<RegisterAppoiment>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementAnesthesia1Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementAnesthesia2Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementAnestheticAdditive1Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementAnestheticAdditive2Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseNavigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseTool1Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseTool2Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseTool3Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseTool4Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementNurseTool5Navigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementOutpatientAnesthesiologistNavigations { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementOutpatientDoctors { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementSurgeons { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementSurgeons1s { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementSurgeons2s { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<SettingVaccine> SettingVaccineAccountDoctors { get; set; } = new List<SettingVaccine>();

    public virtual ICollection<SettingVaccine> SettingVaccineAccountNurses { get; set; } = new List<SettingVaccine>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementAnesthesia1Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementAnesthesia2Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementAnestheticAdditive1Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementAnestheticAdditive2Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementMachineMains { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementMachineSubs { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseNavigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseTool1Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseTool2Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseTool3Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseTool4Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementNurseTool5Navigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementOutpatientAnesthesiologistNavigations { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementOutpatientDoctors { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementSurgeons { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementSurgeons1s { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementSurgeons2s { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<SurgicalProceducesAccountImplement> SurgicalProceducesAccountImplementSurgeons3s { get; set; } = new List<SurgicalProceducesAccountImplement>();

    public virtual ICollection<TemplateOfDevelopmentsAccount> TemplateOfDevelopmentsAccounts { get; set; } = new List<TemplateOfDevelopmentsAccount>();

    public virtual ICollection<VitalSignsPid> VitalSignsPids { get; set; } = new List<VitalSignsPid>();

    public virtual ICollection<WarehouseAccount> WarehouseAccounts { get; set; } = new List<WarehouseAccount>();
}
