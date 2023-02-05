namespace Domain.Util;
using System;
using System.Net.NetworkInformation;
using Domain.Model;

public static class Util
{

    public static List<Role> GetMockRoleList()
    {
        return new List<Role>
        {
           new Role{ RoleName = "User", CreationTime = DateTime.Now},
           new Role{ RoleName = "Admin", CreationTime = DateTime.Now},
        };
    }

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
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now},
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

                new User {
                    FirstName = "FirstName",
                    LastName =  "LastName",
                    Email = "email@provider.com",
                    PhoneNumber = "(+43)12345678",
                    ProfileViews = 0,
                    CreationTime = DateTime.Now,
                    LastLoginTime = DateTime.Now,
                    UserRole = new Role {RoleName = "User", CreationTime = DateTime.Now}},

            };
    }
}