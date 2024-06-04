using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục gói mổ 10 ngày
/// </summary>
public partial class Category10daySurgeryPackage
{
    public Guid SurgeryPackageId { get; set; }

    /// <summary>
    /// mã gói
    /// </summary>
    public string SurgeryPackageCode { get; set; } = null!;

    /// <summary>
    /// tên gói
    /// </summary>
    public string SurgeryPackageName { get; set; } = null!;

    /// <summary>
    /// đơn giá không bảo hiểm
    /// </summary>
    public decimal SurgeryPackagePriceNonInsurance { get; set; }

    /// <summary>
    /// phòng thực hiện
    /// </summary>
    public Guid RoomId { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// nhóm dịch vụ
    /// </summary>
    public Guid? GroupServiceLvl1 { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public virtual CategoryGroupServiceLevel1? GroupServiceLvl1Navigation { get; set; }

    public virtual ICollection<PatientDesignateServiceSurgicalProceduce> PatientDesignateServiceSurgicalProceduces { get; set; } = new List<PatientDesignateServiceSurgicalProceduce>();

    public virtual CategoryRoom Room { get; set; } = null!;

    public virtual ICollection<SurgeryPackageGeneralService> SurgeryPackageGeneralServices { get; set; } = new List<SurgeryPackageGeneralService>();
}
