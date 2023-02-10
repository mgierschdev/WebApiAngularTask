namespace Infrastructure;
using System;
using Infrastructure.Model;
using Infrastructure.Util;
using Microsoft.EntityFrameworkCore;

public class ApiContext : DbContext
{
    public DbSet<User> Users { get; set; }
	public DbSet<Post> Posts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseInMemoryDatabase(databaseName: "UserDatabase");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>()
			.HasOne<Post>()
			.WithMany();
	}
}