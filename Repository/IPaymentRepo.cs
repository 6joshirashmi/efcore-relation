using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public interface IPaymentRepo
    {
        
        
        public int AddOrderPayment(PaymentDTO customer);
       
        public List<CustomerPaymentDTO> GetCustomersPaymentListById(int id);
        

    }
}