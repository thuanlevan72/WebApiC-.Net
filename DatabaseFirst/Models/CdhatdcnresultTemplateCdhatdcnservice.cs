using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Mẫu kết quả CDHA- Dịch vụ
/// </summary>
public partial class CdhatdcnresultTemplateCdhatdcnservice
{
    public Guid ResultTemplateCdhaTdcnServiceId { get; set; }

    public Guid CdhaTdcnResultTemplateId { get; set; }

    public Guid CdhaTdcnId { get; set; }

    public virtual CategoryCdhatdcn CdhaTdcn { get; set; } = null!;

    public virtual CategoryCdhatdcnresultTemplate CdhaTdcnResultTemplate { get; set; } = null!;
}
