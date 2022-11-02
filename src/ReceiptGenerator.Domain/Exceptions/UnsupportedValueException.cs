using ReceiptGenerator.Domain.ValueObjects;

namespace ReceiptGenerator.Domain.Exceptions;

public class UnsupportedCouponCodeException : Exception
{
    public UnsupportedCouponCodeException(string couponCode)
        : base($"Coupon code \"{couponCode}\" is unsupported.")
    {
    }
}

public class UnsupportedTaxClassification : Exception
{
    public UnsupportedTaxClassification(TaxClassification taxClassification)
        : base($"TaxClassification \"{taxClassification}\" is unsupported")
    {
    }
}
