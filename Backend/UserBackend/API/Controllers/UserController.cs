﻿namespace API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Infrastructure.Model;
using Infrastructure;
using System.Diagnostics;
using Domain.User;
using Domain.Validator;
using Domain.Util;

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
    [Route("All")]
    public ActionResult<List<User>> Get()
    {
        try
        {
            List<User> users = _userRepository.GetAllUsers();
            return users;

        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred GetAllUsers", e.ToString());
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
            _logger.LogError("Error ocurred GetAllUserPosts", e.ToString());
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
            _logger.LogError("Error ocurred GetUserPosts", e.ToString());
            return NotFound();
        }
    }


    [HttpPost]
    [Route("Create")]
    public ActionResult<List<Post>> CreateUser([FromBody] APIUser user)
    {
        try
        {
            UserValidator userValidator = new UserValidator();
            APIResponse response = userValidator.ValidateNewUser(user);


            if(response.Code != HTTP_STATUS.OK)
            {
                return BadRequest(response.Message);
            }
            else if(!_userRepository.CreateUser(user))
            {
                // backend problem
                return BadRequest("Could not save");
            }

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred CreateUser", e.ToString());
            return NotFound();
        }
    }

    [HttpPost]
    [Route("Update")]
    public ActionResult<List<Post>> UpdateUser([FromBody] APIUser user)
    {
        try
        {
            UserValidator userValidator = new UserValidator();
            APIResponse response = userValidator.ValidateUserUpdate(user);

            if (response.Code != HTTP_STATUS.OK)
            {
                return BadRequest(response.Message);
            }
            else if (!_userRepository.UpdateUser(user))
            {
                // backend problem
                return BadRequest("Could not save");
            }

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred UpdateUser", e.ToString());
            return NotFound();
        }
    }

    [HttpDelete]
    [Route("Delete")]
    public ActionResult<List<Post>> DeleteUserPost([FromBody] APIUser user)
    {
        try
        {
            UserValidator userValidator = new UserValidator();
            APIResponse response = userValidator.ValidateDelete(user);

            if (response.Code != HTTP_STATUS.OK)
            {
                return BadRequest(response.Message);
            }
            else if (!_userRepository.DeleteUser(user))
            {
                // backend problem
                return BadRequest("Could not save");
            }

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred DeleteUserPost", e.ToString());
            return NotFound();
        }
    }
}