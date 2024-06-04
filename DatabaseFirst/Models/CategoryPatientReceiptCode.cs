using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Danh sách phiếu thu
/// </summary>
public partial class CategoryPatientReceiptCode
{
    public Guid PatientReceiptCodeId { get; set; }

    /// <summary>
    /// mã phiếu thu format ngày hiện tại + stt phiếu thu yyyyMMdd000Index
    /// </summary>
    public string ReceiptCode { get; set; } = null!;

    /// <summary>
    /// tổng tiền
    /// </summary>
    public double Total { get; set; }

    /// <summary>
    /// thu ngân
    /// </summary>
    public Guid? AccountId { get; set; }

    /// <summary>
    /// ký hiệu
    /// </summary>
    public string? ReceiptSymbol { get; set; }

    /// <summary>
    /// ngày thanh toán
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// trạng thái: 0: Chưa thanh toán, 1: Thanh toán, 2: Chờ hoàn, 3: Đã hoàn
    /// </summary>
    public int ReceiptStatus { get; set; }

    /// <summary>
    /// trạng thái hóa đơn
    /// </summary>
    public int BillStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// 1: đối tượng bảo hiểm hiển thị ở phần thu ngân 0, đối tượng không bảo hiểm hiển thị ở phần đơn thuốc
    /// </summary>
    public int? IsInsurance { get; set; }

    /// <summary>
    /// lưu mã phiếu thu khi hoàn default là null
    /// </summary>
    public string? ReceiptCodeReturn { get; set; }

    public Guid? AccountRequest { get; set; }

    public virtual CategoryAccount? Account { get; set; }

    public virtual CategoryAccount? AccountRequestNavigation { get; set; }

    public virtual ICollection<CategoryPatientPrescription> CategoryPatientPrescriptions { get; set; } = new List<CategoryPatientPrescription>();

    public virtual ICollection<ReceiptCodeDesignateService> ReceiptCodeDesignateServices { get; set; } = new List<ReceiptCodeDesignateService>();

    public virtual ICollection<ReceiptCodeMoney> ReceiptCodeMoneys { get; set; } = new List<ReceiptCodeMoney>();
}
