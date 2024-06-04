using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class RehabilitationAccountImplement
{
    public Guid RehabilitationAccountImplementId { get; set; }

    public Guid PatientDesignateSurgicalProceduresId { get; set; }

    public Guid OutpatientDoctorId { get; set; }

    public Guid OutpatientAnesthesiologist { get; set; }

    public Guid SurgeonsId { get; set; }

    public Guid Surgeons1Id { get; set; }

    public Guid Surgeons2Id { get; set; }

    public Guid Anesthesia1 { get; set; }

    public Guid Anesthesia2 { get; set; }

    public Guid AnestheticAdditive1 { get; set; }

    public Guid AnestheticAdditive2 { get; set; }

    public Guid MachineMainId { get; set; }

    public Guid MachineSubId { get; set; }

    public Guid Nurse { get; set; }

    public Guid NurseTool1 { get; set; }

    public Guid NurseTool2 { get; set; }

    public Guid NurseTool3 { get; set; }

    public Guid NurseTool4 { get; set; }

    public Guid NurseTool5 { get; set; }

    public virtual CategoryAccount Anesthesia1Navigation { get; set; } = null!;

    public virtual CategoryAccount Anesthesia2Navigation { get; set; } = null!;

    public virtual CategoryAccount AnestheticAdditive1Navigation { get; set; } = null!;

    public virtual CategoryAccount AnestheticAdditive2Navigation { get; set; } = null!;

    public virtual CategoryMachine MachineMain { get; set; } = null!;

    public virtual CategoryMachine MachineSub { get; set; } = null!;

    public virtual CategoryAccount NurseNavigation { get; set; } = null!;

    public virtual CategoryAccount NurseTool1Navigation { get; set; } = null!;

    public virtual CategoryAccount NurseTool2Navigation { get; set; } = null!;

    public virtual CategoryAccount NurseTool3Navigation { get; set; } = null!;

    public virtual CategoryAccount NurseTool4Navigation { get; set; } = null!;

    public virtual CategoryAccount NurseTool5Navigation { get; set; } = null!;

    public virtual CategoryAccount OutpatientAnesthesiologistNavigation { get; set; } = null!;

    public virtual CategoryAccount OutpatientDoctor { get; set; } = null!;

    public virtual PatientDesignateServiceSurgicalProceduce PatientDesignateSurgicalProcedures { get; set; } = null!;

    public virtual CategoryAccount Surgeons { get; set; } = null!;

    public virtual CategoryAccount Surgeons1 { get; set; } = null!;

    public virtual CategoryAccount Surgeons2 { get; set; } = null!;
}
