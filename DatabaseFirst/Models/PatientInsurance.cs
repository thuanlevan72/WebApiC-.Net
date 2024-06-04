using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân- bảo hiểm y tế
/// </summary>
public partial class PatientInsurance
{
    public Guid InsuranceId { get; set; }

    /// <summary>
    /// số bh
    /// </summary>
    public string? InsuranceNumber { get; set; }

    /// <summary>
    /// mức hưởng
    /// </summary>
    public int? BenefitLevel { get; set; }

    public DateTime? InsuranceFrom { get; set; }

    public DateTime? InsuranceTo { get; set; }

    public string DiagnosisOfReferral { get; set; } = null!;

    public Guid? RegisterPlaceId { get; set; }

    public DateTime? TimeOf5Year { get; set; }

    public DateTime? CctFrom { get; set; }

    public DateTime? CctTo { get; set; }

    public string? InsuranceAddress { get; set; }

    public Guid? AreaId { get; set; }

    public int? IsExamineAgain { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? PatientId { get; set; }

    /// <summary>
    /// giấy chuyển tuyến
    /// </summary>
    public string? TranferPage { get; set; }

    /// <summary>
    /// đối tượng bảo hiểm
    /// </summary>
    public Guid? SubjectOfInsuranceId { get; set; }

    public string? NameTranferPage { get; set; }

    public string? FileNameAppointment { get; set; }

    public string? FileAppointment { get; set; }

    public Guid? ObjectExamine { get; set; }

    /// <summary>
    /// số giấy chuyển tuyến
    /// </summary>
    public string? TranferNumber { get; set; }

    /// <summary>
    /// từ ngày chuyển tuyến
    /// </summary>
    public DateTime? TranferFrom { get; set; }

    /// <summary>
    /// đến ngày chuyển tuyến
    /// </summary>
    public DateTime? TranferTo { get; set; }

    /// <summary>
    /// nơi chuyển tuyến
    /// </summary>
    public Guid? TranferPlace { get; set; }

    public virtual CategoryAttribute? Area { get; set; }

    public virtual CategoryAttribute? ObjectExamineNavigation { get; set; }

    public virtual CategoryPatient? Patient { get; set; }

    public virtual CategoryHospital? RegisterPlace { get; set; }

    public virtual CategorySubjectOfInsurance? SubjectOfInsurance { get; set; }

    public virtual CategoryHospital? TranferPlaceNavigation { get; set; }
}
