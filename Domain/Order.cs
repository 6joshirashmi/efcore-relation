using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class Order
    {
       public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCompleted { get; set; }
       
  // Foreign key property
  public int CustomerId { get; set; }
   // Navigation property for the associated order
   public Customer? Customer{get; set;}
    }
}