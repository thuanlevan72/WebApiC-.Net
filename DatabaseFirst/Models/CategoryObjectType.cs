using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục loại đối tượng
/// </summary>
public partial class CategoryObjectType
{
    public Guid ObjectTypeId { get; set; }

    public string ObjectTypeCode { get; set; } = null!;

    public string ObjectTypeName { get; set; } = null!;

    public Guid ObjectAttributeId { get; set; }

    public Guid? ExemptionTypeAttributeId { get; set; }

    public int? ExemptionTypePercent { get; set; }

    public decimal? ExemptionTypePrice { get; set; }

    public decimal? AdvanceThreshold { get; set; }

    public string? Note { get; set; }

    public int IsMilitary { get; set; }

    public int IsRequestOpdAdvance { get; set; }

    public int IsPhysicalExamination { get; set; }

    public int IsLaterPayment { get; set; }

    public int IsPriority { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CategoryPatient> CategoryPatients { get; set; } = new List<CategoryPatient>();

    public virtual ICollection<CategorySetUpDesignatedWarehouse> CategorySetUpDesignatedWarehouses { get; set; } = new List<CategorySetUpDesignatedWarehouse>();

    public virtual ICollection<CategorySetupMedicalRecord> CategorySetupMedicalRecords { get; set; } = new List<CategorySetupMedicalRecord>();

    public virtual CategoryAttribute? ExemptionTypeAttribute { get; set; }

    public virtual CategoryAttribute ObjectAttribute { get; set; } = null!;

    public virtual ICollection<ObjectTypePaymentMethod> ObjectTypePaymentMethods { get; set; } = new List<ObjectTypePaymentMethod>();

    public virtual ICollection<ObjectTypePaymentType> ObjectTypePaymentTypes { get; set; } = new List<ObjectTypePaymentType>();

    public virtual ICollection<PatientAdvanceReceipt> PatientAdvanceReceipts { get; set; } = new List<PatientAdvanceReceipt>();
}
