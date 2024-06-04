using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục điều kiện thanh toán bảo hiểm
/// </summary>
public partial class CategoryTabInsurancePaymentCondition
{
    public Guid TabInsurancePaymentConditionsId { get; set; }

    /// <summary>
    /// Số lượng tối đa sử dụng trong 1 MHS
    /// </summary>
    public int MaximumQuantityUsedPerPatient { get; set; }

    /// <summary>
    /// Số lượng tối đa sử dụng trong 1 ngày
    /// </summary>
    public int MaximumQuantityUsedPerDay { get; set; }

    /// <summary>
    /// Số ngày được thực hiện lần tiếp theo
    /// </summary>
    public int NumberDayImplementNextTime { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<CdhatdcnTabInsurancePaymentCondition> CdhatdcnTabInsurancePaymentConditions { get; set; } = new List<CdhatdcnTabInsurancePaymentCondition>();

    public virtual ICollection<LaboratoryServiceTabInsurancePaymentConditon> LaboratoryServiceTabInsurancePaymentConditons { get; set; } = new List<LaboratoryServiceTabInsurancePaymentConditon>();

    public virtual ICollection<MedicalExaminationServiceTabInsurancePaymentCondition> MedicalExaminationServiceTabInsurancePaymentConditions { get; set; } = new List<MedicalExaminationServiceTabInsurancePaymentCondition>();

    public virtual ICollection<OutsiteOfTreatmentServiceInsurancePaymentCondition> OutsiteOfTreatmentServiceInsurancePaymentConditions { get; set; } = new List<OutsiteOfTreatmentServiceInsurancePaymentCondition>();

    public virtual ICollection<RehabilitationServiceTabInsurancePaymentConditon> RehabilitationServiceTabInsurancePaymentConditons { get; set; } = new List<RehabilitationServiceTabInsurancePaymentConditon>();

    public virtual ICollection<SurgicalProceduresServiceTabInsurancePaymentConditon> SurgicalProceduresServiceTabInsurancePaymentConditons { get; set; } = new List<SurgicalProceduresServiceTabInsurancePaymentConditon>();

    public virtual ICollection<TabInsurancePaymentConditionAttribute> TabInsurancePaymentConditionAttributes { get; set; } = new List<TabInsurancePaymentConditionAttribute>();
}
