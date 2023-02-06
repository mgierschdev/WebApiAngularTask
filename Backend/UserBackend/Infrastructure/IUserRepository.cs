namespace Infrastructure;

using System;
using Domain.Model;

public interface IUserRepository
{
    public List<User> GetAllUsers();
    public List<Post> GetAllPosts();
    public List<Post> GetUserPosts(int id);
}