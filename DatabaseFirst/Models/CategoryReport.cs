using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục báo cáo
/// </summary>
public partial class CategoryReport
{
    public Guid ReportId { get; set; }

    /// <summary>
    /// tên báo cáo
    /// </summary>
    public string ReportName { get; set; } = null!;

    /// <summary>
    /// id loại biểu mẫu
    /// </summary>
    public Guid FormAttributeId { get; set; }

    /// <summary>
    /// id khổ giấy
    /// </summary>
    public Guid PaperSizeAttributeId { get; set; }

    /// <summary>
    /// kích thước chiều dọc
    /// </summary>
    public int Vertical { get; set; }

    /// <summary>
    /// kích thước chiều ngang
    /// </summary>
    public int Horizontal { get; set; }

    /// <summary>
    /// id hướng giấy
    /// </summary>
    public Guid PaperOrientationAttributeId { get; set; }

    /// <summary>
    /// id định dạng file
    /// </summary>
    public Guid FormatFileAttributeId { get; set; }

    /// <summary>
    /// id loại in
    /// </summary>
    public Guid PrintTypeAttributeId { get; set; }

    /// <summary>
    /// ký số
    /// </summary>
    public int IsDigitalSign { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public string? File { get; set; }

    public string? ReportCode { get; set; }

    public string? FileName { get; set; }

    public virtual ICollection<CategoryCdhatdcn> CategoryCdhatdcns { get; set; } = new List<CategoryCdhatdcn>();

    public virtual ICollection<CategoryGroupServiceLevel2> CategoryGroupServiceLevel2s { get; set; } = new List<CategoryGroupServiceLevel2>();

    public virtual ICollection<CategoryGroupServiceLevel3> CategoryGroupServiceLevel3s { get; set; } = new List<CategoryGroupServiceLevel3>();

    public virtual ICollection<CategoryLaboratoryService> CategoryLaboratoryServices { get; set; } = new List<CategoryLaboratoryService>();

    public virtual ICollection<CategoryRehabilitationsService> CategoryRehabilitationsServices { get; set; } = new List<CategoryRehabilitationsService>();

    public virtual ICollection<CategorySetUpSign> CategorySetUpSigns { get; set; } = new List<CategorySetUpSign>();

    public virtual ICollection<CategorySurgicalProceduresService> CategorySurgicalProceduresServices { get; set; } = new List<CategorySurgicalProceduresService>();

    public virtual ICollection<CategoryVotePrint> CategoryVotePrints { get; set; } = new List<CategoryVotePrint>();

    public virtual CategoryAttribute FormAttribute { get; set; } = null!;

    public virtual CategoryAttribute FormatFileAttribute { get; set; } = null!;

    public virtual CategoryAttribute PaperOrientationAttribute { get; set; } = null!;

    public virtual CategoryAttribute PaperSizeAttribute { get; set; } = null!;

    public virtual CategoryAttribute PrintTypeAttribute { get; set; } = null!;

    public virtual ICollection<ReportBallotType> ReportBallotTypes { get; set; } = new List<ReportBallotType>();

    public virtual ICollection<ReportTypeOfMedicalRecord> ReportTypeOfMedicalRecords { get; set; } = new List<ReportTypeOfMedicalRecord>();
}
