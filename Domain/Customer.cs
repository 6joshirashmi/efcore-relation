using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcorejoin.Domain
{
    public class Customer
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

 

     // Navigation property for the associated order
   public IEnumerable<Order>? Order{get;set;}
    }
}