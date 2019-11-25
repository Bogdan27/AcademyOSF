using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using RentC.Core;

namespace RentC.DataAccess.InMemory
{
    public class CustomerRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Customer> customers;

        public CustomerRepository()
        {
            customers = cache["customers"] as List<Customer>;
            if (customers == null)
            {
                customers = new List<Customer>();
            }
        }


        public void Commit()
        {
            cache["customers"] = customers;
        }

        public void Insert(Customer c)
        {
            customers.Add(c);
        }

        public void Update(Customer customer)
        {
            Customer customerToUpdate = customers.Find(c => c.Name == customer.Name);

            if (customerToUpdate != null)
            {
                customerToUpdate = customer;
            }
            else
            {
                throw new Exception("Customer not found");
            }
        }


        public Customer Find(string Name)
        {
            Customer customer = customers.Find(c => c.Name == Name);

            if (customer != null)
            {
                return customer;
            }
            else
            {
                throw new Exception("Customer not found");
            }
        }


        public IQueryable<Customer> Collection()
        {
            return customers.AsQueryable();
        }

        public void Delete(string Name)
        {
            Customer customerToDelete = customers.Find(c => c.Name == Name);

            if (customerToDelete != null)
            {
                customers.Remove(customerToDelete);
            }
            else
            {
                throw new Exception("Customer not found");
            }
        }



    }
}
