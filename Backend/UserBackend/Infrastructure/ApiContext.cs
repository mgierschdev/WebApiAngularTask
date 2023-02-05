namespace Infrastructure;
using System;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

public class ApiContext : DbContext
{
    public DbSet<User> Users { get; set; }
	public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseInMemoryDatabase(databaseName: "UserDatabase");
	}
}