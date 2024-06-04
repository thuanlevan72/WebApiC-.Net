using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin khách hàng - đơn thuốc
/// </summary>
public partial class CategoryPatientPrescription
{
    public Guid PatientPrescriptionId { get; set; }

    /// <summary>
    /// Họ và tên
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// sdt
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// ngày sinh
    /// </summary>
    public DateTime? Dob { get; set; }

    /// <summary>
    /// tuổi
    /// </summary>
    public string? Age { get; set; }

    /// <summary>
    /// giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// phường xã
    /// </summary>
    public Guid? WardId { get; set; }

    /// <summary>
    /// quận huyện
    /// </summary>
    public Guid? DistrictId { get; set; }

    /// <summary>
    /// thành phố
    /// </summary>
    public Guid? CityId { get; set; }

    /// <summary>
    /// người bảo lãnh
    /// </summary>
    public string? Guardian { get; set; }

    /// <summary>
    /// số dt người bảo lãnh
    /// </summary>
    public string? GuardianPhone { get; set; }

    /// <summary>
    /// bác sĩ chỉ định
    /// </summary>
    public Guid AccountId { get; set; }

    /// <summary>
    /// bác sĩ ngoại viện
    /// </summary>
    public Guid? OutpatientDoctorId { get; set; }

    /// <summary>
    /// quầy
    /// </summary>
    public Guid? CounterId { get; set; }

    public int IsActive { get; set; }

    public int? IsStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Address { get; set; }

    public string? PatientPrescriptionCode { get; set; }

    public Guid? PatientReceiptCodeId { get; set; }

    public virtual CategoryAccount Account { get; set; } = null!;

    public virtual ICollection<CategoryPrescriptionOrder> CategoryPrescriptionOrders { get; set; } = new List<CategoryPrescriptionOrder>();

    public virtual ICollection<CategoryPrescriptionService> CategoryPrescriptionServices { get; set; } = new List<CategoryPrescriptionService>();

    public virtual CategoryCity? City { get; set; }

    public virtual CategoryCounter? Counter { get; set; }

    public virtual CategoryDistrict? District { get; set; }

    public virtual CategoryOutpatientDoctor? OutpatientDoctor { get; set; }

    public virtual CategoryPatientReceiptCode? PatientReceiptCode { get; set; }

    public virtual CategoryWard? Ward { get; set; }
}
