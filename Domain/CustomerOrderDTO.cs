using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class CustomerOrderDTO
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
     public int OrderId { get; set; }

        public string? OrderNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCompleted { get; set; }
       



    }
}