using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly Efcoredb _efcoredb;
        public CustomerRepo(Efcoredb efcoredb)
        {
            _efcoredb = efcoredb;
        }
        public int AddCustomer(Customer customer)
        {
          var c=  _efcoredb.Add(customer);
            _efcoredb.SaveChanges();
            if(c!=null)
            c=c;
              return 1;
        }

        public IEnumerable<Customer> GetCustomerList()
        {
          return  _efcoredb.customers.ToList();
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