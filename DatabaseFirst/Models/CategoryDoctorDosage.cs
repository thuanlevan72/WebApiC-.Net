using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục liều dùng bác sĩ
/// </summary>
public partial class CategoryDoctorDosage
{
    public Guid DoctorDosageId { get; set; }

    /// <summary>
    /// mã liều dùng
    /// </summary>
    public string DoctorDosageCode { get; set; } = null!;

    /// <summary>
    /// tên liều dùng
    /// </summary>
    public string DoctorDosageName { get; set; } = null!;

    /// <summary>
    /// số lượng dùng sáng
    /// </summary>
    public int? QuantityUseMorning { get; set; }

    /// <summary>
    /// số lượng dùng chiều
    /// </summary>
    public int? QuantityUseAfternoon { get; set; }

    /// <summary>
    /// số lượng dùng tối
    /// </summary>
    public int? QuantityUseEvening { get; set; }

    /// <summary>
    /// số lượng dùng đêm
    /// </summary>
    public int? QuantityUseNight { get; set; }

    /// <summary>
    /// thời điểm sử dụng
    /// </summary>
    public string? TimeOfUse { get; set; }

    /// <summary>
    /// id đường dùng
    /// </summary>
    public Guid RoutesId { get; set; }

    /// <summary>
    /// id tài khoản
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual ICollection<DoctorDosageDrug> DoctorDosageDrugs { get; set; } = new List<DoctorDosageDrug>();

    public virtual CategoryRoute Routes { get; set; } = null!;
}
