using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mã máy
/// </summary>
public partial class CategoryMachine
{
    public Guid MachineId { get; set; }

    /// <summary>
    /// mã máy
    /// </summary>
    public string MachineCode { get; set; } = null!;

    /// <summary>
    /// tên máy
    /// </summary>
    public string MachineName { get; set; } = null!;

    /// <summary>
    /// Mã máy gửi BHYT
    /// </summary>
    public string InsuranceSendCode { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();

    public virtual ICollection<PatientDesignateServiceDiseaseExplanationMicrobiology> PatientDesignateServiceDiseaseExplanationMicrobiologies { get; set; } = new List<PatientDesignateServiceDiseaseExplanationMicrobiology>();

    public virtual ICollection<PatientDesignateServiceLaboratory> PatientDesignateServiceLaboratories { get; set; } = new List<PatientDesignateServiceLaboratory>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementMachineMains { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<RehabilitationAccountImplement> RehabilitationAccountImplementMachineSubs { get; set; } = new List<RehabilitationAccountImplement>();

    public virtual ICollection<TestingProcedureMachine> TestingProcedureMachines { get; set; } = new List<TestingProcedureMachine>();
}
