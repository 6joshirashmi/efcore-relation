using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace efcorejoin.Controllers
{
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IOrderServices orderServices)
        {
            _logger = logger;
            _orderServices = orderServices;
        }


        [HttpPost("AddCustomersOrder")]
        public IActionResult AddCustomersOrder(OrderDTO customer)
        {
            return Ok(_orderServices.AddCustomersOrder(customer));
        }
         [HttpGet("GetOrderList")]
        public IActionResult GetOrderList()
        {
            return Ok(_orderServices.GetOrderList());
        }

         [HttpGet("GetOrderAmountByHighstNumber")]
        public IActionResult GetOrderAmountByHighstNumber(int highestnumber)
        {
            return Ok(_orderServices.GetOrderAmountByHighstNumber(highestnumber));
        }

        [HttpGet("GetCustomersOrderByCustomerId")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomersOrderByCustomerId(int customerid)
        {
            return Ok(_orderServices.GetCustomersOrderById(customerid));
        }
        [HttpPost("UpdateOrder")]
        public IActionResult UpdateOrder(Order order)
        {
            return Ok(_orderServices.UpdateOrder(order));
        }
        [HttpGet("GetPaymentDetailByOrderId")]
        public IActionResult GetPaymentDetailByOrderId(int orderid)
        {
            return Ok(_orderServices.GetPaymentDetailByOrderId(orderid));
        }
        [HttpGet("GetCustomerOrderDetailByOrderId")]
        public IActionResult GetCustomerOrderDetailByOrderId(int orderid)
        {
            return Ok(_orderServices.GetCustomerOrderDetailByOrderId(orderid));
        }
        [HttpGet("CustomerOrderPaymentDetails")]
         public IActionResult CustomerOrderPaymentDetails()
         {
return Ok(_orderServices.CustomerOrderPaymentDetails());
         }
    }
}