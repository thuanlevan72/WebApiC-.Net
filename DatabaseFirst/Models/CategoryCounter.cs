using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục quầy
/// </summary>
public partial class CategoryCounter
{
    public Guid CounterId { get; set; }

    /// <summary>
    /// tên quầy
    /// </summary>
    public string CounterName { get; set; } = null!;

    /// <summary>
    /// số lượng hàng đợi
    /// </summary>
    public int WatingNumber { get; set; }

    /// <summary>
    /// số lượng tiếp theo
    /// </summary>
    public int NextNumber { get; set; }

    /// <summary>
    /// khoa
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// tòa
    /// </summary>
    public Guid BuildingId { get; set; }

    /// <summary>
    /// loa gọi số
    /// </summary>
    public Guid SpeakerCallingId { get; set; }

    /// <summary>
    /// khu vực
    /// </summary>
    public Guid AreaId { get; set; }

    /// <summary>
    /// không lấy số
    /// </summary>
    public int IsNoTicket { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    /// <summary>
    /// mã quầy
    /// </summary>
    public string? CounterCode { get; set; }

    public virtual CategoryArea Area { get; set; } = null!;

    public virtual CategoryBuilding Building { get; set; } = null!;

    public virtual ICollection<CategoryKiosk> CategoryKiosks { get; set; } = new List<CategoryKiosk>();

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<CategoryPatientReception> CategoryPatientReceptions { get; set; } = new List<CategoryPatientReception>();

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CounterCounterType> CounterCounterTypes { get; set; } = new List<CounterCounterType>();

    public virtual ICollection<CounterReceptionObject> CounterReceptionObjects { get; set; } = new List<CounterReceptionObject>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();

    public virtual CategorySpeakerCalling SpeakerCalling { get; set; } = null!;
}
