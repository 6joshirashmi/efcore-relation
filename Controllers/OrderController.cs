using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace efcorejoin.Controllers
{
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }


        [HttpPost("AddCustomersOrder")]
        public IActionResult AddCustomersOrder(Customer customer)
        {

        }

        [HttpGet("GetCustomersOrder")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomersOrder()
        {

        }

      
    }
}