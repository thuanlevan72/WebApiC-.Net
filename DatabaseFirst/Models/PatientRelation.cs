using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Bệnh nhân - Người thân
/// </summary>
public partial class PatientRelation
{
    public Guid PatientRelationId { get; set; }

    public Guid PatientId { get; set; }

    /// <summary>
    /// người giới thiệu
    /// </summary>
    public Guid? PresenterId { get; set; }

    /// <summary>
    /// nguồn giới thiệu
    /// </summary>
    public Guid? PatientSourceId { get; set; }

    public string FullName { get; set; } = null!;

    /// <summary>
    /// mối quan hệ
    /// </summary>
    public Guid? RelationShipId { get; set; }

    /// <summary>
    /// số điện thoại
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// cccd người bảo lãnh
    /// </summary>
    public string IdentityCode { get; set; } = null!;

    /// <summary>
    /// tên người bảo lãnh 2
    /// </summary>
    public string FullName2 { get; set; } = null!;

    /// <summary>
    /// Mối quan hệ với NB
    /// </summary>
    public Guid? RelationShip2Id { get; set; }

    /// <summary>
    /// cccd người bảo lãnh 2
    /// </summary>
    public string IdentityCode2 { get; set; } = null!;

    public string Note { get; set; } = null!;

    /// <summary>
    /// bệnh án dài hạn hiện thị khi được tích vào bệnh án dài hạn
    /// </summary>
    public Guid? TypeOfMedicalRecordId { get; set; }

    /// <summary>
    /// loaij miễn trừ
    /// </summary>
    public Guid? ExemptionType { get; set; }

    /// <summary>
    /// người duyệt
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// phân loại
    /// </summary>
    public Guid? Type { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public string? Phone2 { get; set; }

    public string? Address { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryAttribute? ExemptionTypeNavigation { get; set; }

    public virtual CategoryPatient Patient { get; set; } = null!;

    public virtual CategoryPatientSource? PatientSource { get; set; }

    public virtual CategoryPresenter? Presenter { get; set; }

    public virtual CategoryRelationship? RelationShip { get; set; }

    public virtual CategoryRelationship? RelationShip2 { get; set; }

    public virtual CategoryClassifyPatient? TypeNavigation { get; set; }

    public virtual CategoryTypeOfMedicalRecord? TypeOfMedicalRecord { get; set; }
}
