namespace Infrastructure;

using System;
using Domain.Model;

public class UserRepository : IUserRepository
{
	public UserRepository()
	{
	}

	public List<User> GetUsers()
	{
		return new List<User>();
	}
}