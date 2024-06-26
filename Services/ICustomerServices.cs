using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public interface ICustomerServices
    {
         public int AddCustomer(Customer customer);    
         public Customer UpdateCustomer(Customer customer);
        public IEnumerable<Customer> GetCustomerList();   
        public IEnumerable<CustomerOrderDTO> GetCustomerOrderDetail();        
        public IEnumerable<CustomerPaymentDTO> GetCustomerPaymentDetail();
        public IEnumerable<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetail();
        public List<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetailById(int customerId);
          public CustomerOrderPaymentDTO GetCustomerPaymentDetailByOrderId(int orderid);
    }
}

