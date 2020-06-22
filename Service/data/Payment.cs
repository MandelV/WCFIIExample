using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public string CcNumber { get; private set; } 
        [DataMember]
        public double Amount { get; private set; }
        [DataMember]
        public PaymentStatus PaymentStatus { get; set; }

        public Payment(string ccNumber, double amount)
        {
            CcNumber = ccNumber;
            Amount = amount;
            PaymentStatus = PaymentStatus.VALIDATED;
        }
    }
}