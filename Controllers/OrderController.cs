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
        public IActionResult AddCustomersOrder(CustomerOrderDTO customer)
        {
            return Ok(_orderServices.AddCustomersOrder(customer));
        }

        [HttpGet("GetCustomersOrderById")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomersOrderById(int id)
        {
            return Ok(_orderServices.GetCustomersOrderById(id));
        }
        [HttpPost("UpdateOrder")]
        public IActionResult UpdateOrder(Order order)
        {
            return Ok(_orderServices.UpdateOrder(order));
        }

    }
}