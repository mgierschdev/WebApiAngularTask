namespace API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Infrastructure;
using System.Diagnostics;

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
    public ActionResult<List<User>> Get()
    {
        return Ok(_userRepository.GetAllUsers());
    }
}