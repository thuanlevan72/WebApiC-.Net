using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Phẫu thuật thủ thuật - Thông tin người thực hiện
/// </summary>
public partial class SurgicalProceducesAccountImplement
{
    public Guid SurgicalProcedureAccountImplementId { get; set; }

    /// <summary>
    /// dịch vụ phẫu thuật thủ thuật
    /// </summary>
    public Guid? PatientDesignateSurgicalProceduresId { get; set; }

    /// <summary>
    /// bác sĩ ngoại viện
    /// </summary>
    public Guid? OutpatientDoctorId { get; set; }

    /// <summary>
    /// bác sĩ gây mê ngoại viện
    /// </summary>
    public Guid? OutpatientAnesthesiologist { get; set; }

    /// <summary>
    /// phẫu thuật viên chính
    /// </summary>
    public Guid? SurgeonsId { get; set; }

    /// <summary>
    /// phẫu thuật viên 01
    /// </summary>
    public Guid? Surgeons1Id { get; set; }

    /// <summary>
    /// phẫu thuật viên 02
    /// </summary>
    public Guid? Surgeons2Id { get; set; }

    /// <summary>
    /// gây mê 01
    /// </summary>
    public Guid? Anesthesia1 { get; set; }

    /// <summary>
    /// gây mê 02
    /// </summary>
    public Guid? Anesthesia2 { get; set; }

    /// <summary>
    /// phụ gây mê 01
    /// </summary>
    public Guid? AnestheticAdditive1 { get; set; }

    /// <summary>
    /// phụ gây mê 02
    /// </summary>
    public Guid? AnestheticAdditive2 { get; set; }

    /// <summary>
    /// chạy máy chính
    /// </summary>
    public Guid? MachineMainId { get; set; }

    /// <summary>
    /// chạy máy phụ
    /// </summary>
    public Guid? MachineSubId { get; set; }

    /// <summary>
    /// y tá giúp việc
    /// </summary>
    public Guid? Nurse { get; set; }

    /// <summary>
    /// y tá dụng cụ 01
    /// </summary>
    public Guid? NurseTool1 { get; set; }

    /// <summary>
    /// y tá dụng cụ 02
    /// </summary>
    public Guid? NurseTool2 { get; set; }

    /// <summary>
    /// y tá dụng cụ 03
    /// </summary>
    public Guid? NurseTool3 { get; set; }

    /// <summary>
    /// y tá dụng cụ 04
    /// </summary>
    public Guid? NurseTool4 { get; set; }

    /// <summary>
    /// y tá dụng cụ 05
    /// </summary>
    public Guid? NurseTool5 { get; set; }

    public Guid? Surgeons3Id { get; set; }

    public virtual CategoryAccount? Anesthesia1Navigation { get; set; }

    public virtual CategoryAccount? Anesthesia2Navigation { get; set; }

    public virtual CategoryAccount? AnestheticAdditive1Navigation { get; set; }

    public virtual CategoryAccount? AnestheticAdditive2Navigation { get; set; }

    public virtual CategoryAccount? MachineMain { get; set; }

    public virtual CategoryAccount? MachineSub { get; set; }

    public virtual CategoryAccount? NurseNavigation { get; set; }

    public virtual CategoryAccount? NurseTool1Navigation { get; set; }

    public virtual CategoryAccount? NurseTool2Navigation { get; set; }

    public virtual CategoryAccount? NurseTool3Navigation { get; set; }

    public virtual CategoryAccount? NurseTool4Navigation { get; set; }

    public virtual CategoryAccount? NurseTool5Navigation { get; set; }

    public virtual CategoryAccount? OutpatientAnesthesiologistNavigation { get; set; }

    public virtual CategoryAccount? OutpatientDoctor { get; set; }

    public virtual PatientDesignateServiceSurgicalProceduce? PatientDesignateSurgicalProcedures { get; set; }

    public virtual CategoryAccount? Surgeons { get; set; }

    public virtual CategoryAccount? Surgeons1 { get; set; }

    public virtual CategoryAccount? Surgeons2 { get; set; }

    public virtual CategoryAccount? Surgeons3 { get; set; }
}
