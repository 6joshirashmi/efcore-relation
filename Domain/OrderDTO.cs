using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class OrderDTO
    {
          public string? OrderNumber { get; set; }
        public decimal TotalAmount { get; set; }
      
        public bool IsCompleted { get; set; }
       

  public int CustomerId { get; set; }
    }
}