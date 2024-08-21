using Practica_DI.Interface;

namespace Practica_DI.Repository
{
    public class CustomerRepository : ICustomer
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer
            {
                Id = customerId,
                Name = "Pedro Peguero",
                Email = "marquite@gmail.es",
                PhoneNumber = "223-232-0000"
            };
        }
    }
}
