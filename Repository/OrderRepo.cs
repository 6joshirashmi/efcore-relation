using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;
using Microsoft.EntityFrameworkCore;

namespace efcorejoin.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly Efcoredb _efcoredb;

        public OrderRepo(Efcoredb efcoredb)
        {
            _efcoredb = efcoredb;
        }
        public int AddCustomersOrder(OrderDTO customerOrderDTO)
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

                IsCompleted = customerOrderDTO.IsCompleted
            };
            //_efcoredb.customers.Add(customer);
            _efcoredb.orders.Add(order);
            _efcoredb.SaveChanges();
            return 1;
        }

        public List<CustomerOrderDTO> GetCustomersOrderById(int CustomerId)
        {

            return (from c in _efcoredb.customers
                    join o in _efcoredb.orders
                    on c.CustomerId equals o.CustomerId
                    where o.CustomerId == CustomerId
                    select new CustomerOrderDTO
                    {
                        OrderId = o.OrderId,
                        CustomerId = o.CustomerId,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Email = c.Email,
                        Phone = c.Phone,
                        Address = c.Address,
                        City = c.City,
                        State = c.State,
                        ZipCode = c.ZipCode,
                        RegistrationDate = c.RegistrationDate,
                        OrderNumber = o.OrderNumber,
                        TotalAmount = o.TotalAmount,
                        OrderDate = o.OrderDate,
                        IsCompleted = o.IsCompleted
                    }
                     )
                   .ToList();
        }


        public Order UpdateOrder(Order order)
        {
            var ord = _efcoredb.orders.Where(o => o.OrderId == order.OrderId).FirstOrDefault();
            if (ord == null)
            {
                _efcoredb.Add(ord);
                _efcoredb.SaveChanges();
            }
            else
            {
                ord.OrderNumber = order.OrderNumber;
                ord.TotalAmount = order.TotalAmount;
                ord.OrderDate = order.OrderDate;
                ord.IsCompleted = order.IsCompleted;
                _efcoredb.Update(ord);
                _efcoredb.SaveChanges();
            }
            return ord;
        }


        public OrderPaymentDTO GetPaymentDetailByOrderId(int orderid)
        {//Left Outer Join Using Query Syntax
            var result = (from p in _efcoredb.payments
                          join o in _efcoredb.orders
                          on p.OrderId equals o.OrderId into payord
                          from po in payord.DefaultIfEmpty()
                          where po.OrderId == orderid
                          select new OrderPaymentDTO
                          {

                              PaymentId = p.PaymentId,
                              Amount = p.Amount,
                              PaymentDate = p.PaymentDate,
                              PaymentMethod = p.PaymentMethod,
                              Currency = p.Currency,
                              Status = p.Status,
                              Description = p.Description,
                              TransactionId = p.TransactionId,
                              OrderId = po.OrderId,
                              OrderNumber = po.OrderNumber,
                              TotalAmount = po.TotalAmount,
                              OrderDate = po.OrderDate,
                              IsCompleted = po.IsCompleted,
                              CustomerId = po.CustomerId

                          }).FirstOrDefault();

            return result;
        }
        public CustomerOrderDTO GetCustomerOrderDetailByOrderId(int orderid)
        {


            var result = _efcoredb.orders
   .Include(c => c.Customer) // Include the Order navigation property
   .Where(c => c.OrderId == orderid) // Specify a valid condition
   .FirstOrDefault(); // Use FirstOrDefault to get a single result


            var finalresult = new CustomerOrderDTO
            {
                CustomerId = result.Customer.CustomerId,
                FirstName = result.Customer.FirstName,
                LastName = result.Customer.LastName,
                Email = result.Customer.Email,
                Phone = result.Customer.Phone,
                Address = result.Customer.Address,
                City = result.Customer.City,
                State = result.Customer.State,
                ZipCode = result.Customer.ZipCode,
                RegistrationDate = result.Customer.RegistrationDate,
                OrderId = result.OrderId,
                OrderNumber = result.OrderNumber,
                TotalAmount = result.TotalAmount,
                OrderDate = result.OrderDate,
                IsCompleted = result.IsCompleted
            };

            return finalresult;
        }

        public CustomerOrderPaymentDTO CustomerOrderPaymentDetails()
        {
            var result = _efcoredb.payments
            .Include(c => c.Order)
            .ThenInclude(p => p.Customer)
            .FirstOrDefault();
            var finalresult = new CustomerOrderPaymentDTO
            {
                CustomerId = result.Order.Customer.CustomerId,
                FirstName = result.Order.Customer.FirstName,
                LastName = result.Order.Customer.LastName,
                Email = result.Order.Customer.Email,
                Phone = result.Order.Customer.Phone,
                Address = result.Order.Customer.Address,
                City = result.Order.Customer.City,
                State = result.Order.Customer.State,
                ZipCode = result.Order.Customer.ZipCode,
                RegistrationDate = result.Order.Customer.RegistrationDate,
                PaymentId = result.PaymentId,
                Amount = result.Amount,
                PaymentDate = result.PaymentDate,
                PaymentMethod = result.PaymentMethod,
                Currency = result.Currency,
                Status = result.Status,
                Description = result.Description,
                TransactionId = result.TransactionId,
                OrderId = result.OrderId,
                OrderNumber = result.Order.OrderNumber,
                TotalAmount = result.Order.TotalAmount,
                OrderDate = result.Order.OrderDate,
                IsCompleted = result.Order.IsCompleted

            };
            return finalresult;

        }

        public IEnumerable<Order> GetOrderList()
        {
            return (from o in _efcoredb.orders.OrderByDescending(s => s.TotalAmount)
                    select o).ToList();
        }
        public decimal GetOrderAmountByHighstNumber(int highestnumber)
        {
            var fifthHighestSalary = _efcoredb.orders
                            .Select(e => e.TotalAmount)            // Select the salary values
                            .Distinct()                      // Ensure distinct salary values
                            .OrderByDescending(e => e) // Order salaries in descending order
                            .Skip(highestnumber - 1)                          // Skip the 4 salaries
                            .FirstOrDefault();                // Take the 5th salary (or default if not found)
            return fifthHighestSalary;
        }
    }
}