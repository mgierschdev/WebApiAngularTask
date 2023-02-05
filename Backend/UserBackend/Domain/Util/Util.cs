namespace Domain.Util;
using System;
using System.Net.NetworkInformation;
using Domain.Model;

public static class Util
{
    public static List<User> GetMockUserList()
    {
        return new List<User>()
            {
                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},
                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Role = new Role{Name = "User"},
                    Posts = new List<Post> {new Post {Title = "Title", Content = "Content of the post", CreationTime = DateTime.Now}}},

            };
    }
}