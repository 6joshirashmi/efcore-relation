using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public interface IPaymentRepo
    {
        
        
        public int AddCustomerPayment(CustomerPaymentDTO customer);
       
        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById(int id);
        

    }
}