using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DI.Interface
{
    public class Customer
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Email { get; set; }
        public String? PhoneNumber { get; set; }
    }
    public interface ICustomer
    {
        Customer GetCustomer(int customerId);
    }
}
