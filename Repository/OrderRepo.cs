using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly Efcoredb _efcoredb;

        public OrderRepo(Efcoredb efcoredb)
        {
            _efcoredb = efcoredb;
        }
        public int AddCustomersOrder(CustomerOrderDTO customerOrderDTO)
        {
            // Customer customer = new Customer
            // {
            //     CustomerId = customerOrderDTO.CustomerId,
            //     FirstName = customerOrderDTO.FirstName,
            //     LastName = customerOrderDTO.LastName,
            //     Email = customerOrderDTO.Email,
            //     Phone = customerOrderDTO.Phone,
            //     Address = customerOrderDTO.Address,
            //     City = customerOrderDTO.City,
            //     State = customerOrderDTO.State,
            //     ZipCode = customerOrderDTO.ZipCode,
            //     RegistrationDate = customerOrderDTO.RegistrationDate
            // };
            Order order = new Order
            {
                CustomerId = customerOrderDTO.CustomerId,
                OrderNumber = customerOrderDTO.OrderNumber,
                TotalAmount = customerOrderDTO.TotalAmount,
                OrderDate = customerOrderDTO.OrderDate,
                IsCompleted = customerOrderDTO.IsCompleted
            };
            //_efcoredb.customers.Add(customer);
            _efcoredb.orders.Add(order);
            _efcoredb.SaveChanges();
            return 1;
        }

        public List<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {
            
       return  (from c in _efcoredb.customers
               join o in _efcoredb.orders
               on c.CustomerId equals o.CustomerId
               where o.CustomerId == CustomerId
               select new CustomerOrderDTO { 
                OrderId = o.OrderId, CustomerId = o.CustomerId, FirstName = c.FirstName ,  
                LastName =c.LastName,Email =c.Email,Phone =c.Phone,Address =c.Address,City =c.City,
                State =c.State,ZipCode =c.ZipCode,RegistrationDate =c.RegistrationDate,OrderNumber = o.OrderNumber,
                TotalAmount =o.TotalAmount,OrderDate =o.OrderDate,IsCompleted =o.IsCompleted
                }
                )
              .ToList();
        }

      
    }
}