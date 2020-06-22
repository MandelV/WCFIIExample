using System.Collections.Generic;

namespace Service.data
{
    public interface IPaymentDAO
    {
        void AddPayment(Payment payment);
        Payment GetPayment(int id);
        IEnumerable<Payment> GetPayments();
        Payment RemovePayment(int id);
    }
}