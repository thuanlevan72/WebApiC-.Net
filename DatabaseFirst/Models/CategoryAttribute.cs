using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục thuộc tính
/// </summary>
public partial class CategoryAttribute
{
    public Guid AttributeId { get; set; }

    public string AttributeName { get; set; } = null!;

    public int IsActive { get; set; }

    public Guid? AttributeTypeId { get; set; }

    public decimal? Price { get; set; }

    public string? AttributeCode { get; set; }

    public int? FormCode { get; set; }

    public int? TkNo { get; set; }

    public virtual CategoryAttributeType? AttributeType { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<BedServiceOtherSourcesPay> BedServiceOtherSourcesPays { get; set; } = new List<BedServiceOtherSourcesPay>();

    public virtual ICollection<BedServiceServiceList> BedServiceServiceLists { get; set; } = new List<BedServiceServiceList>();

    public virtual ICollection<BloodProductsOtherSourcesPay> BloodProductsOtherSourcesPays { get; set; } = new List<BloodProductsOtherSourcesPay>();

    public virtual ICollection<CategoryActiveElement> CategoryActiveElements { get; set; } = new List<CategoryActiveElement>();

    public virtual ICollection<CategoryAppoiment> CategoryAppoiments { get; set; } = new List<CategoryAppoiment>();

    public virtual ICollection<CategoryArea> CategoryAreaAreaTypeAttributes { get; set; } = new List<CategoryArea>();

    public virtual ICollection<CategoryArea> CategoryAreaObjectAttributes { get; set; } = new List<CategoryArea>();

    public virtual ICollection<CategoryArea> CategoryAreaObjectTypeAttributes { get; set; } = new List<CategoryArea>();

    public virtual ICollection<CategoryBedService> CategoryBedServices { get; set; } = new List<CategoryBedService>();

    public virtual ICollection<CategoryBidDetail> CategoryBidDetails { get; set; } = new List<CategoryBidDetail>();

    public virtual ICollection<CategoryBiosignal> CategoryBiosignals { get; set; } = new List<CategoryBiosignal>();

    public virtual ICollection<CategoryBloodProduct> CategoryBloodProducts { get; set; } = new List<CategoryBloodProduct>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcnClassificationSurgeryAttributes { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcnClsImplementUnitMedicals { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcnForms { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcnTechServiceTranferUnitMedicals { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcnUnitConnectAttributes { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryCouncilDetail> CategoryCouncilDetails { get; set; } = new List<CategoryCouncilDetail>();

    public virtual ICollection<CategoryCouncil> CategoryCouncils { get; set; } = new List<CategoryCouncil>();

    public virtual ICollection<CategoryDepartment> CategoryDepartments { get; set; } = new List<CategoryDepartment>();

    public virtual ICollection<CategoryDinner> CategoryDinners { get; set; } = new List<CategoryDinner>();

    public virtual ICollection<CategoryDrugClassification> CategoryDrugClassifications { get; set; } = new List<CategoryDrugClassification>();

    public virtual ICollection<CategoryDrug> CategoryDrugDrugClassifications { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugGroupBidAttributes { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugProcessingMethods { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryDrug> CategoryDrugRoundingTypeAttributes { get; set; } = new List<CategoryDrug>();

    public virtual ICollection<CategoryEmotionlessMethod> CategoryEmotionlessMethods { get; set; } = new List<CategoryEmotionlessMethod>();

    public virtual ICollection<CategoryGroupServiceLevel1> CategoryGroupServiceLevel1NumberGenerateStatusAttributes { get; set; } = new List<CategoryGroupServiceLevel1>();

    public virtual ICollection<CategoryGroupServiceLevel1> CategoryGroupServiceLevel1ServiceCompleteStatusAttributes { get; set; } = new List<CategoryGroupServiceLevel1>();

    public virtual ICollection<CategoryGroupServiceLevel1> CategoryGroupServiceLevel1ServiceTypeAttributes { get; set; } = new List<CategoryGroupServiceLevel1>();

    public virtual ICollection<CategoryGroupServiceLevel2> CategoryGroupServiceLevel2NumberGenerateStatuses { get; set; } = new List<CategoryGroupServiceLevel2>();

    public virtual ICollection<CategoryGroupServiceLevel2> CategoryGroupServiceLevel2ServiceCompleteStatusAttributes { get; set; } = new List<CategoryGroupServiceLevel2>();

    public virtual ICollection<CategoryGroupServiceLevel3> CategoryGroupServiceLevel3NumberGenerateStatusAttributes { get; set; } = new List<CategoryGroupServiceLevel3>();

    public virtual ICollection<CategoryGroupServiceLevel3> CategoryGroupServiceLevel3ServiceCompletedStatusAttributes { get; set; } = new List<CategoryGroupServiceLevel3>();

    public virtual ICollection<CategoryHospital> CategoryHospitalHospitalClassAttributes { get; set; } = new List<CategoryHospital>();

    public virtual ICollection<CategoryHospital> CategoryHospitalHospitalLineAttributes { get; set; } = new List<CategoryHospital>();

    public virtual ICollection<CategoryInputOrOutputType> CategoryInputOrOutputTypes { get; set; } = new List<CategoryInputOrOutputType>();

    public virtual ICollection<CategoryKiosk> CategoryKiosks { get; set; } = new List<CategoryKiosk>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServiceForms { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServiceSurgicalClassifications { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServiceUnitConnects { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryObjectType> CategoryObjectTypeExemptionTypeAttributes { get; set; } = new List<CategoryObjectType>();

    public virtual ICollection<CategoryObjectType> CategoryObjectTypeObjectAttributes { get; set; } = new List<CategoryObjectType>();

    public virtual ICollection<CategoryOutsiteOfTreatmentService> CategoryOutsiteOfTreatmentServices { get; set; } = new List<CategoryOutsiteOfTreatmentService>();

    public virtual ICollection<CategoryPatient> CategoryPatientIsIpdOrOpdNavigations { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatient> CategoryPatientObjectAttributes { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategoryPatientReception> CategoryPatientReceptions { get; set; } = new List<CategoryPatientReception>();

    public virtual ICollection<CategoryPatientSource> CategoryPatientSources { get; set; } = new List<CategoryPatientSource>();

    public virtual ICollection<CategoryPaymentMethod> CategoryPaymentMethodBillCodeAttributes { get; set; } = new List<CategoryPaymentMethod>();

    public virtual ICollection<CategoryPaymentMethod> CategoryPaymentMethodPamentMethodTypeAttributes { get; set; } = new List<CategoryPaymentMethod>();

    public virtual ICollection<CategoryPaymentMethod> CategoryPaymentMethodPartnerTypeAttributes { get; set; } = new List<CategoryPaymentMethod>();

    public virtual ICollection<CategoryPaymentType> CategoryPaymentTypes { get; set; } = new List<CategoryPaymentType>();

    public virtual ICollection<CategoryPlaceOfSamplingAttribute> CategoryPlaceOfSamplingAttributes { get; set; } = new List<CategoryPlaceOfSamplingAttribute>();

    public virtual ICollection<CategoryPrintType> CategoryPrintTypePaperDirectionAttributes { get; set; } = new List<CategoryPrintType>();

    public virtual ICollection<CategoryPrintType> CategoryPrintTypePaperSizeAttributes { get; set; } = new List<CategoryPrintType>();

    public virtual ICollection<CategoryPrintType> CategoryPrintTypePrintTypeIpNavigations { get; set; } = new List<CategoryPrintType>();

    public virtual ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

    public virtual ICollection<CategoryProgram> CategoryProgramExamptionFormAttributes { get; set; } = new List<CategoryProgram>();

    public virtual ICollection<CategoryProgram> CategoryProgramExamptionMethodAttributes { get; set; } = new List<CategoryProgram>();

    public virtual ICollection<CategoryProgram> CategoryProgramProgramTypeAttributes { get; set; } = new List<CategoryProgram>();

    public virtual ICollection<CategoryProgram> CategoryProgramServiceTypeAttributes { get; set; } = new List<CategoryProgram>();

    public virtual ICollection<CategoryQueue> CategoryQueueQmsTypeNavigations { get; set; } = new List<CategoryQueue>();

    public virtual ICollection<CategoryQueue> CategoryQueueRoomTypeNavigations { get; set; } = new List<CategoryQueue>();

    public virtual ICollection<CategoryReceiptCodeEstimate> CategoryReceiptCodeEstimates { get; set; } = new List<CategoryReceiptCodeEstimate>();

    public virtual ICollection<CategoryReceiptCode> CategoryReceiptCodes { get; set; } = new List<CategoryReceiptCode>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceClassificationRehabilitationServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceForms { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceSurgicalProceduresDivisions { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServiceUnitConnects { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategoryReport> CategoryReportFormAttributes { get; set; } = new List<CategoryReport>();

    public virtual ICollection<CategoryReport> CategoryReportFormatFileAttributes { get; set; } = new List<CategoryReport>();

    public virtual ICollection<CategoryReport> CategoryReportPaperOrientationAttributes { get; set; } = new List<CategoryReport>();

    public virtual ICollection<CategoryReport> CategoryReportPaperSizeAttributes { get; set; } = new List<CategoryReport>();

    public virtual ICollection<CategoryReport> CategoryReportPrintTypeAttributes { get; set; } = new List<CategoryReport>();

    public virtual ICollection<CategoryResultTemplateSurgery> CategoryResultTemplateSurgeries { get; set; } = new List<CategoryResultTemplateSurgery>();

    public virtual ICollection<CategoryResultTemplaterRehabilitation> CategoryResultTemplaterRehabilitations { get; set; } = new List<CategoryResultTemplaterRehabilitation>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySettingConditionDirectDepartment> CategorySettingConditionDirectDepartments { get; set; } = new List<CategorySettingConditionDirectDepartment>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual ICollection<CategorySpeakerCalling> CategorySpeakerCallingReceptionTypeNavigations { get; set; } = new List<CategorySpeakerCalling>();

    public virtual ICollection<CategorySpeakerCalling> CategorySpeakerCallingSpeakerCallingTypeNavigations { get; set; } = new List<CategorySpeakerCalling>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceClassificationSurgicalProcedures { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceForms { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceSurgicalProceduresDivisions { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServiceUnitConnects { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategoryTabAccompanyingService> CategoryTabAccompanyingServices { get; set; } = new List<CategoryTabAccompanyingService>();

    public virtual ICollection<CategoryTabCostGroup> CategoryTabCostGroups { get; set; } = new List<CategoryTabCostGroup>();

    public virtual ICollection<CategoryTemplateQm> CategoryTemplateQms { get; set; } = new List<CategoryTemplateQm>();

    public virtual ICollection<CategoryTypeScreeningForm> CategoryTypeScreeningForms { get; set; } = new List<CategoryTypeScreeningForm>();

    public virtual ICollection<CategoryWarehouseSource> CategoryWarehouseSources { get; set; } = new List<CategoryWarehouseSource>();

    public virtual CdhaAttribute? CdhaAttribute { get; set; }

    public virtual ICollection<CdhatdcnOtherSourcePay> CdhatdcnOtherSourcePays { get; set; } = new List<CdhatdcnOtherSourcePay>();

    public virtual ICollection<CdhatdcnServiceList> CdhatdcnServiceLists { get; set; } = new List<CdhatdcnServiceList>();

    public virtual ICollection<ChemistryOtherSourcesPayAttribute> ChemistryOtherSourcesPayAttributes { get; set; } = new List<ChemistryOtherSourcesPayAttribute>();

    public virtual ICollection<ChemistryPurposeCodeAttribute> ChemistryPurposeCodeAttributes { get; set; } = new List<ChemistryPurposeCodeAttribute>();

    public virtual ICollection<CounterCounterType> CounterCounterTypes { get; set; } = new List<CounterCounterType>();

    public virtual ICollection<DepartmentFacultyNature> DepartmentFacultyNatures { get; set; } = new List<DepartmentFacultyNature>();

    public virtual ICollection<DesignationKitServiceList> DesignationKitServiceLists { get; set; } = new List<DesignationKitServiceList>();

    public virtual ICollection<DocumentTemplateResult> DocumentTemplateResults { get; set; } = new List<DocumentTemplateResult>();

    public virtual ICollection<DrugOtherSourcesPay> DrugOtherSourcesPays { get; set; } = new List<DrugOtherSourcesPay>();

    public virtual ICollection<DrugPurposeUsed> DrugPurposeUseds { get; set; } = new List<DrugPurposeUsed>();

    public virtual ICollection<GroupServiceLevel1ServiceUnCompleteStatus> GroupServiceLevel1ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel1ServiceUnCompleteStatus>();

    public virtual ICollection<GroupServiceLevel2ServiceUnCompleteStatus> GroupServiceLevel2ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel2ServiceUnCompleteStatus>();

    public virtual ICollection<GroupServiceLevel3ServiceUnCompleteStatus> GroupServiceLevel3ServiceUnCompleteStatuses { get; set; } = new List<GroupServiceLevel3ServiceUnCompleteStatus>();

    public virtual ICollection<HistoryPartnerTypeAtrribute> HistoryPartnerTypeAtrributes { get; set; } = new List<HistoryPartnerTypeAtrribute>();

    public virtual ICollection<HistoryPartnerTypeServiceAttribute> HistoryPartnerTypeServiceAttributes { get; set; } = new List<HistoryPartnerTypeServiceAttribute>();

    public virtual ICollection<InputOrOutputTypeMethod> InputOrOutputTypeMethods { get; set; } = new List<InputOrOutputTypeMethod>();

    public virtual ICollection<LaboratoryAttribute> LaboratoryAttributes { get; set; } = new List<LaboratoryAttribute>();

    public virtual ICollection<LaboratoryServiceOtherSourcePay> LaboratoryServiceOtherSourcePays { get; set; } = new List<LaboratoryServiceOtherSourcePay>();

    public virtual ICollection<LaboratoryServiceServiceList> LaboratoryServiceServiceLists { get; set; } = new List<LaboratoryServiceServiceList>();

    public virtual ICollection<MedicalExaminationServiceOtherSourcePay> MedicalExaminationServiceOtherSourcePays { get; set; } = new List<MedicalExaminationServiceOtherSourcePay>();

    public virtual ICollection<MedicalExaminationServiceServiceList> MedicalExaminationServiceServiceLists { get; set; } = new List<MedicalExaminationServiceServiceList>();

    public virtual ICollection<OutsiteOfTreatmentServiceOtherSourcePay> OutsiteOfTreatmentServiceOtherSourcePays { get; set; } = new List<OutsiteOfTreatmentServiceOtherSourcePay>();

    public virtual ICollection<OutsiteOfTreatmentServiceServiceList> OutsiteOfTreatmentServiceServiceLists { get; set; } = new List<OutsiteOfTreatmentServiceServiceList>();

    public virtual ICollection<PartnerTypeAtrribute> PartnerTypeAtrributes { get; set; } = new List<PartnerTypeAtrribute>();

    public virtual ICollection<PartnerTypeServiceAttribute> PartnerTypeServiceAttributes { get; set; } = new List<PartnerTypeServiceAttribute>();

    public virtual ICollection<PatientAppointment> PatientAppointments { get; set; } = new List<PatientAppointment>();

    public virtual ICollection<PatientDesignateServiceDinner> PatientDesignateServiceDinners { get; set; } = new List<PatientDesignateServiceDinner>();

    public virtual ICollection<PatientDesignateServiceSupply> PatientDesignateServiceSupplies { get; set; } = new List<PatientDesignateServiceSupply>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduceClassificationSurgicalProcedures { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduceSurgicalTimeNavigations { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduceSurgicalTypeNavigations { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual ICollection<PatientInsurance> PatientInsuranceAreas { get; set; } = new List<PatientInsurance>();

    public virtual ICollection<PatientInsurance> PatientInsuranceObjectExamineNavigations { get; set; } = new List<PatientInsurance>();

    public virtual ICollection<PatientRelation> PatientRelations { get; set; } = new List<PatientRelation>();

    public virtual ICollection<PermissionAttribute> PermissionAttributes { get; set; } = new List<PermissionAttribute>();

    public virtual ICollection<QmstypeScreenKiosk> QmstypeScreenKiosks { get; set; } = new List<QmstypeScreenKiosk>();

    public virtual ICollection<RehabilitationOtherSourcePay> RehabilitationOtherSourcePays { get; set; } = new List<RehabilitationOtherSourcePay>();

    public virtual ICollection<RehabilitationServiceServiceList> RehabilitationServiceServiceLists { get; set; } = new List<RehabilitationServiceServiceList>();

    public virtual ICollection<RolePermisionGroupPermission> RolePermisionGroupPermissions { get; set; } = new List<RolePermisionGroupPermission>();

    public virtual ICollection<RoomTypeRooom> RoomTypeRoooms { get; set; } = new List<RoomTypeRooom>();

    public virtual ICollection<SetUpBedSelectionOtherSourcePay> SetUpBedSelectionOtherSourcePays { get; set; } = new List<SetUpBedSelectionOtherSourcePay>();

    public virtual ICollection<SettingBedChooseClassifySurgery> SettingBedChooseClassifySurgeries { get; set; } = new List<SettingBedChooseClassifySurgery>();

    public virtual ICollection<SuppliesOtherPaymentSource> SuppliesOtherPaymentSources { get; set; } = new List<SuppliesOtherPaymentSource>();

    public virtual ICollection<SuppliesPurposeUse> SuppliesPurposeUses { get; set; } = new List<SuppliesPurposeUse>();

    public virtual ICollection<SurgicalProcedureAttribute> SurgicalProcedureAttributes { get; set; } = new List<SurgicalProcedureAttribute>();

    public virtual ICollection<SurgicalProceduresServiceOtherSourcePay> SurgicalProceduresServiceOtherSourcePays { get; set; } = new List<SurgicalProceduresServiceOtherSourcePay>();

    public virtual ICollection<SurgicalProceduresServiceServiceList> SurgicalProceduresServiceServiceLists { get; set; } = new List<SurgicalProceduresServiceServiceList>();

    public virtual ICollection<TabAccompanyingServicesObjectType> TabAccompanyingServicesObjectTypes { get; set; } = new List<TabAccompanyingServicesObjectType>();

    public virtual ICollection<TabInsurancePaymentConditionAttribute> TabInsurancePaymentConditionAttributes { get; set; } = new List<TabInsurancePaymentConditionAttribute>();

    public virtual ICollection<TabPriceOptionAttribute> TabPriceOptionAttributes { get; set; } = new List<TabPriceOptionAttribute>();

    public virtual ICollection<WarehouseMechanismBrowerPay> WarehouseMechanismBrowerPays { get; set; } = new List<WarehouseMechanismBrowerPay>();

    public virtual ICollection<WarehouseMechanismEstimationCompensation> WarehouseMechanismEstimationCompensations { get; set; } = new List<WarehouseMechanismEstimationCompensation>();

    public virtual ICollection<WarehouseReserveBook> WarehouseReserveBooks { get; set; } = new List<WarehouseReserveBook>();

    public virtual ICollection<WarehouseWarehousePropertite> WarehouseWarehousePropertites { get; set; } = new List<WarehouseWarehousePropertite>();
}
