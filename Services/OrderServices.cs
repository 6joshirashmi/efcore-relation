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
        public int AddCustomersOrder(OrderDTO customerOrderDTO)
        {
            return _orderRepo.AddCustomersOrder(customerOrderDTO);
        }

        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {
            return _orderRepo.GetCustomersOrderById(CustomerId);
        }
        public Order UpdateOrder(Order order)
        {
            return _orderRepo.UpdateOrder(order);
        }
        public OrderPaymentDTO GetPaymentDetailByOrderId(int orderid)
        {
            return _orderRepo.GetPaymentDetailByOrderId(orderid);
        }
        public CustomerOrderDTO GetCustomerOrderDetailByOrderId(int orderid)
        {
            return _orderRepo.GetCustomerOrderDetailByOrderId(orderid);
        }
        public CustomerOrderPaymentDTO CustomerOrderPaymentDetails()
        {
            return _orderRepo.CustomerOrderPaymentDetails();
        }

        public IEnumerable<Order> GetOrderList()
        {
            return _orderRepo.GetOrderList();
        }
        public decimal GetOrderAmountByHighstNumber(int highestnumber)
        {
            return _orderRepo.GetOrderAmountByHighstNumber(highestnumber);
        }
    }
}