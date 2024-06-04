using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thông tin gói -  dịch vụ trong gói
/// </summary>
public partial class PackageServiceServiceOfPackage
{
    public Guid PackageServiceServiceOfPackageId { get; set; }

    public Guid PackageServiceId { get; set; }

    public Guid ServiceOfPackageId { get; set; }

    public virtual CategoryPackageService PackageService { get; set; } = null!;

    public virtual CategoryServiceOfPackage ServiceOfPackage { get; set; } = null!;
}
