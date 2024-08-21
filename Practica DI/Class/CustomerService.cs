using Practica_DI.Interface;
using Practica_DI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DI.Class
{
    public class CustomerService
    {
        private readonly ICustomer _customer;

        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }

        public Customer FindCustomer(int customerId)
        {
            return _customer.GetCustomer(customerId);
        }
    }
}
