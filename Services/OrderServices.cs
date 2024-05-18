using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Repository;

namespace efcorejoin.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepo _orderRepo;
        public OrderServices(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public int AddCustomersOrder(CustomerOrderDTO customerOrderDTO)
        {
            return _orderRepo.AddCustomersOrder(customerOrderDTO);
        }

        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {
            return _orderRepo.GetCustomersOrderById(CustomerId);
        }
    }
}