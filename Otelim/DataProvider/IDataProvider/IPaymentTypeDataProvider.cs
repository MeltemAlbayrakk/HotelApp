using Otelim.Models;

namespace Otelim.DataProvider.IDataProvider
{
    public interface IPaymentTypeDataProvider
    {
        string Add(PaymentType paymentType);
        string Delete(PaymentType paymentType);
    }
}
