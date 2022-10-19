using AC_backend.Entities;
using AC_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AC_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : Controller
{
    private ICustomerService _customerService;
    
    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    
    private Customer data = new()
    {
        CustomerID = 1,
        FirstName = "Johny",
        LastName = "Deeep",
        BusinessName= "business 1",
        Phone = "0123456789",
        EmailName="email@email.com",
        Ico="12345646",
        Dic="RR123465",
        Street="11 Under Bridge",
        Town = "ToyTown",
        Psc= "GG4456"
    };

    [HttpGet]
    public IActionResult GetLala()
    {
        return Ok("lala");
    }
    
    [Route("getCustomer")]
    [HttpGet]
    public IActionResult GetCustomer()
    {
        var jsonFormat = JsonConvert.SerializeObject(data);
        return Ok(jsonFormat);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetCustomerById(int id)
    {
        //var jsonFormat = JsonConvert.SerializeObject(data);
        var result = _customerService.GetCustomerById(id);
        return Ok(result);
    }

    /*[HttpPost]
    public IActionResult CreateCustomer()
    {
        return Ok("lala");
    }*/

    /*[HttpPut]
    public IActionResult UpdateCustomerById()
    {
        return Ok("lala");
    }*/

    /*[HttpDelete]
    public IActionResult DeleteCustomerById()
    {
        return Ok("lala");
    }*/
}