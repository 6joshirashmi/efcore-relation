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
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost("AddCustomerPayment")]
        public IActionResult AddCustomerPayment(Customer customer)
        {

        }

        [HttpGet("GetCustomersPaymentListById")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomersPaymentListById(int customerId)
        {

        }

       
    }
}