using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public class PaymentRepo : IPaymentRepo
    {
        public int AddCustomerPayment(CustomerPaymentDTO customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById()
        {
            throw new NotImplementedException();
        }
    }
}