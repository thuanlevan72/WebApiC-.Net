using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Quản lý danh mục phòng giường
/// </summary>
public partial class CategoryRoomBed
{
    public Guid CategoryRoomBedId { get; set; }

    /// <summary>
    /// phòng
    /// </summary>
    public Guid RoomId { get; set; }

    /// <summary>
    /// số hiệu giường
    /// </summary>
    public Guid BedNumberId { get; set; }

    /// <summary>
    /// hồ sơ bệnh án
    /// </summary>
    public Guid SetupMedicalRecordId { get; set; }

    /// <summary>
    /// bệnh nhân
    /// </summary>
    public Guid? PatientId { get; set; }

    /// <summary>
    /// từ ngày
    /// </summary>
    public DateTime FromDate { get; set; }

    /// <summary>
    /// loại giường
    /// </summary>
    public Guid? BedTypeId { get; set; }

    /// <summary>
    /// tên dịch vụ giường thường
    /// </summary>
    public Guid BedServiceId { get; set; }

    /// <summary>
    /// tên dịch vụ giường tự chọn
    /// </summary>
    public Guid BedService2Id { get; set; }

    /// <summary>
    /// tự trả
    /// </summary>
    public int IsPayment { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid? PatientReceptionId { get; set; }

    public DateTime? ToDate { get; set; }

    public int? IsBedType { get; set; }

    public virtual CategoryBedNumber BedNumber { get; set; } = null!;

    public virtual CategoryBedService BedService { get; set; } = null!;

    public virtual CategoryBedService BedService2 { get; set; } = null!;

    public virtual CategoryBedType? BedType { get; set; }

    public virtual CategoryPatient? Patient { get; set; }

    public virtual CategoryPatientReception? PatientReception { get; set; }

    public virtual CategoryRoom Room { get; set; } = null!;
}
