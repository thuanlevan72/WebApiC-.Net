using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh mục nhân viên
/// </summary>
public partial class CategoryEmployee
{
    public Guid EmployeeId { get; set; }

    /// <summary>
    /// Họ tên
    /// </summary>
    public string EmployeeName { get; set; } = null!;

    /// <summary>
    /// mã nhân viên
    /// </summary>
    public string EmployeeCode { get; set; } = null!;

    /// <summary>
    /// ngày sinh
    /// </summary>
    public DateTime? Dob { get; set; }

    /// <summary>
    /// bằng chuyên môn
    /// </summary>
    public Guid? ProfessionalDiplomaId { get; set; }

    /// <summary>
    /// mã bhyt
    /// </summary>
    public string? InsuranceCode { get; set; }

    /// <summary>
    /// giới tính
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// học hàm học vị
    /// </summary>
    public Guid? TitleDegreeId { get; set; }

    /// <summary>
    /// email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// chứng nhận
    /// </summary>
    public string? Cerfiticate { get; set; }

    /// <summary>
    /// điện thoại
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// vị trí
    /// </summary>
    public Guid? PositionId { get; set; }

    /// <summary>
    /// cmnd/cccd
    /// </summary>
    public string? Identity { get; set; }

    /// <summary>
    /// chứng minh số /MK ký
    /// </summary>
    public string? IdentityDigital { get; set; }

    /// <summary>
    /// MST/ tên tài khoản ký
    /// </summary>
    public string? SignAccount { get; set; }

    /// <summary>
    /// danh hiệu
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// mật khẩu
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// khóa từ ngày
    /// </summary>
    public DateTime? BlockFromDate { get; set; }

    /// <summary>
    /// khóa đến ngày
    /// </summary>
    public DateTime? BlockToDate { get; set; }

    /// <summary>
    /// ảnh tải lên
    /// </summary>
    public string? Avatar { get; set; }

    /// <summary>
    /// ảnh chữ ký
    /// </summary>
    public string? SignImage { get; set; }

    /// <summary>
    /// ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// đặt khám online
    /// </summary>
    public int? IsOnline { get; set; }

    public int IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }

    public string? AvatarSignature { get; set; }

    /// <summary>
    /// kinh nghiệm làm việc
    /// </summary>
    public string? Content { get; set; }

    public virtual ICollection<BasicInformationPatientIpd> BasicInformationPatientIpds { get; set; } = new List<BasicInformationPatientIpd>();

    public virtual ICollection<CategoryAccount> CategoryAccounts { get; set; } = new List<CategoryAccount>();

    public virtual ICollection<CategoryCouncilDetail> CategoryCouncilDetails { get; set; } = new List<CategoryCouncilDetail>();

    public virtual ICollection<DesignationKitAccount> DesignationKitAccounts { get; set; } = new List<DesignationKitAccount>();

    public virtual ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = new List<EmployeeDepartment>();

    public virtual ICollection<EmployeeSpecialist> EmployeeSpecialists { get; set; } = new List<EmployeeSpecialist>();

    public virtual CategoryPosition? Position { get; set; }

    public virtual CategoryProfessionalDiploma? ProfessionalDiploma { get; set; }

    public virtual CategoryTitleDegree? TitleDegree { get; set; }
}
