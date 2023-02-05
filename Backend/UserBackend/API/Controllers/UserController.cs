namespace API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Domain.Model;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllUsers")]
    public IEnumerable<User> Get()
    {
        List<User> clientList = new List<User>();
        for(int  i = 0; i < 5; i++)
        {
            clientList.Add(new User("TestName", "TestLastName", "TestEmail", "(+43)12345678", new Role("User")));
        }

        return clientList;//Enumerable.Range(1, 5).Select(index => clientList).ToArray();
    }
}

