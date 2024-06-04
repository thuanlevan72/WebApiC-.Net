using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ ngoài điều trị - phòng thực hiện
/// </summary>
public partial class OutsiteOfTreatmentServiceImplementationRoom
{
    public Guid OutSiteOfTreatmentServiceImplementRoom { get; set; }

    public Guid OutSiteOfTreatmentServiceId { get; set; }

    public Guid TabImplementRoomId { get; set; }

    public virtual CategoryOutsiteOfTreatmentService OutSiteOfTreatmentService { get; set; } = null!;

    public virtual CategoryTabImplementationRoom TabImplementRoom { get; set; } = null!;
}
