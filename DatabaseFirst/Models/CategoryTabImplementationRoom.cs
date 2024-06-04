using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tab Phòng thực hiện
/// </summary>
public partial class CategoryTabImplementationRoom
{
    public Guid TabImplementRoomId { get; set; }

    public Guid DepartmentId { get; set; }

    public int? Gender { get; set; }

    public string? AddressRoom { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<BedServiceTabImplementationRoom> BedServiceTabImplementationRooms { get; set; } = new List<BedServiceTabImplementationRoom>();

    public virtual ICollection<CdhatdcnTabImplementationRoom> CdhatdcnTabImplementationRooms { get; set; } = new List<CdhatdcnTabImplementationRoom>();

    public virtual CategoryDepartment Department { get; set; } = null!;

    public virtual ICollection<LaboratoryServiceTabImplementationRoom> LaboratoryServiceTabImplementationRooms { get; set; } = new List<LaboratoryServiceTabImplementationRoom>();

    public virtual ICollection<MedicalExaminationServiceTabImplementationRoom> MedicalExaminationServiceTabImplementationRooms { get; set; } = new List<MedicalExaminationServiceTabImplementationRoom>();

    public virtual ICollection<OutsiteOfTreatmentServiceImplementationRoom> OutsiteOfTreatmentServiceImplementationRooms { get; set; } = new List<OutsiteOfTreatmentServiceImplementationRoom>();

    public virtual ICollection<RehabilitationServiceTabImplementationRoom> RehabilitationServiceTabImplementationRooms { get; set; } = new List<RehabilitationServiceTabImplementationRoom>();

    public virtual ICollection<SurgicalProceduresServiceTabImplementationRoom> SurgicalProceduresServiceTabImplementationRooms { get; set; } = new List<SurgicalProceduresServiceTabImplementationRoom>();

    public virtual ICollection<TabImplementationRoomsRoom> TabImplementationRoomsRooms { get; set; } = new List<TabImplementationRoomsRoom>();
}
