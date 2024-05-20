using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class CustomerPaymentDTO
    {
          public int CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
     public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public DateTime RegistrationDate { get; set; }
      public int PaymentId { get; set; }
        public int OrderId {get; set;}
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
 public string? PaymentMethod { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }

       public string? TransactionId { get; set; }
    }
}