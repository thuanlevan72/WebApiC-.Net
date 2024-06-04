using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục lịch sử chỉnh sửa
/// </summary>
public partial class CategoryTabHistoryChanged
{
    public Guid TabHistoryChangedId { get; set; }

    public string Field { get; set; } = null!;

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public Guid? ChangedBy { get; set; }

    public DateTime ChangedTime { get; set; }

    public int? IsActiive { get; set; }

    public virtual ICollection<CdhatdcnTabHistoryChanged> CdhatdcnTabHistoryChangeds { get; set; } = new List<CdhatdcnTabHistoryChanged>();

    public virtual ICollection<LaboratoryServiceTabHistoryChanged> LaboratoryServiceTabHistoryChangeds { get; set; } = new List<LaboratoryServiceTabHistoryChanged>();

    public virtual ICollection<MedicalExaminationServiceTabHistoryChange> MedicalExaminationServiceTabHistoryChanges { get; set; } = new List<MedicalExaminationServiceTabHistoryChange>();

    public virtual ICollection<RehabilitationsServicesTabHistoryChanged> RehabilitationsServicesTabHistoryChangeds { get; set; } = new List<RehabilitationsServicesTabHistoryChanged>();

    public virtual ICollection<SurgicalProceduresServicesTabHistoryChanged> SurgicalProceduresServicesTabHistoryChangeds { get; set; } = new List<SurgicalProceduresServicesTabHistoryChanged>();
}
