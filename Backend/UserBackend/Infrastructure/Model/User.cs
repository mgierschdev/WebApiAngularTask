namespace Infrastructure.Model;

using System;
using System.Reflection.Metadata;
using Domain.User;

// Infrastructure model
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int ProfileViews { get; set; }
    public DateTime LastLoginTime { get; set; }
    public DateTime CreationTime { get; set; }
    public List<Post> Posts { get; set; }

    public User(APIUser apiUser)
    {
        this.FirstName = apiUser.FirstName;
        this.LastName = apiUser.LastName;
        this.Email = apiUser.Email;
        this.PhoneNumber = apiUser.PhoneNumber;
        ProfileViews = 0;
        LastLoginTime = DateTime.Now;
        CreationTime = DateTime.Now;
        Posts = new List<Post>();
    }

    // This method update the fields of the user
    public void Update(APIUser apiUser)
    {
        FirstName = apiUser.FirstName != null ? apiUser.FirstName : FirstName;
        LastName = apiUser.LastName != null ? apiUser.LastName : LastName;
        PhoneNumber = apiUser.PhoneNumber != null ? apiUser.PhoneNumber : PhoneNumber;
        Email = apiUser.Email != null ? apiUser.Email : Email;
    }
}