using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục tab dịch vụ kèm theo
/// </summary>
public partial class CategoryTabAccompanyingService
{
    public Guid AccompanyingServicesId { get; set; }

    /// <summary>
    /// thời điểm chỉ định
    /// </summary>
    public Guid DesignatedTimeAttributeId { get; set; }

    public int Quantity { get; set; }

    /// <summary>
    /// thời gian có giá trị
    /// </summary>
    public DateTimeOffset? ValuableTime { get; set; }

    public int IsNoCharge { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<BedServiceTabAccompanyingService> BedServiceTabAccompanyingServices { get; set; } = new List<BedServiceTabAccompanyingService>();

    public virtual ICollection<BloodProductsTabAccompanyingService> BloodProductsTabAccompanyingServices { get; set; } = new List<BloodProductsTabAccompanyingService>();

    public virtual ICollection<CdhatdcnTabAccompanyingService> CdhatdcnTabAccompanyingServices { get; set; } = new List<CdhatdcnTabAccompanyingService>();

    public virtual CategoryAttribute DesignatedTimeAttribute { get; set; } = null!;

    public virtual ICollection<LaboratoryServiceTabAccompanyingService> LaboratoryServiceTabAccompanyingServices { get; set; } = new List<LaboratoryServiceTabAccompanyingService>();

    public virtual ICollection<MedicalExaminationServiceTabAccompanyingService> MedicalExaminationServiceTabAccompanyingServices { get; set; } = new List<MedicalExaminationServiceTabAccompanyingService>();

    public virtual ICollection<SurgicalProceduresServiceTabAccompanyingService> SurgicalProceduresServiceTabAccompanyingServices { get; set; } = new List<SurgicalProceduresServiceTabAccompanyingService>();

    public virtual ICollection<TabAccompanyingServicesObjectType> TabAccompanyingServicesObjectTypes { get; set; } = new List<TabAccompanyingServicesObjectType>();
}
