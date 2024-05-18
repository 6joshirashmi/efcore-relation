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
        public int AddCustomerPayment(CustomerPaymentDTO customerPaymentDTO)
        {
          //  _efcoredb.payments.Add(customerPaymentDTO);
            _efcoredb.SaveChanges();
            return 1;
        }


        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById(int id)
        {
            throw new NotImplementedException();
        }
    }
}