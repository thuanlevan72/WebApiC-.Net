using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Dịch vụ khám - phòng thực hiện
/// </summary>
public partial class MedicalExaminationServiceTabImplementationRoom
{
    public Guid MedicalExaminationServiceImplementRoomId { get; set; }

    public Guid MedicalExaminationServiceId { get; set; }

    public Guid ImplementationRoomId { get; set; }

    public virtual CategoryTabImplementationRoom ImplementationRoom { get; set; } = null!;

    public virtual CategoryMedicalExaminationService MedicalExaminationService { get; set; } = null!;
}
