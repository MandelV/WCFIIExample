using Service.data;
using System.Collections.Generic;

namespace Service
{
    public class BankService : IBank
    {
        private IPaymentDAO paymentDAO = new PaymentDAO();
        public void CreatePayment(string ccNumber, double amount)
        {

            paymentDAO.AddPayment(new Payment(ccNumber, amount));
        }

        public Payment GetPayment(int id)
        {
            return paymentDAO.GetPayment(id);
        }

        public IEnumerable<Payment> GetPayments()
        {
            return paymentDAO.GetPayments();
        }
    }
}