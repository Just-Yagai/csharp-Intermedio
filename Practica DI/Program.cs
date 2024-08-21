using Practica_DI.Class;
using Practica_DI.Interface;
using Practica_DI.Repository;

public class program
{
    public static void Main()
    {
        ICustomer customerRepository = new CustomerRepository();
        CustomerService customerService = new CustomerService(customerRepository);

        Customer customer = customerService.FindCustomer(1);

        Console.WriteLine($"ID: {customer.Id}");
        Console.WriteLine($"Nombre: {customer.Name}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Teléfono: {customer.PhoneNumber}");
    }
}