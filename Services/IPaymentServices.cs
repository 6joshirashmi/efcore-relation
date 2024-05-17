using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public interface IPaymentServices
    {
        
        
        public int AddCustomerPayment(CustomerPaymentDTO customer);
       
        public IEnumerable<CustomerPaymentDTO> GetCustomersPaymentListById(int id);
        
    }
}