using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcorejoin.Domain;
using efcorejoin.Infra;

namespace efcorejoin.Repository
{
    public class PaymentRepo : IPaymentRepo
    {

        private readonly Efcoredb _efcoredb;



        public PaymentRepo(Efcoredb efcoredb)
        {
            _efcoredb = efcoredb;
        }
        public int AddOrderPayment(PaymentDTO customerPaymentDTO)
        {
            Payment payment = new Payment
            {
                Amount = customerPaymentDTO.Amount,             
                PaymentMethod = customerPaymentDTO.PaymentMethod,
                Currency = customerPaymentDTO.Currency,
                Status = customerPaymentDTO.Status,
                Description = customerPaymentDTO.Description,
                TransactionId = customerPaymentDTO.TransactionId,
                OrderId = customerPaymentDTO.OrderId
            };
            _efcoredb.payments.Add(payment);
            _efcoredb.SaveChanges();
            return 1;
        }


        public List<CustomerPaymentDTO> GetCustomersPaymentListById(int id)
        {//query syntex
            return (from c in _efcoredb.customers
                    join p in _efcoredb.payments
                    on c.CustomerId equals p.OrderId
                    where c.CustomerId == id
                    select new CustomerPaymentDTO
                    {
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
    }
}