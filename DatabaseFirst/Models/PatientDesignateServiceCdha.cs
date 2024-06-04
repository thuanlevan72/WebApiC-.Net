using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// chi tiết cdha
/// </summary>
public partial class PatientDesignateServiceCdha
{
    public Guid PatientDesginateServiceCdhaId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    public int? IsStatus { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// phòng
    /// </summary>
    public Guid? RoomId { get; set; }

    public Guid? MachineId { get; set; }

    public int? IsPayment { get; set; }

    /// <summary>
    /// 1: đã gửi, 0: chưa gửi
    /// </summary>
    public int? IsPacs { get; set; }

    /// <summary>
    /// thời gian tạo
    /// </summary>
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// thời gian thực hiện
    /// </summary>
    public DateTime? TimeImplement { get; set; }

    /// <summary>
    /// thời gian tiếp nhận
    /// </summary>
    public DateTime? TimeReception { get; set; }

    public DateTime? TimeResult { get; set; }

    public Guid? AccountCreated { get; set; }

    public Guid? AccountImplement { get; set; }

    public Guid? AccountReception { get; set; }

    public Guid? Nurse { get; set; }

    public Guid? AccountRead { get; set; }

    public Guid? AccountEpresentative { get; set; }

    public Guid? IcdCode { get; set; }

    public Guid? CdhdTemplateId { get; set; }

    public string? Result { get; set; }

    /// <summary>
    /// thời gian có kết quả
    /// </summary>
    public string? Conclude { get; set; }

    public string? MethodOfIntervention { get; set; }

    public string? MethodIntervention { get; set; }

    public string? Suggest { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? ParenttId { get; set; }

    public int? CodePrint { get; set; }

    public int? IsIpd { get; set; }

    public virtual CategoryAccount? AccountCreatedNavigation { get; set; }

    public virtual CategoryAccount? AccountEpresentativeNavigation { get; set; }

    public virtual CategoryAccount? AccountImplementNavigation { get; set; }

    public virtual CategoryAccount? AccountReadNavigation { get; set; }

    public virtual CategoryAccount? AccountReceptionNavigation { get; set; }

    public virtual CategoryCdhatdcnresultTemplate? CdhdTemplate { get; set; }

    public virtual CategoryDepartment? Department { get; set; }

    public virtual CategoryDiseaseChapter? IcdCodeNavigation { get; set; }

    public virtual CategoryMachine? Machine { get; set; }

    public virtual CategoryAccount? NurseNavigation { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;

    public virtual CategoryRoom? Room { get; set; }
}
