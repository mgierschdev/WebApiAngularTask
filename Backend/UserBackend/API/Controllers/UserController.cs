namespace API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Infrastructure;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController> _logger;
    private readonly IUserRepository _userRepository = new UserRepository();

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllUsers")]
    public IEnumerable<User> Get()
    {
        return _userRepository.GetAllUsers();
    }
}