using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public class OrderRepo : IOrderRepo
    {
        public int AddCustomersOrder(CustomerOrderDTO customerOrderDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}