using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục bộ chỉ định
/// </summary>
public partial class CategoryDesignationKit
{
    public Guid DesignationKitId { get; set; }

    public string DesignationKitCode { get; set; } = null!;

    public string DesignationKitName { get; set; } = null!;

    public int IsDestrictDepartment { get; set; }

    public int IsUseCovid { get; set; }

    public int IsPrescriptionMedicineKit { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public Guid? ConceptId { get; set; }

    public virtual ICollection<CategoryPatientDesignateService> CategoryPatientDesignateServices { get; set; } = new List<CategoryPatientDesignateService>();

    public virtual CategoryConcept? Concept { get; set; }

    public virtual ICollection<DesignationKitAccount> DesignationKitAccounts { get; set; } = new List<DesignationKitAccount>();

    public virtual ICollection<DesignationKitDesignatedFaculty> DesignationKitDesignatedFaculties { get; set; } = new List<DesignationKitDesignatedFaculty>();

    public virtual ICollection<DesignationKitDesignationKitServiceDetail> DesignationKitDesignationKitServiceDetails { get; set; } = new List<DesignationKitDesignationKitServiceDetail>();

    public virtual ICollection<DesignationKitDesignationKitService> DesignationKitDesignationKitServices { get; set; } = new List<DesignationKitDesignationKitService>();

    public virtual ICollection<DesignationKitServiceList> DesignationKitServiceLists { get; set; } = new List<DesignationKitServiceList>();

    public virtual ICollection<DesignationKitServiceType> DesignationKitServiceTypes { get; set; } = new List<DesignationKitServiceType>();
}
