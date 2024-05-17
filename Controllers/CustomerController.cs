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
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerServices _customerServices;

        public CustomerController(ILogger<CustomerController> logger, ICustomerServices customerServices)
        {
            _logger = logger;
            _customerServices = customerServices;

        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            return Ok( _customerServices.AddCustomer(customer));
        }

        [HttpGet("GetCustomer")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomer()
        {
            return Ok(_customerServices.GetCustomerList());
        }

        [HttpGet("GetCustomerOrderDetail")]
        public IActionResult GetCustomerOrderDetail()
        {
            return Ok(_customerServices.GetCustomerOrderDetail());
        }
        [HttpGet("GetCustomerPaymentDetail")]
        public IActionResult GetCustomerPaymentDetail()
        {
            return Ok(_customerServices.GetCustomerPaymentDetail());
        }

        [HttpGet("GetCustomerOrderPaymentDetail")]
        public IActionResult GetCustomerOrderPaymentDetail()
        {
            return Ok(_customerServices.GetCustomerOrderPaymentDetail());
        }


        [HttpGet("GetCustomerOrderPaymentDetailById")]
        public IActionResult GetCustomerOrderPaymentDetail(int customerId)
        {
            return Ok(_customerServices.GetCustomerOrderPaymentDetailById(customerId));
        }
    }
}