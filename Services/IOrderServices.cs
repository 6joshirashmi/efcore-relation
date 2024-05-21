using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;

namespace efcorejoin.Services
{
    public interface IOrderServices
    {        
        public int AddCustomersOrder(OrderDTO  customerOrderDTO);
        public IEnumerable<CustomerOrderDTO> GetCustomersOrderById(int CustomerId);      
public Order UpdateOrder(Order order);
  public OrderPaymentDTO GetPaymentDetailByOrderId(int orderid);
  public   CustomerOrderDTO GetCustomerOrderDetailByOrderId(int orderid);
   public CustomerOrderPaymentDTO CustomerOrderPaymentDetails();
     public IEnumerable<Order> GetOrderList();       
        public decimal GetOrderAmountByHighstNumber(int highestnumber);
    }
}