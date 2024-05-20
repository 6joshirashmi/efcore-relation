using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class OrderPaymentDTO
    {
                public int PaymentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string? PaymentMethod { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }

       public string? TransactionId { get; set; }


    }
}