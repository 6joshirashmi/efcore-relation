using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        public int AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrderDTO> GetCustomerOrderDetail()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetail()
        {
            throw new NotImplementedException();
        }

        public CustomerOrderPaymentDTO GetCustomerOrderPaymentDetailById(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomerPaymentDetail()
        {
            throw new NotImplementedException();
        }
    }
}