using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Repository;

namespace efcorejoin.Services
{
    public class PaymentServices : IPaymentServices
    { private readonly IPaymentRepo _paymentRepo;
  public  PaymentServices(IPaymentRepo paymentRepo)
    {
_paymentRepo=paymentRepo;
    }
        public int AddOrderPayment(PaymentDTO payment)
        {
            return _paymentRepo.AddOrderPayment(payment);
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById(int id)
        {
           return _paymentRepo.GetCustomersPaymentListById(id);
        }
    }
}