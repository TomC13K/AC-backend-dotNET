using AC_backend.Entities;
using AC_backend.Models;

namespace AC_backend.Services;

public interface ICustomerService
{
    Customer GetCustomerById(int id);
    //IEnumerable<Customer> GetAll();
    //Customer GetById(int id);
    // void Create(CreateRequest model);
    // void Update(int id, UpdateRequest model);
    // void Delete(int id);
}


public class CustomerService : ICustomerService
{
    private DataContext _context;
    
    public CustomerService(DataContext context)
    {
        _context = context;
    }
    
    public Customer GetCustomerById(int id)
    {
        return GetCustomer(id);      
    }
    
    private Customer GetCustomer(int id)
    {
        Console.WriteLine("given ID = " + id );
        var user = _context.Customers.Find(id);
        if (user == null) throw new KeyNotFoundException("User not found");
        return user;
    }
}