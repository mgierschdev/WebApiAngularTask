namespace Domain.Model;

using System;
using System.Reflection.Metadata;

public class Role
{
    public int Id { get; set; }
    public string RoleName { get; set; }
    public DateTime CreationTime { get; set; }
}
