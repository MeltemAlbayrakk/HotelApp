using Otelim.Context;
using Otelim.Models;

namespace Otelim.DataProvider.EFDataProvider
{
    public class EFPaymentTypeDataProvider : IGenericDataProvider<PaymentType>
    {
        public void Add(PaymentType paymentType)
        {
            using (var ctx = new HotelContext())
            {
                ctx.PaymentTypes.Add(paymentType);
                ctx.SaveChanges();
            }
        }

        public void Delete(PaymentType paymentType)
        {
            using (var ctx = new HotelContext())
            {
                ctx.PaymentTypes.Remove(paymentType);
                ctx.SaveChanges();
            }
        }

        public List<PaymentType> GetList()
        {
            using (var ctx = new HotelContext())
            {
                var result = ctx.PaymentTypes.ToList();
                return result;
            }
        }
    }
}
