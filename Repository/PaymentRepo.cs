using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class PaymentRepo : IPaymentRepo
    { 
        
         private readonly Efcoredb _efcoredb;

           

        public PaymentRepo(Efcoredb efcoredb)
        {
           _efcoredb=efcoredb;
        }
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