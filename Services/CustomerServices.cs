using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Repository;

namespace efcorejoin.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerServices(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public int AddCustomer(Customer customer)
        {
          var i=  _customerRepo.AddCustomer(customer);
          return i;
        }

        public IEnumerable<Customer> GetCustomerList()
        {
          return  _customerRepo.GetCustomerList();
        }

        public IEnumerable<CustomerOrderDTO> GetCustomerOrderDetail()
        {
            return _customerRepo.GetCustomerOrderDetail();
        }

        public IEnumerable<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetail()
        {
            return _customerRepo.GetCustomerOrderPaymentDetail();
        }

        public List<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetailById(int customerId)
        {
            return _customerRepo.GetCustomerOrderPaymentDetailById(customerId);
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomerPaymentDetail()
        {
            return _customerRepo.GetCustomerPaymentDetail();
        }
    }
}