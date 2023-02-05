﻿namespace Infrastructure;

using System;
using Domain.Model;
using Domain.Util;
using Microsoft.EntityFrameworkCore;


public class UserRepository : IUserRepository
{
    public UserRepository()
    {

        // we load in ourcase the memory database, in which a different case the context could be a different DB SQL/non-SQL or a different provider
        using (ApiContext context = new ApiContext())
        {;
            context.Users.AddRange(new List<User>()
            {
                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post>() {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post>() {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post>() {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post>() {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}}
            });
            context.SaveChanges();
        }
    }

    public List<User> GetAllUsers()
    {
        // We get the data from the contextDB
        using (ApiContext context = new ApiContext())
        {
            // here we can filter the result
            List<User> users = context.Users
                .Include(a => a.Posts)
                .ToList();
            return users;
        }
    }
}