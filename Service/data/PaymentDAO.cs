using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.data
{
    public class PaymentDAO : IPaymentDAO
    {
        private List<Payment> payments;

        public PaymentDAO()
        {
            payments = new List<Payment>();
        }


        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public Payment RemovePayment(int id)
        {
            Payment payment = payments[id];

            payments.Remove(payment);

            return payment;
        }

        public IEnumerable<Payment> GetPayments()
        {
            return payments;
        }

        public Payment GetPayment(int id)
        {
            return payments[id];
        }
    }
}
