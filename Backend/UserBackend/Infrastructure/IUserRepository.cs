namespace Infrastructure;

using System;
using Domain.Model;

public interface IUserRepository
{
    public List<User> GetUsers();
}

