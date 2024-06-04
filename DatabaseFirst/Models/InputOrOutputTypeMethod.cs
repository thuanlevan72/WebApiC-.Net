using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Hình thức nhập xuất 
/// </summary>
public partial class InputOrOutputTypeMethod
{
    public Guid InputOrOutputTypeMethodId { get; set; }

    public Guid InputOrOutputTypeId { get; set; }

    public Guid MethodAttributeId { get; set; }

    public virtual CategoryInputOrOutputType InputOrOutputType { get; set; } = null!;

    public virtual CategoryAttribute MethodAttribute { get; set; } = null!;
}
