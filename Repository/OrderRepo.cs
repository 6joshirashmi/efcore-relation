using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class OrderRepo : IOrderRepo
    {  
        private readonly Efcoredb _efcoredb;

        public OrderRepo(Efcoredb efcoredb)
        {
           _efcoredb=efcoredb;
        }
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