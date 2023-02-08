namespace Infrastructure.Util;
using System;
using System.Net.NetworkInformation;
using Infrastructure.Model;

public static class Util
{
    public static List<User> GetMockUserList()
    {
        return new List<User>()
            {

            new User {
                    FirstName = "TestUserFirstName",
                    LastName =  "TestUserSecondName",
                    Email = "email1@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 1", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 2", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 3", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 4", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "2TestUserFirstName",
                    LastName =  "2TestUserSecondName",
                    Email = "email2@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 5", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 6", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "3TestUserFirstName",
                    LastName =  "3TestUserSecondName",
                    Email = "email3@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 7", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "4TestUserFirstName",
                    LastName =  "4TestUserSecondName",
                    Email = "email4@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 8", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 9", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 10", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 11", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

                new User {
                    FirstName = "5TestUserFirstName",
                    LastName =  "5TestUserSecondName",
                    Email = "email5@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 12", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "6TestUserFirstName",
                    LastName =  "6TestUserSecondName",
                    Email = "email6@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 13", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 14", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "7TestUserFirstName",
                    LastName =  "7TestUserSecondName",
                    Email = "email7@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 13", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 14", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "8TestUserFirstName",
                    LastName =  "8TestUserSecondName",
                    Email = "email8@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 15", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 16", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "9TestUserFirstName",
                    LastName =  "9TestUserSecondName",
                    Email = "email9@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 17", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 18", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "10TestUserFirstName",
                    LastName =  "10TestUserSecondName",
                    Email = "email10@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 19", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 20", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            new User {
                    FirstName = "11TestUserFirstName",
                    LastName =  "11TestUserSecondName",
                    Email = "email11@provider.com",
                    PhoneNumber = "+4312345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    Posts = new List<Post> {
                        new Post {Title = "Post Title 21", Content = "Content of the post", CreationTime = DateTime.Now},
                        new Post {Title = "Post Title 22", Content = "Content of the post", CreationTime = DateTime.Now},
                    }},

            };
    }
}