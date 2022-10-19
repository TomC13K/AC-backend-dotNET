using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AC_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : Controller
{
    private Customer data = new()
    {
        customerID = 1,
        firstName = "Johny",
        lastName = "Deeep",
        businessName= "business 1",
        phone = "0123456789",
        emailName="email@email.com",
        ico="12345646",
        dic="RR123465",
        street="11 Under Bridge",
        town = "ToyTown",
        psc= "GG4456"
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