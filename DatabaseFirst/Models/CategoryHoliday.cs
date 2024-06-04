using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục ngày nghỉ
/// </summary>
public partial class CategoryHoliday
{
    public Guid HolidayId { get; set; }

    public string HolidayCode { get; set; } = null!;

    public string HolidayName { get; set; } = null!;

    public DateTime HolidayDate { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
