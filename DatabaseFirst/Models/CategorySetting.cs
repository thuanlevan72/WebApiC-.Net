using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// cấu hình 
/// </summary>
public partial class CategorySetting
{
    public Guid SettingId { get; set; }

    /// <summary>
    /// mã người bệnh
    /// </summary>
    public string? MaNguoiBenh { get; set; }

    /// <summary>
    /// mã tiếp đón nb/ sô hồ sơ
    /// </summary>
    public string? MaTiepDonNbMaHoSo { get; set; }

    /// <summary>
    /// mã y tế
    /// </summary>
    public string? MaYTe { get; set; }

    /// <summary>
    /// mã ngoại trú
    /// </summary>
    public string? MaNgoaiTru { get; set; }

    /// <summary>
    /// số vào viện số bệnh án
    /// </summary>
    public string? SoVaoVienSoBenhAn { get; set; }

    /// <summary>
    /// số lưu trữ
    /// </summary>
    public string? SoLuuTru { get; set; }

    /// <summary>
    /// số
    /// </summary>
    public string? So { get; set; }

    /// <summary>
    /// lần số
    /// </summary>
    public string? LanSo { get; set; }

    /// <summary>
    /// số seri
    /// </summary>
    public string? SoSeri { get; set; }

    /// <summary>
    /// Mã số mẹ Mã số trẻ sơ sinh
    /// </summary>
    public string? MaSoMeMaSoTreSoSinh { get; set; }

    /// <summary>
    /// Số:…………                        Quyển số…            Số Hồ sơ:
    /// </summary>
    public string? SoQuyenSoSoHoSo { get; set; }

    /// <summary>
    /// Số Seri……… Số:………../………….
    /// </summary>
    public string? SoSeriSo { get; set; }

    /// <summary>
    /// Số:    /GKSK-......... Số:        /GKSKLX-...
    /// </summary>
    public string? SoGkskSoGksklx { get; set; }

    /// <summary>
    /// Số: ……../20…/GCT Số Hồ sơ: …… Vào sổ chuyển tuyến số
    /// </summary>
    public string? SoGiayChuyenTuyen { get; set; }

    /// <summary>
    /// Mã đơn thuốc
    /// </summary>
    public string? MaDonThuoc { get; set; }
}
