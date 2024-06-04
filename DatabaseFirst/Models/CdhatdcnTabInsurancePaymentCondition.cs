using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// CDHATDCN-DK thanh toán bảo hiểm
/// </summary>
public partial class CdhatdcnTabInsurancePaymentCondition
{
    public Guid CdhaTdcnTabInsurancePaymentCoditionId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public Guid TabInsurancePaymentCoditionId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryTabInsurancePaymentCondition TabInsurancePaymentCodition { get; set; } = null!;
}
