using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách tài liệu hướng dẫn
/// </summary>
public partial class CategoryUserGuide
{
    public Guid UserGuideId { get; set; }

    /// <summary>
    /// mã tài liệu hd sd
    /// </summary>
    public string UserGuideCode { get; set; } = null!;

    /// <summary>
    /// tên hướng dẫn sử dụng
    /// </summary>
    public string UserGuideName { get; set; } = null!;

    /// <summary>
    /// ảnh bìa
    /// </summary>
    public string? UserGuideImage { get; set; }

    /// <summary>
    /// file hướng dẫn
    /// </summary>
    public string UserGuideFile { get; set; } = null!;

    /// <summary>
    /// video hướng dẫn
    /// </summary>
    public string? UserGuideVideo { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
