using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Đối tác con
/// </summary>
public partial class CategoryChildPartner
{
    public Guid ChildPartnerId { get; set; }

    public string ChildPartnerCode { get; set; } = null!;

    public string ChildPartnerName { get; set; } = null!;

    public string? TaxCode { get; set; }

    public string? Note { get; set; }

    public int? IsNotSendName { get; set; }

    public int? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<PartnerChildPartner> PartnerChildPartners { get; set; } = new List<PartnerChildPartner>();
}
