﻿namespace Infrastructure;

using System;
using Infrastructure.Model;

public interface IUserRepository
{
    public List<User> GetAllUsers();
    public List<Post> GetAllPosts();
    public List<Post> GetUserPosts(int id);
    public Boolean CreateUser(User user);
}