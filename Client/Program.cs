using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {



            BankClient bankClient = new BankClient();


            bankClient.CreatePayment("123456", 157);
            bankClient.CreatePayment("123456", 157);
            bankClient.CreatePayment("123456", 157);
            bankClient.CreatePayment("123456", 157);
            bankClient.CreatePayment("123456", 157);



            foreach (var payment in bankClient.GetPayments())
            {
                Console.WriteLine(payment.CcNumber + " : " + payment.Amount + " - " + payment.PaymentStatus);
            }



            while (true)
            {

            }
            

        }
    }
}
