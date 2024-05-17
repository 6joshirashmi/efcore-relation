using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Repository
{
    public interface IOrderRepo
    {
        
        public int AddCustomersOrder(CustomerOrderDTO  customerOrderDTO);
        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId);
       

    }
}