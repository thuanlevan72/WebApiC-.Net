using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Kho -Loại kho
/// </summary>
public partial class WarehouseWareHouseType
{
    public Guid WarehouseWarehouseType1 { get; set; }

    public Guid WarehouseId { get; set; }

    public Guid ConceptId { get; set; }

    public virtual CategoryConcept Concept { get; set; } = null!;

    public virtual CategoryWarehouse Warehouse { get; set; } = null!;
}
