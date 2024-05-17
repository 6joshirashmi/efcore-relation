using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public class PaymentServices : IPaymentServices
    { private readonly IPaymentServices _paymentServices;
  public  PaymentServices(IPaymentServices paymentServices)
    {
_paymentServices=paymentServices;
    }
        public int AddCustomerPayment(CustomerPaymentDTO customer)
        {
            return _paymentServices.AddCustomerPayment(customer);
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById(int id)
        {
           return _paymentServices.GetCustomersPaymentListById(id);
        }
    }
}