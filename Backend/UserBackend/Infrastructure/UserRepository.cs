﻿namespace Infrastructure;

using System;
using System.Diagnostics;
using Domain.User;
using Infrastructure.Model;
using Infrastructure.Helper;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly ApiContext context;
    private Util util;

    public UserRepository()
    {
        context = new ApiContext();
        util = new Util();
        // We get current records if empty we insert the mock users
        // since the users can be persisted in mem for a limited time
        // this is just for development and presentation purposes 
        List<User> users = GetAllUsers();

        if(users.Count <= 0)
        {
            // we load in ourcase the memory database, in which a different case the context could be a different DB SQL/non-SQL or a different provider
            Util util = new Util();
            context.Users.AddRange(util.GetMockUserList());
            context.SaveChanges();
        }
    }

    public List<User> GetAllUsers()
    {
        // We get the data from the contextDB
        // here we can filter the result
        List<User> users = context.Users
            .Include(a => a.Posts)
            .ToList();
        return users == null ? new List<User>() : users;
    }

    public List<Post> GetAllPosts()
    {
        return context.Posts.ToList();
    }

    public List<Post> GetUserPosts(int id)
    {
        User? user = context.Users.Include(a => a.Posts).FirstOrDefault(a => a.Id == id);
          
        return user == null || user.Posts == null ? new List<Post>() : user.Posts;
    }

    public Boolean CreateUser(APIUser user)
    {
        User save = new User(user);
        context.Users.Add(save);
        return context.SaveChanges() > 0;
    }

    public Boolean UpdateUser(APIUser user)
    {
        User? save = context.Users.FirstOrDefault(a => a.Id == user.Id);

        // we rewrite the user for the fields that are not null
        save?.Update(user);
        if (save == null)
        {
            return false;
        }

        context.Users.Entry(save).State = EntityState.Modified;
        return context.SaveChanges() > 0;
    }

    public Boolean DeleteUser(APIUser user)
    {
        context.Remove(context.Users.Single(a => a.Id == user.Id));
        return context.SaveChanges() > 0;
    }
}
