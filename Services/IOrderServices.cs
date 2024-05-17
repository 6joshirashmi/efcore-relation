using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public interface IOrderServices
    {        
        public int AddCustomersOrder(CustomerOrderDTO  customerOrderDTO);
        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId);      

    }
}