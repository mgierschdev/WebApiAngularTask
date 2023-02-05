namespace Domain.Model;

using System;
using System.Reflection.Metadata;

public class User
{
    public Guid UserId { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int ProfileViews { get; set; }
    public Role UserRole { get; set; }
    public DateTime LastLoginTime { get; set; }
    public DateTime CreationTime { get; set; }

    public User(string FirstName, string LastName, string Email, string PhoneNumber, Role UserRole)
    {
        this.UserId = Guid.NewGuid();
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.UserRole = UserRole;
        this.ProfileViews = 0;
        LastLoginTime = DateTime.Now;
        CreationTime = DateTime.Now;
    }
}