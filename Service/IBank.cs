using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [ServiceContract]
    public interface IBank
    {
        [OperationContract]
        void CreatePayment(string ccNumber, double amount);
        [OperationContract]
        Payment GetPayment(int id);
        [OperationContract]
        IEnumerable<Payment> GetPayments();


    }
}
