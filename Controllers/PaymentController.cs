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
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentServices _paymentServices;

        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger, IPaymentServices paymentServices)
        {
            _logger = logger;
            _paymentServices = paymentServices;
        }

        [HttpPost("AddCustomerPayment")]
        public IActionResult AddOrderPayment(PaymentDTO payment)
        {
            return Ok(_paymentServices.AddOrderPayment(payment));
        }

        [HttpGet("GetCustomersPaymentListById")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult GetCustomersPaymentListById(int customerId)
        {
            return Ok(_paymentServices.GetCustomersPaymentListById(customerId));
        }


    }
}