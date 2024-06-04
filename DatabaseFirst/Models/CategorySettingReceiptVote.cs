using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Thiết lập phiếu trả
/// </summary>
public partial class CategorySettingReceiptVote
{
    public Guid SettingReceiptVoteId { get; set; }

    /// <summary>
    /// Thời gian tạo phiếu 1: thời gian chỉ định 2 thời gian thực hiện
    /// </summary>
    public int CreatedVoteTime { get; set; }

    /// <summary>
    /// Tạo phiếu với số lượng lẻ
    /// </summary>
    public int CreateVoteOdd { get; set; }

    /// <summary>
    /// trả phiếu với số lượng lẻ
    /// </summary>
    public int ReceiptVoteOdd { get; set; }

    /// <summary>
    /// tách phiếu theo mã phiếu lĩnh
    /// </summary>
    public int SeparateReceiptCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? ChangedBy { get; set; }
}
