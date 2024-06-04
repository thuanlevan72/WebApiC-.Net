using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục chăm sóc khách hàng
/// </summary>
public partial class CategoryGroupCustomerCare
{
    public Guid GroupCustomerCareId { get; set; }

    public Guid? ProgramId { get; set; }

    public Guid? PatientSourceId { get; set; }

    public Guid? CardClassId { get; set; }

    public virtual CategoryCardClass? CardClass { get; set; }

    public virtual CategoryPatientSource? PatientSource { get; set; }

    public virtual CategoryProgram? Program { get; set; }
}
