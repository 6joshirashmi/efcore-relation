using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly Efcoredb _efcoredb;
        public CustomerRepo(Efcoredb efcoredb)
        {
            _efcoredb = efcoredb;
        }
        public int AddCustomer(Customer customer)
        {
          var c=  _efcoredb.Add(customer);
            _efcoredb.SaveChanges();  
              return 1;
        }
public Customer UpdateCustomer(Customer customer)
{
var existingCustomer =(from c in _efcoredb.customers
where c.CustomerId==customer.CustomerId
select c
// new  Customer {
//                             CustomerId = c.CustomerId,
//                             FirstName = c.FirstName,
//                             LastName =c.LastName,
//                             Email =c.Email,
//                             Phone =c.Phone,
//                             Address =c.Address,
//                             City =c.City,
//                             State =c.State,
//                             ZipCode =c.ZipCode
// }
).FirstOrDefault();
      //  .Where(cs => cs.CustomerId == customer.CustomerId)
       // .FirstOrDefault();

    if (existingCustomer == null)
    {
        _efcoredb.Add(customer);
        _efcoredb.SaveChanges();
    }
    else
    {
        // Update existing customer properties
        existingCustomer.FirstName = customer.FirstName;
        existingCustomer.LastName = customer.LastName;
        existingCustomer.Email = customer.Email;
        existingCustomer.Phone = customer.Phone;
        existingCustomer.Address = customer.Address;
        existingCustomer.City = customer.City;
        existingCustomer.State = customer.State;
        existingCustomer.ZipCode = customer.ZipCode;
        _efcoredb.Update(existingCustomer);
        _efcoredb.SaveChanges();
    }

    return existingCustomer;
}

        public IEnumerable<Customer> GetCustomerList()
        {
          return  _efcoredb.customers.ToList();
        }

        public IEnumerable<CustomerOrderDTO> GetCustomerOrderDetail()
        {// Method syntex
         return   _efcoredb.customers
    .Join(_efcoredb.orders,
          c => c.CustomerId,
          o => o.CustomerId,
          (c, o) => new CustomerOrderDTO { 
             OrderId = o.OrderId, CustomerId = o.CustomerId, FirstName = c.FirstName ,  
                LastName =c.LastName,Email =c.Email,Phone =c.Phone,Address =c.Address,City =c.City,
                State =c.State,ZipCode =c.ZipCode,RegistrationDate =c.RegistrationDate,OrderNumber = o.OrderNumber,
                TotalAmount =o.TotalAmount,OrderDate =o.OrderDate,IsCompleted =o.IsCompleted
            }
            )
   
    .ToList();
        }

        public IEnumerable<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetail()
        {//method syntex

      
            return  _efcoredb.customers
                    .Join(
                    _efcoredb.orders,c=>c.CustomerId,o=>o.CustomerId,
                    (c,o)=> new { Customer = c, Order = o })
                    .Join(_efcoredb.payments,co=>co.Order.OrderId,p=>p.OrderId,
                    (co,p)=> new  CustomerOrderPaymentDTO{
                            CustomerId = co.Customer.CustomerId,
                            FirstName = co.Customer.FirstName,
                            LastName =co.Customer.LastName,
                            Email =co.Customer.Email,
                            Phone =co.Customer.Phone,
                            Address =co.Customer.Address,
                            City =co.Customer.City,
                            State =co.Customer.State,
                            ZipCode =co.Customer.ZipCode,
                            Amount = p.Amount,
                            PaymentDate = p.PaymentDate,
                            PaymentMethod = p.PaymentMethod,
                            Currency = p.Currency,
                            Status = p.Status,
                            Description = p.Description,
                            TransactionId = p.TransactionId,
                            TotalAmount=co.Order.TotalAmount,
                            OrderNumber=co.Order.OrderNumber,
                            OrderId = p.OrderId,
                            PaymentId=p.PaymentId
                    }).ToList();
             
        }

        public List<CustomerOrderPaymentDTO> GetCustomerOrderPaymentDetailById(int customerId)
        {
            
                   
          return _efcoredb.customers
          .Join( _efcoredb.orders, c=> c.CustomerId , o => o.CustomerId, (c,o) => new { Customer=c , Order=o})
          .Join( _efcoredb.payments, co => co.Order.OrderId,p => p.OrderId ,(co , p)=> new CustomerOrderPaymentDTO{
            CustomerId = co.Customer.CustomerId,
                            FirstName = co.Customer.FirstName,
                            LastName =co.Customer.LastName,
                            Email =co.Customer.Email,
                            Phone =co.Customer.Phone,
                            Address =co.Customer.Address,
                            City =co.Customer.City,
                            State =co.Customer.State,
                            ZipCode =co.Customer.ZipCode,
                            Amount = p.Amount,
                            PaymentDate = p.PaymentDate,
                            PaymentMethod = p.PaymentMethod,
                            Currency = p.Currency,
                            Status = p.Status,
                            Description = p.Description,
                            TransactionId = p.TransactionId,
                            TotalAmount=co.Order.TotalAmount,
                            OrderNumber=co.Order.OrderNumber,
                            OrderId = p.OrderId,
                            PaymentId=p.PaymentId
          }
          ).Where(c=> c.CustomerId==customerId).ToList();
        }

        public IEnumerable<CustomerPaymentDTO> GetCustomerPaymentDetail()
        {
            return _efcoredb.customers
            .Join(_efcoredb.payments,
            c => c.CustomerId,p=> p.OrderId,
            (c,p)=> new CustomerPaymentDTO{
                CustomerId = c.CustomerId,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Email = c.Email,
                        Phone = c.Phone,
                        Address = c.Address,
                        City = c.City,
                        State = c.State,
                        ZipCode = c.ZipCode,
                        RegistrationDate = c.RegistrationDate,
                        PaymentId = p.PaymentId,
                        Amount = p.Amount,
                        PaymentDate = p.PaymentDate,
                        PaymentMethod = p.PaymentMethod,
                        Currency = p.Currency,
                        Status = p.Status,
                        Description = p.Description,
                        TransactionId = p.TransactionId
            }
            ).ToList();
        }


        public CustomerOrderPaymentDTO GetCustomerPaymentDetailByOrderId(int orderid)
        {

 return (from c in _efcoredb.customers
 join o in _efcoredb.orders 
 on c.CustomerId equals o.CustomerId
 join p in _efcoredb.payments
 on o.OrderId equals p.OrderId
 where o.OrderId==orderid
 select new CustomerOrderPaymentDTO{
  CustomerId = c.CustomerId,
                            FirstName = c.FirstName,
                            LastName =c.LastName,
                            Email =c.Email,
                            Phone =c.Phone,
                            Address =c.Address,
                            City =c.City,
                            State =c.State,
                            ZipCode =c.ZipCode,
                            Amount = p.Amount,
                            PaymentDate = p.PaymentDate,
                            PaymentMethod = p.PaymentMethod,
                            Currency = p.Currency,
                            Status = p.Status,
                            Description = p.Description,
                            TransactionId = p.TransactionId,
                            TotalAmount=o.TotalAmount,
                            OrderNumber=o.OrderNumber,
                            OrderId = p.OrderId,
                            PaymentId=p.PaymentId
 }).FirstOrDefault();
   

        }
    }
}