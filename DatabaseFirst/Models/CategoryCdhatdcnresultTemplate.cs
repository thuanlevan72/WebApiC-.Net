using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục mẫu kết quả CDHATDCN
/// </summary>
public partial class CategoryCdhatdcnresultTemplate
{
    public Guid CdhaTdcnResultTemplateId { get; set; }

    /// <summary>
    /// mã
    /// </summary>
    public string CdhaTdcnResultTemplateCode { get; set; } = null!;

    /// <summary>
    /// tên
    /// </summary>
    public string CdhaTdcnResultTemplateName { get; set; } = null!;

    /// <summary>
    /// kết quả
    /// </summary>
    public string Result { get; set; } = null!;

    /// <summary>
    /// kết luận
    /// </summary>
    public string Conclude { get; set; } = null!;

    /// <summary>
    /// cách thức can thiệp
    /// </summary>
    public string MethodOfIntervention { get; set; } = null!;

    /// <summary>
    /// phương thức can thiệp
    /// </summary>
    public string ModeOfInterference { get; set; } = null!;

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public virtual ICollection<CdhatdcnresultTemplateCdhatdcnservice> CdhatdcnresultTemplateCdhatdcnservices { get; set; } = new List<CdhatdcnresultTemplateCdhatdcnservice>();

    public virtual ICollection<PatientDesignateServiceCdha> PatientDesignateServiceCdhas { get; set; } = new List<PatientDesignateServiceCdha>();
}
