using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// sinh hiệu chỉ só sống
/// </summary>
public partial class VitalSignsPidSurvivalIndex
{
    public Guid VitalSignsPidSurvivalIndexId { get; set; }

    public Guid VitalSignsPid { get; set; }

    public Guid SurvivalIndexId { get; set; }

    public virtual CategorySurvivalIndex SurvivalIndex { get; set; } = null!;

    public virtual VitalSignsPid VitalSignsP { get; set; } = null!;
}
