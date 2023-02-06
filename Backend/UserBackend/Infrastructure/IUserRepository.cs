namespace Infrastructure;

using System;
using Domain.User;
using Infrastructure.Model;

public interface IUserRepository
{
    public List<User> GetAllUsers();
    public List<Post> GetAllPosts();
    public List<Post> GetUserPosts(int id);
    public Boolean CreateUser(APIUser user);
    public Boolean UpdateUser(APIUser user);
    Boolean DeleteUser(APIUser user);
}