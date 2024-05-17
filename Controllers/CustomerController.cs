using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace efcorejoin.Controllers
{
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {

        }

        [HttpGet("GetCustomer")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomer()
        {

        }

        [HttpGet("GetCustomerOrderDetail")]
        public IActionResult GetCustomerOrderDetail()
        {

        }
        [HttpGet("GetCustomerPaymentDetail")]
        public IActionResult GetCustomerPaymentDetail()
        {

        }

        [HttpGet("GetCustomerOrderPaymentDetail")]
        public IActionResult GetCustomerOrderPaymentDetail()
        {

        }


        [HttpGet("GetCustomerOrderPaymentDetailById")]
        public IActionResult GetCustomerOrderPaymentDetail(CustomerId customerId)
        {

        }
    }
}