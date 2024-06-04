using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

/// <summary>
/// Số tiền từng chỉ định dịch vụ
/// </summary>
public partial class PatientDesignateServiceMoney
{
    public Guid PatientDesignateServiceMoneyId { get; set; }

    public Guid PatientDesignateServiceId { get; set; }

    /// <summary>
    /// tiền bh thanh toán
    /// </summary>
    public double PriceInsurancePay { get; set; }

    public double? PaymentInsuranceRatio { get; set; }

    public double? PaymentServiceRatio { get; set; }

    /// <summary>
    /// Chính sách miễn giảm
    /// </summary>
    public double Discount { get; set; }

    /// <summary>
    /// thành tiền
    /// </summary>
    public double Subtotal { get; set; }

    /// <summary>
    /// nb thanh toán
    /// </summary>
    public double PatientTotal { get; set; }

    public virtual CategoryPatientDesignateService PatientDesignateService { get; set; } = null!;
}
