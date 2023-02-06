namespace API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Domain.Model;
using Infrastructure;
using System.Diagnostics;
using API.Model.User;

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

    [HttpGet]
    [Route("Users")]
    public ActionResult<List<User>> Get()
    {
        try
        {
            List<User> users = _userRepository.GetAllUsers();
            return users;

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetAllUsers", e);
            return NotFound();
        }
    }

    [HttpGet]
    [Route("Posts")]
    public ActionResult<List<Post>> GetPosts()
    {
        try
        {
            List<Post> posts = _userRepository.GetAllPosts();
            return Ok(posts);

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetAllUserPosts", e);
            return NotFound();
        }
    }

    [HttpGet]
    [Route("Posts/{id:int}")]
    public ActionResult<List<Post>> GetUserPosts(int id)
    {
        try
        {
            List<Post> posts = _userRepository.GetUserPosts(id);
            return Ok(posts);

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetUserPosts", e);
            return NotFound();
        }
    }


    [HttpPost]
    [Route("User/Create")]
    public ActionResult<List<Post>> CreateUser([FromBody] APIUser user)
    {
        try
        {
            Debug.Print("username " + user.FirstName + " user email " + user.LastName); ;
            return Ok();

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetUserPosts", e);
            return NotFound();
        }
    }

    [HttpPost]
    [Route("User/Update")]
    public ActionResult<List<Post>> UpdateUser([FromBody] APIUser user)
    {
        try
        {
            return Ok();

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetUserPosts", e);
            return NotFound();
        }
    }

    [HttpDelete]
    [Route("User/Delete")]
    public ActionResult<List<Post>> DeleteUserPost([FromBody] APIUser user)
    {
        try
        {
            // we only delete the user but not the posts

            return Ok();

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetUserPosts", e);
            return NotFound();
        }
    }
}