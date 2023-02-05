namespace Infrastructure;

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
        {
            context.Users.AddRange(Util.GetMockUserList());
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
                .Include(a => a.Role)
                .ToList();
            return users;
        }
    }
}