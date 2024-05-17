using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderServices _orderServices;
        public OrderServices(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        public int AddCustomersOrder(CustomerOrderDTO customerOrderDTO)
        {
            return _orderServices.AddCustomersOrder(customerOrderDTO);
        }

        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {
            return _orderServices.GetCustomersOrderById(CustomerId);
        }
    }
}