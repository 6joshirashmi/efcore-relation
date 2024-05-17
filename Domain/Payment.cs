using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string? PaymentMethod { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }

       public string? TransactionId { get; set; }
// Foreign key property
  public int CustomerId { get; set; }
   // Navigation property for the associated order
   public Customer? Customer{get; set;}
// //Foreign key property
//    public int OrderId {get; set;}
//     // Navigation property for the associated order
//    public Order? Order{get; set;}
    }
}